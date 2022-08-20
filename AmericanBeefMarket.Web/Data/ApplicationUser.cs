using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AmericanBeefMarket.Web.Data
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		[StringLength(128, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 16)]
		public string Name { get; set; }

		[Required]
		[StringLength(128, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 16)]
		public string Address { get; set; }
    }
}
