using CursoMvc.Models;
using Microsoft.EntityFrameworkCore;
using CursoMvc.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
        builder.Services.AddDbContext<CursoMvcContext>
            (options => options.UseSqlServer(configuration.GetConnectionString("ConexaoLocal")));

        var app = builder.Build();

        //var aa = builder.Services.AddScoped<SeedingService>();

        //SeedingService seed = new SeedingService();
       // seed.Seed();
       // aa.AddDbContext<CursoMvcContext>();
        

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

        app.Run();
    }
}