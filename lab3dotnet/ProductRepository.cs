using System.Collections.Generic;
using EnsureThat;

namespace lab3dotnet
{
    public class ProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            Products = new List<Product>
            {
                new Product("nume1", "descriere1", 100),
                new Product("nume2", "descriere2", 200),
                new Product("nume3", "descriere3", 300)
            };
        }

        public List<Product> Products { get => products;
            set => products = value;
        }
        public Product GetProductByName(string productName)
        {
            return Products.Find(x => x.ProductName.Equals(productName));
        }

        public List<Product> FindAllProducts() => products;

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public Product GetProductByPosition(int position)
        {
            Ensure.That(position).IsInRange(0,Products.Count-1);
            return Products[position];
        }

        public void RemoveProductByName(string productName)
        {
            Products.Remove(Products.Find(x => x.ProductName.Equals(productName)));
        }

        public List<Product> GetProductsWithPriceGreaterThen(double limit)
        {
            List<Product> products = new List<Product>();
            foreach (var product in Products)
            {
               if(product.ProductPrice>limit)
                    products.Add(product);
            }
            return products;
        }
    }
}
