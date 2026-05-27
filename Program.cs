var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5000);
    
});

var app = builder.Build();

app.MapGet("/api/data", () => new 
{
    Status = "success",
    Message = "Hello World! This is response from your automated C# ASP.NET Core 8.0 API.",
    Timestamp = DateTime.UtcNow.ToString("o")
});

app.Run();