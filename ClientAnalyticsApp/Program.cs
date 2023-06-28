using ClientAnalyticsApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Client Analytics Application");
        Console.WriteLine("----------------------------");

        var startup = new Startup();
        var analyticsService = startup.GetClientAnalyticsService();

        analyticsService.DisplayClientAnalytics();

        Console.ReadLine();
    }
}

