using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Entities;
using Exceptions;

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
                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            DisplayProducts();
                            break;
                        case 3:
                            Search();
                            break;
                        case 4:
                            UpdateProduct();
                            break;
                        case 5:
                            DeleteProduct();
                            break;
                        case 6:
                            break;
                        default:
                            Console.WriteLine("Invalid choice.Please try again");
                            break;
                    }
                }

                while (choice != 6);
            }
            catch (ProductException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("Welcome to Product Management System");
            Console.WriteLine("\n1.Add Product");
            Console.WriteLine("\n2.Display Product");
            Console.WriteLine("\n3.Search Product");
            Console.WriteLine("\n4.Edit Product");
            Console.WriteLine("\n5.Delete Product");
            Console.WriteLine("\n6.Exit");
        }

        //Method to add new product
        static void AddProduct()
        {
            try
            {
                //Create object of Entity class
                Product obj = new Product();

                //Store all product information
                Console.WriteLine("Enter product Id");
                obj.ProductID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                obj.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Unit Price");
                obj.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Quantity");
                obj.Quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Category-Mobile or Laptop");
                obj.Category = Console.ReadLine();
                Console.WriteLine("Enter Manufacture Date");
                obj.ManufactureDate = DateTime.Parse(Console.ReadLine());

                //Create obj of Business Layer
                ProductBL pbl = new ProductBL();
                bool result = pbl.AddProduct(obj);

                //Print Message if data added successfully
                if (result)
                {
                    Console.WriteLine("Product Added Successfully");
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

        //Method to display all the products
        static void DisplayProducts()
        {
            try
            {
                ProductBL pbl = new ProductBL();
                List<Product> list = pbl.DisplayProducts();
                foreach (Product item in list)
                {
                    Console.WriteLine("ProductId:{0}\n\nProductname:{1}\n\nUnitPrice:{2}\n\nStock:{3}\n\nCategory:{4}\n\nDate:{5}"
                        , item.ProductID, item.ProductName, item.Price, item.Quantity, item.Category, item.ManufactureDate);
                }
                Console.WriteLine();
            }
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Method to search a product
        static void Search()
        {
            try
            {
                Console.WriteLine("Enter Product ID");
                int pid = Convert.ToInt32(Console.ReadLine());

                ProductBL pbl = new ProductBL();
                Product p = pbl.Search(pid);

                if (p != null)
                {
                    Console.WriteLine("ProductId:{0}\n\nProductname:{1}\n\nUnitPrice:{2}\n\nStock:{3}\n\nCategory:{4}\n\nDate:{5}"
                        , p.ProductID, p.ProductName, p.Price, p.Quantity, p.Category, p.ManufactureDate);
                }
                else
                {
                    Console.WriteLine("No Product found.");
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


        //Method to delete a product
        static void DeleteProduct()
        {
            try
            {
                Console.WriteLine("Enter ProductID");
                int pid = Convert.ToInt32(Console.ReadLine());
                ProductBL pbl = new ProductBL();
                bool result = pbl.DeleteProduct(pid);
                if (result)
                {
                    Console.WriteLine("Product Deleted.\n");
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

        //Method to update a product
        static void UpdateProduct()
        {
            try
            {
                //Create object of Entity class
                Product obj = new Product();

                //Store all product information
                Console.WriteLine("Enter product Id");
                obj.ProductID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                obj.ProductName = Console.ReadLine();
                Console.WriteLine("Enter Unit Price");
                obj.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Quantity");
                obj.Quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Category-Mobile or Laptop");
                obj.Category = Console.ReadLine();
                Console.WriteLine("Enter Manufacture Date");
                obj.ManufactureDate = DateTime.Parse(Console.ReadLine());

                //Create obj of Business Layer
                ProductBL pbl = new ProductBL();
                bool result = pbl.UpdateProduct(obj);

                //Print Message if data added successfully
                if (result)
                {
                    Console.WriteLine("Product Updated Successfully");
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


