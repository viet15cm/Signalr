using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace SignalR.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

       
    }
}
