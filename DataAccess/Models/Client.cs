namespace DataAccess.Models
{
    public class Client
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateRegistered { get; set; }
        public string Location { get; set; } = string.Empty;
        public int NumberOfUsers { get; set; }
    }
}
