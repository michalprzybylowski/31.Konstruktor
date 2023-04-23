using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Konstruktor
{
    internal class PowerPointFile : File // dziedziczenie
    {
        public override void Compres()
        {
            Console.WriteLine($"Compressing PowerPoint file..");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting..");
        }
    }
}
