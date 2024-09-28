using FitLife.entities;
using FitLife.Enum;

namespace FitLife.Dtos
{
    public class CreatePostDtos
    {
        public PostCategory PostCategory { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}