using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework54_StackOverFlow.Data
{
   public class QuestionTag
    {
        public int TagId { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public Tag Tag { get; set; }
    }
}
