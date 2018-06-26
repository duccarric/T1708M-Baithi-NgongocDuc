using System;
using System.Collections;

namespace BAITHICShap.Properties
{
    public class Product
    {
      
        private string _productID;
        private string _productName;
        private string _productPrice;

        public Product()
        {
        }

        public Product(string productId, string productName, string productPrice)
        {
            _productID = productId;
            _productName = productName;
            _productPrice = productPrice;
        }

        public string ProductId
        {
            get { return _productID; }
            set { _productID = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public string ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public void Add()
        {
            
        } 
        public void Display()
        {
            
        }
        public void Delete()
        {
            
        }
        
    }
}