namespace ParkingLotApp.Models
{
    public class VehicleType
    {
        public int VehicleTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public char RequiredCategory { get; set; }
    }
}
