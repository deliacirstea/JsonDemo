using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{

    public class Enrollment
    {
        public string action { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string course { get; set; }
        public int enrollment_fee { get; set; }
        public bool paid { get; set; }
    }

}
