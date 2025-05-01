using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Market_Application.model
{
    public class LoginTable
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string region { get; set; }
        public string password { get; set; }
        public string authority { get; set; }
        public string email { get; set; }
        public string securityQuestion { get; set; }
        public string securityAnswer { get; set; }
    }
}
