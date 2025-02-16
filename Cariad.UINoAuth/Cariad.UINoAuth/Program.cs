global using Cariad.Domain.Models;
global using Cariad.Domain.DTOs;
global using System.Text;
using Cariad.UINoAuth.Components;
using Cariad.Application.Interfaces;
using Cariad.Application.Services;
using Cariad.Infrastructure.Repositories;
using Microsoft.AspNetCore.Components.Server;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.Configure<CircuitOptions>(options =>
{
    options.DetailedErrors = true;
});

builder.Services.AddSingleton<ICaresScreensService, CaresScreenService>();
builder.Services.AddSingleton<ICaresScreensRepository, CaresScreenRepo>();
builder.Services.AddSingleton<IActionsRepository, ActionsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Cariad.UINoAuth.Client._Imports).Assembly);

await app.RunAsync();