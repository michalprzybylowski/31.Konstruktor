using _30.Class_method;
using System;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            Person bill = new Person("Bill","Wick"); // konstruktor
            /*
            bill.SetDateOfBirth(new DateTime(1990, 1, 1,));

            Console.WriteLine($"{bill.FirstName} {bill.GetDateOfBirth()}");
            */
            bill.SayHi(); // wywolania funkcji SayHi
            bill.DateOfBirth = new DateTime(1990, 1, 1);
            bill.ContactNumber = "999888777"; // jest to inne podejscie bill.SetDateOfBirth
            Console.WriteLine($" {bill.ContactNumber}, {bill.DateOfBirth}");

            

            Person john = new Person(new DateTime(1987, 1, 2), "Billy", "Wicky");
            Console.WriteLine($"Number of object of type Person: {Person.Count}");
        }
    }
}