using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Exceptions;
using BusinessLayer;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int choice = 0;
                do
                {
                    PrintMenu();
                    Console.WriteLine("Enter your choice:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddCustomer();
                            break;

                        case 2:
                            DisplayCustomer();
                            break;

                        case 3:
                            SearchCustomer();
                            break;

                        case 4:
                            UpdateCustomer();
                            break;

                        case 5:
                            DeleteCustomer();
                            break;

                        case 6:
                            break;
                        default:
                            Console.WriteLine("Invalid choice.Please try again");
                            break;
                    }
                } while (choice != 6);
            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void PrintMenu()
        {
            Console.WriteLine("Welcome to Customer Management System");
            Console.WriteLine("\n1.Add Customer");
            Console.WriteLine("\n2.Display Customer");
            Console.WriteLine("\n3.Search Customer");
            Console.WriteLine("\n4.Edit Customer");
            Console.WriteLine("\n5.Delete Customer");
            Console.WriteLine("\n6.Exit");
        }

        //Method to add new Customer
        static void AddCustomer()
        {
            try
            {
                //Create object of Entity class
                Customer obj = new Customer();
                
                //Store all product information
                Console.WriteLine("Enter Customer Id");
                obj.CustomerId = Console.ReadLine();
                Console.WriteLine("Enter Customer Name");
                obj.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                obj.Gender =Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Date of Birth");
                obj.DateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address");
                obj.Address = Console.ReadLine();
                
                //Create obj of Business Layer
                CustomerBL cbl = new CustomerBL();
                bool result = cbl.AddCustomer(obj);

                //Print Message if data added successfully
                if (result)
                {
                    Console.WriteLine("Customer Added Successfully");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Method to display Customer
        static void DisplayCustomer()
        {
            try
            {
                CustomerBL cbl = new CustomerBL();
                List<Customer> list = cbl.DisplayCustomer();
                foreach (Customer item in list)
                {
                    Console.WriteLine("CustomerID:{0} CustomerName:{1} Gender:{2} DateOfBirth:{3} Address:{4}",
                               item.CustomerId,item.CustomerName,item.Gender,item.DateOfBirth,item.Address);
                }
                Console.WriteLine();

            }
            catch (SystemException ex)
            {

                Console.WriteLine(ex.Message);            }
        }
        //Method to search Customer
        static void SearchCustomer()
        {
            try
            {
                Console.WriteLine("Enter Customer ID");
                string cid = Console.ReadLine();

                CustomerBL cbl = new CustomerBL();
                Customer c = cbl.SearchCustomer(cid);

                if (c != null)
                {
                    Console.WriteLine("CustomerID:{0} CustomerName:{1} Gender:{2} DateOfBirth:{3} Address:{4}",
                               c.CustomerId, c.CustomerName, c.Gender, c.DateOfBirth, c.Address);
                }
                else
                {
                    Console.WriteLine("No such Customer found.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Method to delete Customer
        static void DeleteCustomer()
        {
            try
            {
                Console.WriteLine("Enter Customer ID");
                string cid = Console.ReadLine();
                CustomerBL cbl = new CustomerBL();
                bool result = cbl.DeleteCustomer(cid);
                if (result)
                {
                    Console.WriteLine("Customer Deleted.\n");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Method to update Customer
        static void UpdateCustomer()
        {
            try
            {
                //Create object of Entity class
                Customer obj = new Customer();

                //Store all product information
                Console.WriteLine("Enter Customer Id");
                obj.CustomerId = Console.ReadLine();
                Console.WriteLine("Enter Customer Name");
                obj.CustomerName = Console.ReadLine();
                Console.WriteLine("Enter Gender");
                obj.Gender = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Date of Birth");
                obj.DateOfBirth = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Address");
                obj.Address = Console.ReadLine();

                //Create obj of Business Layer
                CustomerBL cbl = new CustomerBL();
                bool result = cbl.UpdateCustomer(obj);

                //Print Message if data added successfully
                if (result)
                {
                    Console.WriteLine("Customer Updated Successfully");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
