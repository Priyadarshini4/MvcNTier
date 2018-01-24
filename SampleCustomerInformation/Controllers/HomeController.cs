using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleCustomerInformation.SampleCustomerInformationServiceReference;

namespace SampleCustomerInformation.Controllers
{
    public class HomeController : Controller
    {

        SampleCustomerInformationServiceReference.Service1Client client = new SampleCustomerInformationServiceReference.Service1Client();
        // GET: Home View
        public ActionResult Home()
        {
            return View();
        }

        //This method is used to register new customer
        //This method is passed as a url to the Ajax function RegisterCustomer()
        public string RegisterCustomer(string firstName, string lastName, string email, string phoneNumber, string password)
        {
            try
            {
                SampleCustomerInformationServiceReference.RegisterCustomerRequest request = new SampleCustomerInformationServiceReference.RegisterCustomerRequest();
                request.FirstName = firstName;
                request.LastName = lastName;
                request.Email = email;
                request.PhoneNumber = phoneNumber;
                request.Password = password;

                var response = client.RegisterCustomer(request);
                return response.RegisterCustomerResponse;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //This method is used to login a customer
        //This method is passed as a url to the Ajax function LoginCustomer()
        public string LoginCustomer(string userName, string loginPassword)
        {
            try
            {
                SampleCustomerInformationServiceReference.LoginCustomerRequest request = new SampleCustomerInformationServiceReference.LoginCustomerRequest();
                request.UserName = userName;
                request.Password = loginPassword;

                var response = client.LoginCustomer(request);
                return response.LoginCustomerResponse;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}