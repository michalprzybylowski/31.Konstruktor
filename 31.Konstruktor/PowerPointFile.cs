using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Konstruktor
{
    internal class PowerPointFile : File // dziedziczenie
    {

        public void Present()
        {
            Console.WriteLine($"{FileName} presenting..");
        }
    }
}
