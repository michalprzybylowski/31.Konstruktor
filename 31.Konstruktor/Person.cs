using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.Class_method
{
    internal class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateOfBirth;

        public Person(string firstName, string lastName) // pusty konstruktor(incjacja wartości danego oobiektu) jest tworzony domyślnie, można tworzyć przypisane by sprawdzic wartości w nim przypisane
        {
            FirstName = firstName;
            LastName = lastName;
        } 
        public void SetDateOfBirth(DateTime date) // można dzięki temu zmodyfikować dateOfBirth tylko dzięki tej metodzie
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of  birth");
            }
            else
            {
                dateOfBirth = date;
            }
        }
        public DateTime GetDateOfBirth() // => dateOfBirth (można tak to zapisać bez nawiasów klamrowych), trzeba to utworzyć, żeby mieć do tego dostęp poza klasą
        {
            return dateOfBirth;
        }
        public void SayHi() // gdybyśmy mieli dużo do wpisania danych typu person to możemy użyć funkcji jak poniżej, żeby każdego "przywitać"
        {
            Console.WriteLine($"Hi, I'm {this.FirstName}, {GetDateOfBirth()}"); // this.Zmienna to może być pomocne gdy mamy argument w metodzie tak samo nazwany jak pole w klasie
        }
    }
}
