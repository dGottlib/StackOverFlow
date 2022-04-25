using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework54_StackOverFlow.Data
{
   public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<QuestionTag> QuestionTags { get; set; } = new List<QuestionTag>();
    }
}
