﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework54_StackOverFlow.Data
{
  public  class Like
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public User User { get; set; }
        public Question Question { get; set; }
    }
}
