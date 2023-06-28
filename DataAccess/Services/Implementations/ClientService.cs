using DataAccess.DataContext;
using DataAccess.Models;
using DataAccess.Services.Interfaces;

namespace DataAccess.Services.Implementations
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async void CaptureClientDetails(Client client)
        {
            if (IsDuplicateClientName(client.Name))
            {
                Console.WriteLine("A client with the same name already exists.");
                return;
            }

            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            Console.WriteLine("Client details captured successfully.");
        }

        public void DisplayClientAnalytics()
        {
            DisplayUsersPerLocation();
            DisplayTotalUsers();
            DisplayClientsPerDate();
        }

        private void DisplayUsersPerLocation()
        {
            Console.WriteLine("Number of users per location:");

            var usersPerLocation = _context.Clients.GroupBy(client => client.Location)
                                           .Select(group => new {
                                               Location = group.Key,
                                               TotalUsers = group.Sum(client => client.NumberOfUsers)
                                           })
                                           .ToDictionary(x => x.Location, x => x.TotalUsers);

            foreach (var user in usersPerLocation)
            {
                Console.WriteLine($"{user.Key}: {user.Value}");
            }
        }

        private void DisplayTotalUsers()
        {
            int totalUsers = _context.Clients.Sum(client => client.NumberOfUsers);

            Console.WriteLine($"Total users: {totalUsers}");
        }

        private void DisplayClientsPerDate()
        {
            Console.WriteLine("Number of clients created per date:");

            var clientsPerDate = _context.Clients.GroupBy(client => client.DateRegistered.Date)
                                         .ToDictionary(group => group.Key, group => group.Count());

            foreach (var user in clientsPerDate)
            {
                Console.WriteLine($"{user.Key.ToShortDateString()}: {user.Value}");
            }
        }

        private bool IsDuplicateClientName(string name) => _context.Clients.Any(c => c.Name == name);
    }
}
