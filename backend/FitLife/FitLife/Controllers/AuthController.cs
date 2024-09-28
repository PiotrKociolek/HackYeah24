using FitLife.Dtos;
using FitLife.entities;
using FitLife.Model;
using FitLife.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("Register")]
    public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDto request)
    {
        var response = await _authService.RegisterAsync(
            new User { Name = request.Name, Email = request.Email, Surname = request.Surname },
            request.Password
        );
        return Ok(response);
    }
    [HttpPost("Login")]
    public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
    {
        var response = await _authService.LoginAsync(request.Email, request.Password);
        if (!response.Success)
        {
            return Unauthorized(response);
        }
        return Ok(response);
    }
}