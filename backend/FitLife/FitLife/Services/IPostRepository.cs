using FitLife.Dtos;
using FitLife.entities;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Services
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync();

        Task<Post> GetByIdAsync(int id);
        Task<Post> CreateAsync(CreatePostDtos dto);
        Task<Post> UpdateAsync(int id, CreatePostDtos dto);
        Task DeleteAsync(int id);
    }
}
