
using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Concrete;
using StoreApp.Data.Abstract;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreAppDbContext>( options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:SqliteConString"], b => b.MigrationsAssembly("StoreApp.Web"));
} );

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
