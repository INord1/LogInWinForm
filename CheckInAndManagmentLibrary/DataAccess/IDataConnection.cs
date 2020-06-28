using CheckInAndManagmentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary.DataAccess
{
    public interface IDataConnection
    {
        PersonModel CreatePeron(PersonModel model);

        AutntificationModel CheckLogInandPassword(AutntificationModel autntification );
       
    }
}
