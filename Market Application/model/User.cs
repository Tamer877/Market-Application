using Market_Application.enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Application.model
{
    public class User
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string region { get; set; }

        public string password { get; set; }
        public string authority { get; set; }
        public string email { get; set; }
        public string securityQuestion { get; set; }
        public string securityAnswer { get; set; }
        public loginStatus status { get; set; }

        public User()
        {
          
        }

        public User(int id,string userName,string password,string authority,string email,string securityQuestion,string securityAnswer,loginStatus status)
        {
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.authority = authority;
            this.email = email;
            this.securityQuestion = securityQuestion;
            this.securityAnswer = securityAnswer;
            this.status = status;
                
        }
    }
}
