using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCustomerInformationDataAccessLayer.Model;

namespace SampleCustomerInformationDataAccessLayer
{
    public class RegisterCustomerDataAccessLayer
    {
        #region Register Customer
        public bool RegisterCustomer(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            try
            {
                using (var dbContext = new SampleCustomerInformationEntities())
                {
                    CustomerInformation newCustomer = new CustomerInformation();
                    newCustomer.CustomerID = dbContext.CustomerInformations.Count() +1;
                    newCustomer.First_Name = firstName;
                    newCustomer.Last_Name = lastName;
                    newCustomer.Email = email;
                    newCustomer.Phone = phoneNumber;
                    newCustomer.Password = password;
                    newCustomer.User_Name = email;
                    dbContext.CustomerInformations.Add(newCustomer);
                    dbContext.SaveChanges();
                    return true;
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
