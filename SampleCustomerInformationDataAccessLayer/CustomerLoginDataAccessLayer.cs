using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCustomerInformationDataAccessLayer.Model;

namespace SampleCustomerInformationDataAccessLayer
{
    public class CustomerLoginDataAccessLayer
    {
        #region Customer Login
        public bool LoginCustomer(string userName, string loginPassword)
        {
            try
            {
                using (var dbContext = new SampleCustomerInformationEntities())
                {
                    CustomerInformation customer = new CustomerInformation();
                    customer = dbContext.CustomerInformations.FirstOrDefault(x => x.User_Name == userName && x.Password == loginPassword);
                    if (customer != null)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
