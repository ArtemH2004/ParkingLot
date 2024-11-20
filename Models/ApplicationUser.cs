using Microsoft.AspNetCore.Identity;

namespace ParkingLotApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Client Client { get; set; } 
    }

}
