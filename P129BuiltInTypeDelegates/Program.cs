using System;
using System.Collections.Generic;

namespace P129BuiltInTypeDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func Delegate
            //Return Typi Void-den Ferqli Olan Ve
            //Maksimum 16-a Qeder Parametr Qebul Eden Methodlara Qarsiliq Gelir
            //Func<int, string> func = new Func<int, string>(Test);
            //func += Test1;
            //func -= Test;
            //func += delegate (int num) 
            //{
            //    return num.ToString();
            //};
            //func.Invoke(45);

            //Func<int, double, byte, string, char, bool> func1 =
            //    new Func<int, double, byte, string, char, bool>(Test);

            //Func<int> func2 = new Func<int>(Test);
            #endregion

            #region Action
            //Return Typi Void Olan Ve
            //Maksimum 0-dan  16-a Qeder Parametr Qebul Eden Methodlara Qarsiliq Gelir
            //Action action = new Action(()=>Console.WriteLine("Hello World"));
            //action.Invoke();
            //Action<int> action1 = new Action<int>(Test);
            //action1.Invoke(45);
            //Action<string, double> action2 = new Action<string, double>(Test);
            #endregion

            #region Predicate
            //Return Type Mutleq Bool Olmalidir ve
            //Bir Parameter Qebul Eden Methodlara Qarsiliq Gelir
            //Predicate<string> predicate = new Predicate<string>(Test);

            //int[] arr = { 5, 7 };
            //Sum(arr, IsEven);
            //Sum(arr, delegate (int a) 
            //{
            //    return a % 2 != 0;
            //});
            //Sum(arr, a => a % 2 != 9);
            List<string> names = new List<string>();
            names.Add("Hamid");
            names.Add("Test");
            names.Add("Hello");
            names.Add("P129");
            names.Add("Hamid");
            names.Add("Hamid");
            names.Add("Hamid");
            Console.WriteLine(names.Exists(n => n == "Hamid"));
            foreach (string item in names.FindAll(n=>n=="Hamid"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(names.Find(n=>n=="Test1"));

            #endregion
        }

        #region Predicate
        static int Sum(int[] arr, Predicate<int> predicate)
        {
            int result = 0;
            foreach (int item in arr)
            {
                if (predicate.Invoke(item))
                {
                    result += item;
                }
            }

            return result;
        }

        static bool IsEven(int item)
        {
            return item % 2 == 0;
        }

        static bool Test(string str)
        {
            return true;
        }
        #endregion

        #region Action
        //static void Test()
        //{
        //    Console.WriteLine("Hello World");
        //}

        //static void Test(int a)
        //{
        //    Console.WriteLine($"{a} Hello World");
        //}

        //static void Test(string a, double b)
        //{
        //    Console.WriteLine($"{a} Hello World");
        //}
        #endregion

        #region Func Delegate
        //static int Test()
        //{
        //    return 5;
        //}
        //static bool Test(int a, double b, byte c, string str, char letter)
        //{
        //    return true;
        //}

        //static string Test(int a)
        //{
        //    return "";
        //}

        //static string Test1(int a)
        //{
        //    return "";
        //}
        #endregion
    }
}
