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
    public class ProductBL
    {
        //Check the product entity has correct values
        public bool Validate(Product pobj)
        {
            bool isValid = true;
            StringBuilder sb = new StringBuilder();
            //Regex expId = new Regex(@"\d{6}$");
            //Regex expName = new Regex(@"[A-Za-z\S]{3,}");
            if(pobj.ProductID<=0 )
            {
                sb.Append("Product Id cannot be negative");
                isValid = false;
            }
            if (!Regex.IsMatch(pobj.ProductID.ToString(), "\\d{6}"))
            {
                sb.Append("ProductID must be exactly 6 digits");
                isValid = false;
            }

            if(pobj.ProductName==string.Empty)
            {
                sb.Append("ProductName cant be empty.");
                isValid = false;
            }
            if(!Regex.IsMatch(pobj.ProductName,@"[A-Za-z\S]{3}"))
            {
                sb.Append("ProductName must be letters or should be 3 or more characters");
                isValid = false;
            }
            if(pobj.Price<50)
            {
                sb.Append("Unit Price should be 50 or more");
                isValid = false;

            }
            if(pobj.Quantity<0)
            {
                sb.Append("Quantity should be 0 or more");
                isValid = false;
            }
            if(pobj.ManufactureDate.ToShortDateString() !=DateTime.Now.ToShortDateString())
            {
                sb.Append("Manufacture Date should be the current Date");
                isValid = false;
            }
            if(pobj.Category.ToLower()!="mobile" && pobj.Category.ToLower()!="laptop")
            {
                sb.Append("Category can be either Mobile or Laptop");
                isValid = false;
            }

            if(isValid==false)
            {
                throw new ProductException(sb.ToString());
            }
            return isValid;

        }


        //Method to add new product
        public bool AddProduct(Product pobj)
        {
            bool result = false;
            //checking if the product object is valid
            if (Validate(pobj))
            {
                //Creating DAL class object
                ProductOperations po = new ProductOperations();


                //Invoking its AddProduct method
                return po.AddProduct(pobj);
            }
            return result;
        }

        //Method to dislpay product
        public List<Product> DisplayProducts()
        {
            ProductOperations po = new ProductOperations();
            return po.DisplayProducts();
        }

        public Product Search(int productID)
        {
            ProductOperations po = new ProductOperations();
            return po.Search(productID);
        }

        public bool DeleteProduct(int productID)
        {
            ProductOperations po = new ProductOperations();
            return po.DeleteProduct(productID);
        }

        public bool UpdateProduct(Product pobj)
        {
            bool result = false;
            if (Validate(pobj))
            {
                ProductOperations po = new ProductOperations();
                result = po.UpdateProduct(pobj);
            }
            return result;
        }
    }
}
