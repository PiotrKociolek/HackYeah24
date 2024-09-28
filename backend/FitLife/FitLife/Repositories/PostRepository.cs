using FitLife.Data;
using FitLife.Dtos;
using FitLife.entities;
using FitLife.Services;
using Microsoft.EntityFrameworkCore;

namespace FitLife.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _context;
        public PostRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Post>> GetAllAsync()
        {
            return await _context.Posts.ToListAsync();
        }


        public async Task<Post> GetByIdAsync(int id)
        {
            return await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
        }


        public async Task<Post> UpdateAsync(int id,CreatePostDtos dto)
        {
            var existingPost = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);
            if (existingPost == null)
            {
                throw new Exception("post is null");
            }
            existingPost.Title = dto.Title;
            existingPost.Description = dto.Description;
            existingPost.PostCategory = dto.PostCategory;

            await _context.SaveChangesAsync();
            return existingPost;
        }



        public async Task DeleteAsync(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post != null)
            {
                _context.Posts.Remove(post);
                await _context.SaveChangesAsync();
            }
        }


        public async Task<Post> CreateAsync(CreatePostDtos dto)
        {
            Post post = new Post
            {
                PostCategory = dto.PostCategory,   // Mapowanie kategorii
                Title = dto.Title,                 // Mapowanie tytułu
                Description = dto.Description      // Mapowanie opisu
            };

            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            
            return post;
        }
    }
}
