using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_12.Model
{
    public class UserNPasswords
    {
        public int UId { get; set; }
        protected string UserName   { get; set; }
        protected string Password { get; set; }
        protected bool Admin { get; set; }
    }
}