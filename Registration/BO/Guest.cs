using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class Guest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public int age { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public int person_id { get; set; }
        public bool ismale { get; set; }
        public string relation { get; set; }
    }
}
