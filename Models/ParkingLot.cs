using System.Collections.Generic;

namespace ParkingLotApp.Models
{
    public class ParkingLot
    {
        public int ParkingLotId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int QuantitySpace { get; set; }
        public int ParkingTypeId { get; set; }
        public ParkingType ParkingType { get; set; }
        public List<ParkingSpace> ParkingSpaces { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Guard> Guards { get; set; }

        public ParkingLot()
        {
            ParkingSpaces = new List<ParkingSpace>();
            Contracts = new List<Contract>();
            Drivers = new List<Driver>();
            Guards = new List<Guard>();
        }
    }
}
