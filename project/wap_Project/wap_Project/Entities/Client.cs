using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_Project.Entities
{
    // first name
    // last name
    // email
    // age -> must be over 18
    // username
    // password
    // phone number (validating for romanian phone numbers only)
    // mr / mrs / ms / unspecified -> enum
    // gender -> enum

    [Serializable]
    public class Client
    {
        protected string first_name { get; set; }
        protected string last_name { get; set; }
        protected int age { get; set; }
        protected string email { get; set; }
    }
}
