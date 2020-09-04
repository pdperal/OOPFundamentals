using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repository
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted size set of siunflower";
                product.CurrentPrice = 15.96M;
            }
            Console.WriteLine(product.ToString());

            return product;           
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if(product.IsNew)
                    {
                        // call an insert stored procedure
                    }
                    else
                    {
                        // call an update sotred procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
    }
}
