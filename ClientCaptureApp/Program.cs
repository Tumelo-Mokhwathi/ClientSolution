using ClientCaptureApp;
using DataAccess.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Client Capture Application");
        Console.WriteLine("--------------------------");

        var startup = new Startup();
        var captureService = startup.GetClientCaptureService();

        Client client = new Client();
        client.ID = Guid.NewGuid();
        client.Name = GetInput("Client Name");
        client.DateRegistered = GetDateTimeInput("Date Registered (yyyy-MM-dd)");
        client.Location = GetInput("Location");
        client.NumberOfUsers = GetIntInput("Number of Users");

        string GetInput(string prompt)
        {
            Console.Write($"Enter {prompt}: ");
            return Console.ReadLine()!;
        }

        DateTime GetDateTimeInput(string prompt)
        {
            while (true)
            {
                Console.Write($"Enter {prompt}: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
                {
                    return date;
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please try again.");
                }
            }
        }

        int GetIntInput(string prompt)
        {
            while (true)
            {
                Console.Write($"Enter {prompt}: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid number format. Please try again.");
                }
            }
        }

        captureService.CaptureClientDetails(client);

        Console.ReadLine();
    }
}

