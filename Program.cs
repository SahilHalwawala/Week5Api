var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger for BOTH local and Azure
app.UseSwagger();
app.UseSwaggerUI();

// HTTPS redirection

// Simple endpoint for the lab
app.MapGet("/hello", () => "Hello from your Azure API running .NET 9");

app.Run();
