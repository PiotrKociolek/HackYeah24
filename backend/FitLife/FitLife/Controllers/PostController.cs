using FitLife.Dtos;
using FitLife.entities;
using FitLife.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitLife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepo;

        public PostController(IPostRepository postRepo)
        {
            _postRepo = postRepo;
        }
        [HttpGet("dupa")]
        public async Task<IActionResult> GetAll()
        {
            var posts = await _postRepo.GetAllAsync();
            return Ok(posts);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var post = await _postRepo.GetByIdAsync(id);
            if(post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePostDtos dto)
        {
            await _postRepo.CreateAsync(dto);

            return Created();
                }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] CreatePostDtos dto)
        {
            await _postRepo.UpdateAsync(id, dto);
            return Ok(dto);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromHeader]int id)
        {
            await _postRepo.DeleteAsync(id);
            return Ok();
        }
    }
}
