using System.Collections.Generic;

namespace ParkingLotApp.Models
{
    public class ParkingSpace
    {
        public int ParkingSpaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public bool IsOccupied { get; set; }
        public string? Comments { get; set; }
        public int ParkingLotId { get; set; }
        public ParkingLot ParkingLot { get; set; }

        public List<Contract> Contracts { get; set; }

        public ParkingSpace()
        {
            Contracts = new List<Contract>();
        }
    }
}
