using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary.Models
{
    public class AutntificationModel
    {
        public string Login { get; set; }

        public string Password { get; set; }


        public AutntificationModel()
        {

        }
        public AutntificationModel(string logIn, string password)
        {

            this.Login = logIn;
            this.Password = password;
        }
    }

}
