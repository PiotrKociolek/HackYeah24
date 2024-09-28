using FitLife.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitLife.entities
{
    public class Post
    {
        public int Id {get; set;}
        public PostCategory PostCategory { get; set;}
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Thumbnail_Id {get; set;}
        public int? userId {get; set;}
        public User? User {get; set;}
    }
}