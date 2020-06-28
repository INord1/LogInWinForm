using CheckInAndManagmentLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public PersonModel CreatePeron(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Work")))
            {
                var p = new DynamicParameters();
                p.Add("@LogIn", model.LogIn);
                p.Add("@Password", model.Password);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Email", model.EmailAddress);
                p.Add("@PhoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("spLogInTable",p,commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;

            }

        }


        public AutntificationModel CheckLogInandPassword(AutntificationModel autntification)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Work")))
            {
                var p = new DynamicParameters();
                p.Add("@LogIn", autntification.Login);
                p.Add("@Password", autntification.Password);
              

              connection.Execute("spCheckCredentials", p, commandType: CommandType.StoredProcedure);

              

                return autntification;

            }

        }
    }
}

	

	