using Microsoft.EntityFrameworkCore;
using sistema_acessidoc.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Conexão com o pacote Npgsql do Postgre
builder.Services.AddEntityFrameworkNpgsql()
    .AddDbContext<AcessiDocContext>(
        options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Login}/{action=Login}/{id?}");
});

app.Run();
