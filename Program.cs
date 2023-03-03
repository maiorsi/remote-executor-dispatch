using Microsoft.OpenApi.Models;
using Serilog;

using var log = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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
