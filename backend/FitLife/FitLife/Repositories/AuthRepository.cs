using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FitLife.Data;
using FitLife.entities;
using FitLife.Enum;
using FitLife.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;


namespace FitLife.Repositories;

public class AuthRepository: IAuthReposiotry
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthRepository(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }
    public async Task<int> RegisterAsync(User user, string password)
    {
        if (await UserExistsAsync(user.Email))
        {
            throw new Exception("User already exists."); // Or return a specific error code
        }

        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        user.PasswordHash = passwordHash;
        user.Role = Role.User;
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user.Id; // Return the user ID directly
    }
    private  async Task<bool> UserExistsAsync(string email)
    {
        if (await _context.Users.AnyAsync(u => u.Email.ToLower() == email.ToLower()))
        {
            return true;
        }
        return false;
    }
    public async Task<ServiceResponse<string>> LoginAsync(string email, string password)
    {
        var response = new ServiceResponse<string>();
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Email.ToLower().Equals(email.ToLower()));
        if (user is null)
        {
            response.Success = false;
            response.Message = "User not found.";
        }
        else if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
        {
            response.Success = false;
            response.Message = "Wrong password.";
        }
        else
        {
            response.Data = CreateToken(user);
            response.Message = "Logged in.";
        }

        return response;
    }
   
    private string CreateToken(User user)
    {
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Surname)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
            _configuration.GetSection("AppSettings:Token").Value!));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

}