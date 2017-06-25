using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <Summary>
        /// Retrieve one Product
        /// </Summary>

        public Product Retrieve(int productId)
        {
            //Create an instance of the product class
            //Pass in the requested Id
            Product product = new Product(productId);

            //Code that retrieves the defined product

            //Temporary hard coded values to return 
            //a populated product.
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
