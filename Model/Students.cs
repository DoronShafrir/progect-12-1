using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace task_12.Model
{
    public class Students : People
    {
        public int SId { get; set; }
        public int IdInIdTable { get; set; }
        public int FirstCourse { get; set; }
        public int SecondCourse { get; set; }
        public int ThirdCourse { get; set; }

    }
}