using Microsoft.AspNetCore.Identity;

namespace ParkingLotApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Client Client { get; set; }
    }
}
