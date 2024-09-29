using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitLife.entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }

}