using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

// Add the API project by name
var api = builder.AddProject("SimpleAspireApp.Api");

// Add the Worker project and reference the API
builder.AddProject("SimpleAspireApp.Worker")
       .WithReference(api);

builder.Build().Run();
