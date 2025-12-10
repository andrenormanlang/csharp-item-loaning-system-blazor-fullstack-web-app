using A6_ComicBooksLoanApp.Components;
using A6_ComicBooksLoanApp.Services;
using Blazored.LocalStorage;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

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
    var baseAddress = "http://localhost:5259"; // Changed from https to http for local dev
    var client = new HttpClient { BaseAddress = new Uri(baseAddress) };
    return client;
});

// Register API Bridge Services for WebAssembly client
// These services handle all communication with the backend API
builder.Services.AddScoped<ComicApiService>();
builder.Services.AddScoped<UserApiService>();
builder.Services.AddScoped<AuthService>();

// Register AuthStateProvider as a singleton to share auth state across components
builder.Services.AddSingleton<AuthStateProvider>();

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
    .AddAdditionalAssemblies(typeof(A6_ComicBooksLoanApp.Client._Imports).Assembly);

app.Run();
