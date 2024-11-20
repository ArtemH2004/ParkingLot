using System;

namespace ParkingLotApp.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
        public int ParkingSpaceId { get; set; }
        public ParkingSpace ParkingSpace { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

    }
}
