using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TirsvadWeb.Wasm.ProjectDocs.Infrastructure;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddInfrastructure();

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthenticationStateDeserialization();

await builder.Build().RunAsync();
