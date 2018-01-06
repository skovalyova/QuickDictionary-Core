using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QuickDictionary.DataAccess.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Token { get; set; }

        public virtual ICollection<Dictionary> Dictionaries { get; set; }

        public ApplicationUser()
        {
            Dictionaries = new List<Dictionary>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}
