using FitLife.entities;
using FitLife.Model;

namespace FitLife.Repositories;

public interface IAuthReposiotry
{
    Task<int> RegisterAsync(User user, string password);
    Task<ServiceResponse<string>> LoginAsync(string email, string password);
}