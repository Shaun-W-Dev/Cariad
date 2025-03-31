global using Cariad.Domain.Models;
using Cariad.UINoAuth.Components;
using Cariad.Application.Interfaces;
using Cariad.Application.Services;
using Cariad.Infrastructure.Repositories;
using Microsoft.AspNetCore.Components.Server;
using MudBlazor.Services;
using System.IO.Compression;
using Microsoft.AspNetCore.ResponseCompression;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true; 
    options.MimeTypes =
    [
        "text/plain",
        "text/css",
        "application/javascript",
        "text/html",
        "application/json",
        "application/xml",
        "image/svg+xml",
        "application/wasm"
    ];

    options.Providers.Add<BrotliCompressionProvider>();
    options.Providers.Add<GzipCompressionProvider>();
});

builder.Services.Configure<BrotliCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Optimal;
});

builder.Services.Configure<GzipCompressionProviderOptions>(options =>
{
    options.Level = CompressionLevel.Optimal;
});


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.Configure<CircuitOptions>(options =>
{
    options.DetailedErrors = true;
});

builder.Services.AddMudServices();

builder.Services.AddSingleton<ICaresScreensService, CaresScreenService>();
builder.Services.AddSingleton<ICaresScreensRepository, CaresScreenRepo>();
builder.Services.AddSingleton<IActionsRepository, ActionsRepository>();


var app = builder.Build();

app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        ctx.Context.Response.Headers.Append("Cache-Control", "public, max-age=604800");
    }
});

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseResponseCompression();
app.UseStaticFiles();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Cariad.UINoAuth.Client._Imports).Assembly);

await app.RunAsync();