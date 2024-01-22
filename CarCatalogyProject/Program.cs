using CarCatalogyProject.Data;
using CarCatalogyProject.Data.interfaces;
using CarCatalogyProject.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
public class Program
{
    public static async Task Main(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllersWithViews();

    builder.Services.AddDbContext<AppDBContent>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Services.AddScoped<IAllCars, CarRepository>();
    builder.Services.AddScoped<ITypeOfCar, TypeRepository>();
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
        await ConfigureAsync(app, builder.Environment);
        app.Run();
}
    private static async Task ConfigureAsync(WebApplication app, IHostEnvironment env)
    {
        using (var scope = app.Services.CreateScope())
        {
            var content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            await DBObject.Initial(content);
        }
    }
}