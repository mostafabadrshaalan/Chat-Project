using Microsoft.EntityFrameworkCore;
using SignalR.Contexts;
using SignalR.Hubs;

namespace SignalR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ChatDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ChatConnection"));
            });

            builder.Services.AddSignalR();

            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles();

            app.UseEndpoints(endPoints =>
            {
                endPoints.MapHub<ChatHub>("/chat");
            });

            app.Run();
        }
    }
}
