using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCustomerInformationBusinessServiceLayer.ServiceParameters
{
    public class CustomerInformation
    {
        public int SNO { get; set; }
        public int CustomerID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
    }
}
