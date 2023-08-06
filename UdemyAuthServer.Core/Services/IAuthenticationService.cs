using SharedLibrary.Dtos;
using System.Threading.Tasks;
using UdemyAuthServer.Core.Dtos;

namespace UdemyAuthServer.Core.Services
{
    public interface IAuthenticationService
    {
        //AccessToken creation
        Task<Response<TokenDto>> CreateToken(LoginDto loginDto);
        Task<Response<TokenDto>> CretaeTokenByRefreshToken(string refreshToken);

        //Refresh tokeni sonlandirmaq bu esasen logout oldugunda olur.
        Task<Response<NoDataDto>> RevokeRefreshToken(string refreshToken);
        Task<Response<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
