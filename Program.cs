using Microsoft.EntityFrameworkCore;
using GerenciamentoOficina.Data;
using Microsoft.AspNetCore.Identity;
using GerenciamentoOficina.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ContextBanco");

builder.Services.AddDbContext<GerenciamentoOficinaContext>(options =>
    options.UseSqlServer(connectionString));;

builder.Services.AddDefaultIdentity<SecurityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<GerenciamentoOficinaContext>();;


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("ContextBanco")));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
