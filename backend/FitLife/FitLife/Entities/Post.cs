using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitLife.entities
{
    public class Post
    {
        public int Id {get; set;}
        //public {enum} Category
        public string Title {get; set;}
        public int? Thumbnail_Id {get; set;}
        public int? userId {get; set;}
        public User? User {get; set;}
    }
}