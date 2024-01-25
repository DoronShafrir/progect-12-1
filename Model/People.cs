using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_12.Model
{
    public class People : UserNPasswords
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string SurName { get; set; }
        public string IdCardNumber { get; set; }
    }
}