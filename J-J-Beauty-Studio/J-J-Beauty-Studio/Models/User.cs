using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace J_J_Beauty_Studio.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        
        public bool IsAdmin()
        {
            if (this.Username == "Admin" && this.Password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
