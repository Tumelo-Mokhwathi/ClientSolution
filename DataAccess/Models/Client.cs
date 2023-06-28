namespace DataAccess.Models
{
    public class Client
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Location { get; set; }
        public int NumberOfUsers { get; set; }
    }
}