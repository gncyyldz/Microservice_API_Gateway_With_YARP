var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/api2", (HttpContext httpContext) =>
{
    return "API 2";
});

app.Run();
