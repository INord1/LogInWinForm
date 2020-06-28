using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary.Models
{
   public class PersonModel
    {
        public int Id { get; set; }

        public string LogIn { get; set; }

        public string Password { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string CellphoneNumber { get; set; }


      

        public PersonModel(string logIn,string password,string firstName, string lastName,
      string emailAddress, string cellPhoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.CellphoneNumber = cellPhoneNumber;
            this.LogIn = logIn;
            this.Password = password;
        }



    }


}
