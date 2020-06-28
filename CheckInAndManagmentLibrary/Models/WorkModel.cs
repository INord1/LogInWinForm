using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInAndManagmentLibrary.Models
{
    class WorkModel
    {

        //public string Position { get; set; }

        public List<PaymentModel> Payment { get; set; } = new List<PaymentModel>();
    }
}
