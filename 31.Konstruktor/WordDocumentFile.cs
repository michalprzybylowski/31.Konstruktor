using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Konstruktor
{
    internal class WordDocumentFile : File // dziedziczenie
    {
        public override void Compres()
        {
            Console.WriteLine($"Compressing WordFile..");
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printing..");
        }
    }
}
