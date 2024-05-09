using Microsoft.FeatureManagement;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddFeatureManagement(builder.Configuration.GetSection("Features"));

WebApplication app = builder.Build();
app.MapControllers();
app.Run();
