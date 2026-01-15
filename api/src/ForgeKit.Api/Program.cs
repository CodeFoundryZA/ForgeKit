using ForgeKit.Controllers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
const string localCorsPolicy = "LocalDevCors";

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ForgeKit API",
        Version = "v1"
    });
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(localCorsPolicy, policy =>
        policy.WithOrigins(
                "http://localhost:3000",
                "http://localhost:3001",
                "http://127.0.0.1:3000",
                "http://127.0.0.1:3001")
            .AllowAnyHeader()
            .AllowAnyMethod());
});
builder.Services
    .AddControllers()
    .AddApplicationPart(typeof(AssemblyMarker).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(localCorsPolicy);
app.MapControllers();
app.MapGet("/healthz", () => Results.Ok(new { status = "ok" }));

app.Run();
