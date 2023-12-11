using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class reg
    {
        string name;
        string password;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    name = "unknown name";
                }
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
                if (value != "")
                {
                    password = value;
                }
                else
                {
                    password = "unknown password";
                }
            }
        }
    }
}
