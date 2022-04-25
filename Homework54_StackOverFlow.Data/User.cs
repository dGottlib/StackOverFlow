using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework54_StackOverFlow.Data
{
  public  class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public List<Like> Likes { get; set; }  = new List<Like>();
        public List<Question> Questions { get; set; }  = new List<Question>();
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
