using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitLife.entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsHardcoded { get; set; } = false;
        public bool IsPredefined { get; set; } = false;
        public int answerId { get; set; }
    }

}