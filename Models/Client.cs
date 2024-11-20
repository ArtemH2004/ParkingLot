namespace ParkingLotApp.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PassportData { get; set; }
        public bool HasDiscount { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public List<Contract> Contracts { get; set; }
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public Client()
        {
            Contracts = new List<Contract>();
        }
    }
}
