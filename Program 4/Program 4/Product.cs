//Program 4
//CIS-199-50
//Due 12/4/2023
//By: A1029
//This file creates a simple Product class capable of tracking the product supplier name, product name, product name, product type, product price, aisle number, and if it is in stock or not
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class Product
    {
        //creates each of the variables
        public string supplierName;
        public string productName;
        public int productID;
        public string productType;
        public double productPrice;
        public int aisleLocation;
        private bool inStock;

        //creates alternate variables to be used inside of the class
        public Product(string supplierName, string productName, int productID, string productType, double productPrice, int aisleLocation)
        {
            SupplierName = supplierName;
            ProductName = productName;
            ProductID = productID;
            ProductType = productType;
            ProductPrice = productPrice;
            Aisle = aisleLocation;
            inStock = false;
        }

        public string SupplierName { get; set; }
        public string ProductName { get; set; }

        //sets the minimum product id to 100000 and max to 999999. Defalt 0
        public int ProductID { get => productID; set => productID = (value >= 100000 && value <= 999999) ? value : 0; }

        public string ProductType { get; set; }

        //sets the minimum product price to greater then 0 and the defalut value to 0
        public double ProductPrice { get => productPrice; set => productPrice = (value >= 0) ? value : 0; }

        //sets the minimum aisle value to 1 and max to 20. Defalt is set to 0.
        public int Aisle { get => aisleLocation; set => aisleLocation = (value >= 1 && value <= 20) ? value : 0; }

        //sets the instock variable to true
        public void InStock()
        {
            inStock = true;
        }

        //sets the OutOfStock variable to false
        public void OutOfStock()
        {
            inStock = false;
        }

        //returns a bool value if the item is in stock or not
        public bool IsOutOfStock()
        {
            return !inStock;
        }

        //prints all variables as a string, overriding all other types
        public override string ToString()
        {
            return $"Supplier Name: {SupplierName}\nProduct Name: {ProductName}\nProduct ID: {ProductID}\nProduct Type: {ProductType}\nProduct Price: {ProductPrice:C}\nAisle: {Aisle}\nIn Stock: {(inStock ? "Yes" : "No")}";
        }

    }
}
