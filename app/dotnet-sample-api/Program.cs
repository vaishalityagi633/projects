var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Azure DevOps CI/CD Working!");

app.Run();
