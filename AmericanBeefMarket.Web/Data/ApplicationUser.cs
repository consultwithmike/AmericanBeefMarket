using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AmericanBeefMarket.Web.Data
{
	public class ApplicationUser : IdentityUser
	{
		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
		public string Name { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
		public string Address { get; set; }
	}
}
