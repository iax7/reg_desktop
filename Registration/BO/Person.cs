using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string comments { get; set; }
        public bool isconfirmed { get; set; }
        public bool ispresent { get; set; }
        public bool isnotified { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string password { get; set; }
        public string salt { get; set; }
        public bool ismale { get; set; }
        public string church { get; set; }
        public bool isadmin { get; set; }
        public bool assist_v { get; set; }
        public bool assist_s { get; set; }
        public bool assist_d { get; set; }
        public bool assist_l { get; set; }
        public int total { get; set; }
        public int amount_paid { get; set; }
        public int age { get; set; }
        public List<Guest> guests { get; set; }
        public Food food { get; set; }
        public Allocation allocation { get; set; }
    }
}
