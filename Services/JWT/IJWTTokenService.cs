
using ECommerce.Data.UserModels;

namespace ECommerce.Services.JWT
{
    public interface IJWTTokenService
    {
        string GenerateToken(ApplicationUser user);
        
    }
}