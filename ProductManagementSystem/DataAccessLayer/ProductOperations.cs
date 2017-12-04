using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using Entities;

namespace DataAccessLayer
{
    //Data Access Layer Class
    public class ProductOperations
    {
        //A generic list to store all the products
        static List<Product> productList = new List<Product>();

        //Method to add new product
        //Returns true if success False if product is not added
        public bool AddProduct(Product pobj)
        {
            bool result = false;
            try
            {
                productList.Add(pobj);
                result = true;
            }
            catch (ProductException)
            {
                throw;
            }

            return result;
        }

        //Method to display all the products
        public List<Product> DisplayProducts()
        {
            return productList;
        }

        //Method to search a product
        public Product Search(int productID)
        {
            Product pobj = null;
            foreach (Product item in productList)
            {
                if (item.ProductID == productID)
                {
                    pobj = item;
                    break;
                }

            }
            return pobj;
        }

        //Method to delete a product
        public bool DeleteProduct(int productID)
        {
            bool result = false;
            Product pobj = null;
            foreach(Product item in productList)
            {
                if(item.ProductID==productID)
                {
                    pobj = item;
                    break;
                }
            }
            if(pobj!=null)
            {
                productList.Remove(pobj);
                result = true;
            }
            return result;
        }

        //Method to update a  product
        public bool UpdateProduct(Product pobj)
        {
            bool result = false;
            Product p = null;
            foreach (Product item in productList)
            {
                if (item.ProductID == pobj.ProductID)
                {
                    p = item;
                    break;
                }
            }
            if(p!=null)
            {
                p.ProductID = pobj.ProductID;
                p.ProductName = pobj.ProductName;
                p.Price = pobj.Price;
                p.Quantity = pobj.Quantity;
                p.Category = pobj.Category;
                p.ManufactureDate = pobj.ManufactureDate;
                result = true;

            }
                return result;
        }
    }
}
