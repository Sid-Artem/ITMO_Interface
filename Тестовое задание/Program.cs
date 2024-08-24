using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Achiper achiper = new Achiper();
            Console.WriteLine(achiper.Encoder("ABC123 XYZ"));
            Console.ReadKey();

        }
    }
}
