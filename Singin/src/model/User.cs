using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singin.src.model
{
    public class User
    {
        string name;
        string password;

        public User()
        {

        }

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
