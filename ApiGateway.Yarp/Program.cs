var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();
app.MapReverseProxy();
app.Run();
// This code sets up a YARP (Yet Another Reverse Proxy) API Gateway that routes requests based on the configuration specified in the "ReverseProxy" section of the appsettings.json file.
// It uses the YARP library to create a reverse proxy that can forward requests to different backend services based on the routing rules defined in the configuration.