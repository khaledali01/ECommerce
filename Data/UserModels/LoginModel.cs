using System.ComponentModel.DataAnnotations;

namespace ECommerce.Data.UserModels
{
    public class LoginModel
    {

        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}