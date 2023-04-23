using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.Konstruktor
{
    internal class ExcelFile : File // dziedziczenie
    {


        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report..");
        }
    }
}
