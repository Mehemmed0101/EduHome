using EduHome.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace EduHome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<AppDbContext>(builder =>
            {
                builder.UseSqlServer(connectionString);
            });

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}");

                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

            app.Run();
        }
    }
}