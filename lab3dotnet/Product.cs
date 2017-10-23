using System;

namespace lab3dotnet
{
    public class Product
    {
        public Product(string productName, string productDescription, double productPrice)
        {
            Id = Guid.NewGuid();
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
        }

        public Guid Id { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public double ProductPrice { get; set; }
    }
}
