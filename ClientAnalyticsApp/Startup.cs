using Microsoft.Extensions.DependencyInjection;
using DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using DataAccess.Services.Interfaces;
using DataAccess.Services.Implementations;

namespace ClientAnalyticsApp
{
    public class Startup
    {
        private readonly IServiceProvider serviceProvider;

        public Startup()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IClientService, ClientService>();
            services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(DataAccess.Constants.General.connectionString));

            serviceProvider = services.BuildServiceProvider();
        }

        public IClientService GetClientAnalyticsService()
        {
            return serviceProvider.GetService<IClientService>()!;
        }
    }
}
