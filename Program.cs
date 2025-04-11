//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();

//var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
  //  app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    //app.UseHsts();
//}
//app.UseHttpsRedirection();
//app.UseRouting();
//app.UseAuthorization();
//app.MapStaticAssets();
//app.MapRazorPages()
  // .WithStaticAssets();
//app.Run();


var builder = WebApplication.CreateBuilder(args);

// Agregar Razor Pages
builder.Services.AddRazorPages();

// 👉 Configuración de autenticación con cookies
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.LoginPath = "/Login"; // Página de inicio de sesión
        options.AccessDeniedPath = "/AccessDenied"; // Página si no tiene permisos
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 🧠 Importante: primero autenticación, luego autorización
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();

//app.UseHttpsRedirection();
//app.UseRouting();
//app.UseAuthorization();
//app.MapStaticAssets();
//app.MapRazorPages()
  // .WithStaticAssets();
//app.Run();