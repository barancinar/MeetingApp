var builder = WebApplication.CreateBuilder(args);

// MVC hizmetlerini ekliyoruz
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

// Routing ayarları
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();