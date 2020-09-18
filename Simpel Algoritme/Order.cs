using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_Algoritme
{
    class Order
    {
        //properties
        public List<Product> products { get; private set; }

        //constructors
        public Order()
        {
            products = new List<Product>();
        }
        //methods
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public double GiveMaximumPrice()
        {
            double maxprice = 0;

            foreach (Product product in products)
            {
                if (product.price > maxprice)
                {
                    maxprice = product.price;
                }
            }

            return maxprice;
        }

        public double GiveAveragePrice()
        {
            double total = 0;

            foreach (Product product in products)
            {
                total += product.price;
            }

            return total / products.Count();
        }

        public List<Product> GetAllProducts(double minPrice)
        {
            List<Product> allProducts = new List<Product>();

            foreach (Product product in products)
            {
                if (product.price >= minPrice)
                {
                    allProducts.Add(product);
                }
            }

            return allProducts;
        }

        public List<Product> SortProductsByPrice()
        {
            List<Product> productsSorted = new List<Product>();
            /*foreach (Product item in products)
            {
                Product maxPriceProduct = null;
                double price = int.MaxValue;

                foreach (Product product in products)
                {
                    if (product.price < price && !productsSorted.Contains(product))
                    {
                        price = product.price;
                        maxPriceProduct = product;
                    }
                }

                productsSorted.Add(maxPriceProduct);
            }*/

            for (int i = 0; i < products.Count(); i++)
            {
                Product maxPriceProduct = null;
                double price = int.MaxValue;

                foreach (Product product in products)
                {
                    if (product.price < price && !productsSorted.Contains(product))
                    {
                        price = product.price;
                        maxPriceProduct = product;
                    }
                }

                productsSorted.Add(maxPriceProduct);
            }

            return productsSorted;
        }
    }
}
