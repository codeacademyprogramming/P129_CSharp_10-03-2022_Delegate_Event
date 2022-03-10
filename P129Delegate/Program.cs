using P129Delegate.Delegates;
using System;

namespace P129Delegate
{
    class Program
    {
        delegate void WriteDelegate<T>(T item);

        static void Main(string[] args)
        {
            //WriteDelegate<string> writeDelegate = new WriteDelegate<string>(WriteTextWithHello);
            //writeDelegate.Invoke("Hello P129");
            //writeDelegate += WriteTextWithP129;
            //writeDelegate.Invoke("Hello P129");
            //writeDelegate -= WriteTextWithHello;

            ////Anonym Method
            //writeDelegate +=  delegate (string str) 
            //{
            //    Console.WriteLine(str.ToUpper());
            //};

            //writeDelegate -= delegate (string str)
            //{
            //    Console.WriteLine(str.ToUpper());
            //};

            ////Lambda Expression Call Back Function, Arrow Function
            //writeDelegate += s => Console.WriteLine($"{s} Lambda Expression");
            //writeDelegate += item => 
            //{
            //    item = item.ToUpper();
            //    Console.WriteLine($"{item} Lambda Expression");
            //};

            //writeDelegate -= item => Console.WriteLine($"{item} Lambda Expression");
            //Lambda Expression Hec Bir Parametr Olmasa ()
            //writeDelegate += () => Console.WriteLine($"{item} Lambda Expression");
            //Lambda Expression Hec Birden Cox Parametr Olsa (item1,item2)
            //writeDelegate += (item, num) => Console.WriteLine($"{item} Lambda Expression");

            //writeDelegate("Hello P129");

            int[] arr = { 5, 7, 12, 11, 13, 21 };
            Console.WriteLine(Sum(arr, IsEven));
            Console.WriteLine(Sum(arr, IsOdd));
            Console.WriteLine(Sum(arr, IsDevideByFive));
            Console.WriteLine(Sum(arr, delegate (int num)
            {
                return num % 7 == 0;
            }));
            Console.WriteLine(Sum(arr, s => s % 9 == 0));
            Console.WriteLine(Sum(arr, s =>
            {
                return s % 3 == 0;
            }));

            //Write<string>("Hello", WriteTextWithHello);
            //Write<double>(1.25, WriteTextWithHello);

            //Write<string>("Hello", WriteTextWithP129);
            //Write<double>(1.25, WriteTextWithP129);
        }

        static void Write<T>(T str, WriteDelegate<T> writeDelegate)
        {
            writeDelegate(str);
        }


        static void WriteTextWithHello<T>(T item)
        {
            Console.WriteLine($"{item} Hello World");
        }

        static void WriteTextWithP129<T>(T item)
        {
            Console.WriteLine($"{item} P129");
        }

        static void WriteTextWithP1291<T>(T item, int a)
        {
            Console.WriteLine($"{item} P129");
        }

        static int Sum(int[] arr, CheckNum checkNum)
        {
            int result = 0;

            foreach (int item in arr)
            {
                if (checkNum(item))
                {
                    result += item;
                }
            }

            return result;
        }

        //static int SumEven(int[] arr)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (IsEven(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumOdd(int[] arr)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (item % 2 != 0)
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumDevideByFive(int[] arr)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (IsDevideByFive(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        static bool IsDevideByFive(int num)
        {
            return num % 5 == 0;
        }

        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
    }
}
