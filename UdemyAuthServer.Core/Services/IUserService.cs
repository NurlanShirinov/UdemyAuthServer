using SharedLibrary.Dtos;
using System.Threading.Tasks;
using UdemyAuthServer.Core.Dtos;

namespace UdemyAuthServer.Core.Services
{

    // buz burda yeni istifadecileri db - save edeceyik. Burda biz bu interfacein Repositorisin yazmadan servisin yazdiq cunki butun methodlar biz Identity kitabxanasindan gelir. 
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}