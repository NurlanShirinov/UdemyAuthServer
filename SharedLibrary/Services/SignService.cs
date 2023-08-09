using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace SharedLibrary.Services
{
    public class SignService
    {
        public static SecurityKey GetSymmetricSecurityKey(string ssecurityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(ssecurityKey));
        }
    }
}
