using AuthDataLayer.ResultModels;
using AuthDataLayer.ViewModels;
using System.Threading.Tasks;

namespace Check_In.Services
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginViewModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(UserViewModel registerModel);
    }
}