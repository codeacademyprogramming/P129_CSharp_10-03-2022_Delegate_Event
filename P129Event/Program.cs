using System;
using P129Event.Models;

namespace P129Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Corek";
            product.Count = 50;

            //product.Sell(5);
            //product.Sell(5);
            //product.Sell(15);
            //product.Sell(7);
            //product.Sell(10);

            product.Notify += Test1;
            product.Notify += Test2;
            product.Notify += Test3;
            product.Notify -= Test2;

        }

        static void Test1()
        {

        }

        static void Test2()
        {

        }

        static void Test3()
        {

        }
    }
}
