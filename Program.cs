// <copyright file="Program.cs" owner="maiorsi">
// Licenced under the MIT Licence.
// </copyright>

using Microsoft.OpenApi.Models;

using RemoteExecutor.Dispatch.Interfaces;
using RemoteExecutor.Dispatch.Settings;

using Serilog;

using var log = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();
builder.Services.AddSignalR();
builder.Services.AddHealthChecks();

builder.Services.Configure<SigningSettings>(builder.Configuration.GetSection("Signing"));
builder.Services.Configure<ApiKeyAuthSettings>(builder.Configuration.GetSection("Security"));
builder.Services.Configure<SecuritySettings>(builder.Configuration.GetSection("Security"));

builder.Services.AddHostedService<NodeService>();
builder.Services.AddHostedService<StatusService>();

builder.Services.AddSingleton<HealthServiceImpl>();
builder.Services.AddSingleton<IMasterManager, MasterManagerService>();
builder.Services.AddSingleton<ISecurityService, SecurityService>();
builder.Services.AddSingleton<ISigningService, SigningService>();
builder.Services.AddSingleton<ICertificateValidationServiuce, CertificateValidationService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1.0.0", new OpenApiInfo
    {
        Title = "Remote Executor Dispatch API",
        Description = "API",
        Contact = new OpenApiContact { Name = "maiorsi", Email = "36492124+maiorsi@users.noreply.github.com" },
        License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://choosealicence.com/licences/mit/") },
        Version = "v1.0.0"
    });

    options.IncludeXmlComments("RemoteExecutor.Dispatch.xml");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1.0.0/swagger.json", "v1.0.0");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();