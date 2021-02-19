using System;

namespace System_Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object: Seller
            Seller s1 = new Seller();
            s1.Name = "Juan";
            s1.Age = 20;

            Seller s2 = new Seller();
            s2.Name = "Lucia";
            s2.Age = 25;

            Seller s3 = new Seller();
            s3.Name = "Pablo";
            s3.Age = 17;

            //Object: Product
            Product p1 = new Product();
            p1.Code = 1;
            p1.Name = "Carrot";
            p1.Price = 2000f;

            Product p2 = new Product();
            p2.Code = 2;
            p2.Name = "Banana";
            p2.Price = 1000f;

            Product p3 = new Product();
            p3.Code = 3;
            p3.Name = "Apple";
            p3.Price = 2000f;

            //Object: Sale
            Sales sa1 = new Sales();
            sa1.Seller = s1;
            sa1.Product = p3;
            sa1.Comments = 1;

            Sales sa2 = new Sales();
            sa2.Seller = s2;
            sa2.Product = p2;
            sa2.Comments = 0;

            Sales sa3 = new Sales();
            sa3.Seller = s3;
            sa3.Product = p1;
            sa3.Comments = 0;


            //Calculate sales total amount
            float sum;

            sum = (sa1.Product.Price + sa2.Product.Price + sa3.Product.Price);
            System.Console.WriteLine("The total amount of sales is: " +sum);



        }
    }
}
