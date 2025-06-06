using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();

var app = builder.Build();
await app.UseOcelot();
app.Run();
// This code sets up an Ocelot API Gateway that routes requests to the OrderService and ProductService.