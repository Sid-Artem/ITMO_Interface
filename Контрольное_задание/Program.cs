using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольное_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArifmeticProgresoion arifmeticProgresoion = new ArifmeticProgresoion();
            arifmeticProgresoion.setStart(100);
            arifmeticProgresoion.setStep(5);
            Console.WriteLine(arifmeticProgresoion.getNext());
            Console.WriteLine(arifmeticProgresoion.getNext());
            Console.WriteLine(arifmeticProgresoion.getNext());
            arifmeticProgresoion.reset();
            Console.WriteLine(arifmeticProgresoion.getNext());
            Console.WriteLine(arifmeticProgresoion.getNext());
            GeometricProgresoion geometricProgresoion = new GeometricProgresoion();
            geometricProgresoion.setStart(20);
            geometricProgresoion.setStep(3);
            Console.WriteLine(geometricProgresoion.getNext());
            Console.WriteLine(geometricProgresoion.getNext());
            Console.WriteLine(geometricProgresoion.getNext());
            arifmeticProgresoion.reset();
            Console.WriteLine(geometricProgresoion.getNext());
            Console.WriteLine(geometricProgresoion.getNext());
            Console.WriteLine(geometricProgresoion.getNext());
            Console.ReadKey();
        }
    }
}
