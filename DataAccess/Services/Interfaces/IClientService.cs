using DataAccess.Models;

namespace DataAccess.Services.Interfaces
{
    public interface IClientService
    {
        void DisplayClientAnalytics();
        void CaptureClientDetails(Client client);
    }
}
