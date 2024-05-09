using Microsoft.FeatureManagement;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddFeatureManagement(builder.Configuration.GetSection("Features"));

WebApplication app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.Run();
