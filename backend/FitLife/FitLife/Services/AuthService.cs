using FitLife.entities;
using FitLife.Model;
using FitLife.Repositories;

namespace FitLife.Services;

public class AuthService : IAuthService
{
    private readonly IAuthReposiotry _authReposiotry;

    public AuthService(IAuthReposiotry authReposiotry)
    {
        _authReposiotry = authReposiotry;
    }

    public async Task<int> RegisterAsync(User user, string password)
    {
        return await _authReposiotry.RegisterAsync(user, password);
    }

    public async Task<ServiceResponse<string>> LoginAsync(string email, string password)
    {
        return await _authReposiotry.LoginAsync(email, password);
    }
}