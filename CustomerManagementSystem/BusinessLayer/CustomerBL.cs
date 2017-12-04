using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Exceptions;
using DataAccessLayer;
using System.Text.RegularExpressions;


namespace BusinessLayer
{
    public class CustomerBL
    {
        public bool Validate(Customer cobj)
        {
            bool isValid = true;
            StringBuilder sb = new StringBuilder();
            if (cobj.CustomerId.Length!=6)
            {
                sb.Append("Length must be exactly 6");
                isValid = false;
            }
            if (!Regex.IsMatch(cobj.CustomerId, @"[A-Z]{2}[0-9]{4}"))
            {
                sb.Append("Id should be exactly 6 digits and First two characters must be Capital.");
                isValid = false;
            }
            if (cobj.CustomerName == string.Empty)
            {
                sb.Append("Name cannot be empty");
                isValid = false;
            }
            if (!Regex.IsMatch(cobj.CustomerName, @"[A-Za-z\S]{4,10}"))
            {
                sb.Append("Customer Name must be letters or should be 4 to 10 characters");
                isValid = false;
            }
            if (!Regex.IsMatch(cobj.Gender.ToString(), @"[M|F|m|f]{1}"))
            {
                sb.Append("Gender can be M or F");
                isValid = false;
            }
            if ((DateTime.Now.Year - cobj.DateOfBirth.Year) < 20)
            {
                sb.Append("Age should be 20 years and below.");
                isValid = false;
            }
            if (!Regex.IsMatch(cobj.Address, @"[A-Za-z0-9\S]"))
            {
                sb.Append("Address should be alphanumeric and one space is allowed");
                isValid = false;
            }
            if (isValid == false)
            {
                throw new CustomerException(sb.ToString());
            }
            return isValid;
        }
        //Method to add new product
        public bool AddCustomer(Customer cobj)
        {
            bool result = false;
            //checking if the product object is valid
            if (Validate(cobj))
            {
                //Creating DAL class object
                CustomerOperations co = new CustomerOperations();


                //Invoking its AddProduct method
                return co.AddCustomer(cobj);
            }
            return result;
        }

        //Method to display customer
        public List<Customer> DisplayCustomer()
        {
            CustomerOperations co = new CustomerOperations();
            return co.DisplayCustomer();
        }
        //Method to search customer
        public Customer SearchCustomer(string customerId)
        {
            CustomerOperations co = new CustomerOperations();
            return co.SearchCustomer(customerId);
        }
        //Method to delete customer
        public bool DeleteCustomer(string customerId)
        {
            CustomerOperations co = new CustomerOperations();
            return co.DeleteCustomer(customerId);
        }

        //Method to update customer
        public bool UpdateCustomer(Customer cobj)
        {
            bool result = false;
            if (Validate(cobj))
            {
                CustomerOperations co = new CustomerOperations();
                result = co.UpdateCustomer(cobj);
            }
            return result;
        }
    }
}
