using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using System.Threading.Tasks;
using TP1_.Net;
using TP1_.Net.Repositories;

namespace TP1_.Net
{
    class Program
    {
     

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    // Configurer le DbContext
                    services.AddDbContext<SchoolContext>(options =>
                        options.UseNpgsql("Host=localhost;Port=5432;Database=SchoolDB;Username=postgres;Password=postgres;"));

                    // Ajouter UnitOfWork et Repository
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                });
    }
}
