using System;

namespace HelloWorld
{
    class Program
    {
        //static void Greet(string name)
        //{
        //    Console.WriteLine("Hello " + name);
        //}
        static void Main(string[] args)
        {
            //string[] cars;
            ////char x = 'a';
            //cars = new string[]{ "hello","world","wow"};
            //Console.WriteLine(cars[1] + x);
            //Greet("huzefa");
            //Greet();

            Class1 obj1 = new Class1();
            Class1 obj2 = new Class1();

            obj1.name = "Huzefa";
            obj2.name = "Jamali";

            Console.WriteLine(obj2.name);
            Console.WriteLine(obj1.name);
            //string h = obj.getName();
            //Console.WriteLine(obj.getName());
            //Console.ReadLine();
        }
    }
}
