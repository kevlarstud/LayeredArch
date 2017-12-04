using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Exceptions;

namespace DataAccessLayer
{
    //Data Access Layer Class
    public class CustomerOperations
    {
        static List<Customer> customerList = new List<Customer>();
        //Method to add new Customer
        public bool AddCustomer(Customer cobj)
        {
            bool result = false;
            try
            {
                customerList.Add(cobj);
                result = true;
            }
            catch (CustomerException)
            {

                throw;
            }

            return result;
        }
        //Method to display all the Customers
        public List<Customer> DisplayCustomer()
        {
            return customerList;
        }
        //Method to search Customer
        public Customer SearchCustomer(string customerId)
        {
            Customer cobj = null;
            foreach (Customer item in customerList)
            {
                if (item.CustomerId==customerId)
                {
                    cobj = item;
                    break;
                }
            }
            return cobj;
        }
        //   Method to delete Customer
        public bool DeleteCustomer(string customerId)
        {
            bool result = false;
            Customer cobj = null;
            foreach (Customer item in customerList)
            {
                if (item.CustomerId == customerId)
                {
                    cobj = item;
                    break;
                }
            }
            if (cobj != null)
            {
                customerList.Remove(cobj);
                result = true;
            }
            return result;
        }

        //Method to update Customer

        public bool UpdateCustomer(Customer cobj)
        {
            bool result = false;
            Customer c = null;
            foreach (Customer item in customerList)
            {
                if (item.CustomerId == cobj.CustomerId)
                {
                    c = item;
                    break;
                }
            }
            if (c != null)
            {
                c.CustomerId = cobj.CustomerId;
                c.CustomerName = cobj.CustomerName;
                c.DateOfBirth = cobj.DateOfBirth;
                c.Gender = cobj.Gender;
                c.Address = cobj.Address;
                result = true;
            }
            return result;
        }
    }
}
