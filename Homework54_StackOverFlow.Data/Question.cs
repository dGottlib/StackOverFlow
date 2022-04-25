using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework54_StackOverFlow.Data
{
   public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }       
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public List<QuestionTag> QuestionTags { get; set; } = new List<QuestionTag>();
        public List<Like> Likes { get; set; }  = new List<Like>();
        public List<Answer> Answers { get; set; } = new List<Answer>();
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
