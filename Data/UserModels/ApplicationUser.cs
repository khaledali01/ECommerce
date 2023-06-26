using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.UserModels
{
	public class ApplicationUser : IdentityUser
	{

		public bool IsAdmin {get; set;}
	}
}
