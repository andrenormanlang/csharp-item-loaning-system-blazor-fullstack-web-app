using A6_ComicBooksLoanApp.Components;
using A6_ComicBooksLoanApp.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.HttpOverrides;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Render (and similar platforms) inject a dynamic port via PORT.
// Binding explicitly avoids IPv6-only binds that can break platform health checks.
var port = Environment.GetEnvironmentVariable("PORT");
if (!string.IsNullOrWhiteSpace(port))
{
    builder.WebHost.UseUrls($"http://0.0.0.0:{port}");
}

// Add MudBlazor services
builder.Services.AddMudServices();

// Add Blazored LocalStorage service
builder.Services.AddBlazoredLocalStorage();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

// Configure HttpClient for API communication
builder.Services.AddScoped(sp =>
{
    var baseAddress = builder.Configuration["ApiBaseUrl"]
        ?? "http://localhost:5259";
    var client = new HttpClient { BaseAddress = new Uri(baseAddress) };
    return client;
});

// Register API Bridge Services for WebAssembly client
// These services handle all communication with the backend API
builder.Services.AddScoped<ComicApiService>();
builder.Services.AddScoped<UserApiService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<AdminApiService>();

// Register AuthStateProvider as a singleton to share auth state across components
builder.Services.AddSingleton<AuthStateProvider>();

var app = builder.Build();

// Lightweight endpoint for platform health checks.
app.MapGet("/healthz", () => Results.Ok("ok"));

// Render (and most container platforms) run behind a reverse proxy that terminates TLS.
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

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

// In container platforms, TLS is typically terminated at a reverse proxy.
// Avoid HTTPS redirection when PORT is provided (proxy handles external HTTPS).
if (string.IsNullOrWhiteSpace(port))
{
    app.UseHttpsRedirection();
}


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(A6_ComicBooksLoanApp.Client._Imports).Assembly);

app.Run();
