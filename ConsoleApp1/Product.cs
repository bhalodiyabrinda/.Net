using System;

namespace ConsoleApp1
{
    internal class Product
    {
         int productId;
         string productName;
         int mrp;
         string makeBy;
         int stock;
         int discPar;
         int discountedPrice;

        public Product()
        {
            DiscPar = 10;
        }

        public Product(int productId, string productName, int mrp, string makeBy, int stock, int discPar)
        {
            ProductId = productId;
            ProductName = productName;
            MRP = mrp;
            MakeBy = makeBy;
            Stock = stock;
            DiscPar = discPar;
            CalculateDiscPrice();
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int MRP
        {
            get { return mrp; }
            set { mrp = value; }
        }

        public string MakeBy
        {
            get { return makeBy; }
            set { makeBy = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int DiscPar
        {
            get { return discPar; }
            set { discPar = value; }
        }

        public int DiscountedPrice
        {
            get { return discountedPrice; }
        }

        public void GetData()
        {
            Console.Write("Enter Product ID: ");
            ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            ProductName = Console.ReadLine();

            Console.Write("Enter Product MRP: ");
            MRP = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product MakeBy: ");
            MakeBy = Console.ReadLine();

            Console.Write("Enter Product Stock: ");
            Stock = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Discount Percentage: ");
            DiscPar = Convert.ToInt32(Console.ReadLine());

            CalculateDiscPrice();
        }

        public void CalculateDiscPrice()
        {
            discountedPrice = MRP - (MRP * DiscPar / 100);
        }

        public void Display()
        {
            Console.WriteLine("Product ID: {0}", ProductId);
            Console.WriteLine("Product Name: {0}", ProductName);
            Console.WriteLine("Product MRP: {0}", MRP);
            Console.WriteLine("Product MakeBy: {0}", MakeBy);
            Console.WriteLine("Product Stock: {0}", Stock);
            Console.WriteLine("Product Discount Percentage: {0}", DiscPar);
            Console.WriteLine("Product Discounted Price: {0}", DiscountedPrice);
        }
    }

    class ProductClassDemo
    {
        static void Main()
        {
            Product obj1 = new Product();
            obj1.GetData();
            obj1.Display();

            Product obj2 = new Product(120, "abc", 12, "def", 10, 10);
            obj2.Display();

            Product obj3 = new Product();
            obj3.ProductId = 1002;
            obj2.ProductName = "Fan";
            obj2.CalculateDiscPrice();
            obj2.Display();
        }
    }
}
