using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SampleCustomerInformationBusinessServiceLayer
{
    [DataContract]
    public class LoginCustomerRequest
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string LoginCustomerResponse { get; set; }
    }
}
