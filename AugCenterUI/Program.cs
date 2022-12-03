using AugCenterUI.Data.Interfaces;
using AugCenterUI.Data.Services;
using Syncfusion.Blazor;

var _UriHttps = "https://augcenterapi.azurewebsites.net/";
//var _UriHttp = "http://localhost:7221/";

var syncfusionLicenseKey = "NzY2NzYwQDMyMzAyZTMzMmUzMFJMQkc1c1dsdkI0OWhNY0Q1eEN0bUZDYWVHRWpsNmtHUU45ZDdWQ1hncms9";

var builder = WebApplication.CreateBuilder(args);

//Register Syncfusion License
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(syncfusionLicenseKey);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//Add syncfusion
builder.Services.AddSyncfusionBlazor();

//Base Address AugCenterAPI
builder.Services.AddScoped(_client => new HttpClient{BaseAddress = new Uri(_UriHttps) });

// Add Services trên Data của AugCenterUI
builder.Services.AddScoped<IProductService, ProductService>();

//builder.Services.AddSingleton<WeatherForecastService>(); //-> Single Page

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

/*Sử dụng cả HTTP hoặc HTTPS đều được
app.UseCors(policy => 
    policy.WithOrigins(_UriHttp, _UriHttps)
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)

);*/




app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
