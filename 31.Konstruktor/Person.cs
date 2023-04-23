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

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("Invalid date of  birth");
                }
                else
                {
                    dateOfBirth = value;
                }
            }
        }

        private string contactNumber;

        public string ContactNumber
        {
            get {return contactNumber; }
            set 
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact Number");
                }
                else
                {
                    contactNumber = value;
                }
                
            }
    
        }

        // public string ContactNumber { get; set; } // jest to równoważne z tym co jest u góry, ale nie ma tutaj żadnej logiki związanej z ustawianiem wartości
        public static int Count = 0;
        public Person(string firstName, string lastName) // pusty konstruktor(incjacja wartości danego oobiektu) jest tworzony domyślnie, można tworzyć przypisane by sprawdzic wartości w nim przypisane
        {
            Console.WriteLine("Constructor1");
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }
        
        public Person(DateTime dateOfBirth, string firstName, string lastName) : this(firstName,lastName) // pusty konstruktor(incjacja wartości danego oobiektu) jest tworzony domyślnie, można tworzyć przypisane by sprawdzic wartości w nim przypisane
        {
            Console.WriteLine("Constructor2");
            SetDateOfBirth(dateOfBirth);
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
            Console.WriteLine($"Hi, I'm {this.FirstName}, {this.LastName},"); // this.Zmienna to może być pomocne gdy mamy argument w metodzie tak samo nazwany jak pole w klasie
        }
    }
}
