using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wap_Project.Entities
{   
    // id - unique -> will act as primary key
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
        #region Attributes
        public Guid id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public int pronoun { get; set; }
        public long phone_number { get; set; }
        public SecurityQuestion security_question { get; set; }
        #endregion

        public Client() { }

        public Client(string fn, string ln, string email, int age, string username, string password, int secq, string secqans, 
            int pron, long phone) 
        {     
            this.id = Guid.NewGuid();
            this.first_name = fn;
            this.last_name = ln;
            this.password = password;
            this.username = username;
            this.email = email;
            this.age = age;
            this.pronoun = pronoun;
            this.phone_number = phone;

            security_question = new SecurityQuestion(secq, secqans);
        }

        public Client(Guid id, string fn, string ln, string email, int age, string username, string password, int secq, string secqans,
            int pron, long phone)
        {
            this.id = id;
            this.first_name = fn;
            this.last_name = ln;
            this.password = password;
            this.username = username;
            this.email = email;
            this.age = age;
            this.pronoun = pronoun;
            this.phone_number = phone;

            security_question = new SecurityQuestion(secq, secqans);
        }
    }
}
