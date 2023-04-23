using _30.Class_method;
using System;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            Person bill = new Person("Johny","Wick"); // konstruktor

            bill.SetDateOfBirth(new DateTime(1990, 1, 1));

            Console.WriteLine($"{bill.FirstName} {bill.GetDateOfBirth()}");

            bill.SayHi(); // wywolania funkcji SayHi

            Person john = new Person(new DateTime(1987, 1, 2), "Billy", "Wicky");
        }
    }
}