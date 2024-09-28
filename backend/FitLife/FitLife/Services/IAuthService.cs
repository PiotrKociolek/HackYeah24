using FitLife.entities;
using FitLife.Model;

namespace FitLife.Services;

public interface IAuthService
{
    Task<int> RegisterAsync(User user, string password);
    Task<ServiceResponse<string>> LoginAsync(string email, string password);

}