using DataAccess.DataContext;
using DataAccess.Services.Implementations;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClientCaptureApp
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

        public IClientService GetClientCaptureService()
        {
            return serviceProvider.GetService<IClientService>()!;
        }
    }
}