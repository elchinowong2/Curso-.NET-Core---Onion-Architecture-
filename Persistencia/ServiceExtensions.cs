using aplication.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistencia.Context;
using Persistencia.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<applicationDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaulConnection"),
                b => b.MigrationsAssembly(typeof(applicationDbContext).Assembly.FullName)));

            services.AddTransient(typeof(IRepositoriAsync<>), typeof(MyRepositoryAsync<>));
            
        }
    }
}
