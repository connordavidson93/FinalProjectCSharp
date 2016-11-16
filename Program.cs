using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyFunction();
            myInt = IntFunction(22);
            string myString = StringFunction(Console.ReadLine());
            Console.WriteLine(myString);
        }

        public static int myInt = 10;

        public static void MyFunction(){
        Console.WriteLine("Run Function");
        }

        public static int IntFunction(int _peram){
            return _peram + myInt;
        }

        public static string StringFunction(string _name){
            return "You did well, " + _name;
        }


    }
}
