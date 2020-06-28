using CheckInAndManagmentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        public PersonModel CreatePeron(PersonModel model)
        {

           
            return model;
        }

        public AutntificationModel CheckLogInandPassword(AutntificationModel autntification)
        {


            return autntification;
        }
    }
}
