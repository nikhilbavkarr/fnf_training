using System;

namespace sampleConApp
{
    internal class sampleConApp
    {
        static void display(){
            Console.WriteLine("hello world!");
        Console.WriteLine("nikhil");
        Console.WriteLine("location : belgaum");
        }

        static void InputExample(){
            Console.WriteLine("Enter ur name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter ur phone");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter ur age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("The Name is {0} with contactno {1} and aged {2}",name,phone,age);

            Console.WriteLine("Mr. {0}'s age will be  {2} after 15 years",name,phone,age + 15);



        }
    static void Main()
    {
        //display();
        InputExample();
    }
    }
}