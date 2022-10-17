using System;

namespace ConsoleAppDeepa
{
    class BaseCustomer
    {
        public string CustomerName { get; set; }
        public void Method1()
        {

            Console.WriteLine("BaseCustomer Method1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
