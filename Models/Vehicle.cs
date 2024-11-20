using System.Collections.Generic;

namespace ParkingLotApp.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public int Year { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<Driver> Drivers { get; set; } // Связь с водителями
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }

        public Vehicle()
        {
            Drivers = new List<Driver>();
        }
    }
}
