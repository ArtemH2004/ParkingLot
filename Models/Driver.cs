﻿namespace ParkingLotApp.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public int ParkingLotId { get; set; }
        public ParkingLot ParkingLot { get; set; }
        public int ExperienceYears { get; set; }
        public decimal Salary { get; set; }
        public char OpenCategory { get; set; }
        public List<Vehicle> DeliveredVehicles { get; set; } // Многие ко многим

        public Driver()
        {
            DeliveredVehicles = new List<Vehicle>();
        }
    }
}
