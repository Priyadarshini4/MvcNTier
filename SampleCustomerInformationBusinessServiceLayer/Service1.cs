using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SampleCustomerInformationDataAccessLayer;

namespace SampleCustomerInformationBusinessServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region IService1 Members

        #region Register Customer
        public RegisterCustomerRequest RegisterCustomer(RegisterCustomerRequest request)
        {
            try
            {
                var registerCustomerDal = new RegisterCustomerDataAccessLayer();
                var customer = registerCustomerDal.RegisterCustomer(request.FirstName, request.LastName, request.Email, request.PhoneNumber, request.Password);
                if (customer)
                    request.RegisterCustomerResponse = "Success";
                else
                    request.RegisterCustomerResponse = "Failure";
                return request;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            throw new NotImplementedException();
        }
        #endregion

        #region Login Customer
        public LoginCustomerRequest LoginCustomer(LoginCustomerRequest request)
        {
            try
            {
                var customerLoginDal = new CustomerLoginDataAccessLayer();
                var validateLogin = customerLoginDal.LoginCustomer(request.UserName, request.Password);
                if (validateLogin)
                    request.LoginCustomerResponse = "Login Successful";
                else
                    request.LoginCustomerResponse = "Login Failed";
                return request;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}
