using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codigo2
{
    class Program
    {
        const double gravedad = 9.8;
        static void Main(string[] args)
        {
            double peso, masa;

            Console.WriteLine("Ingrese la masa: ");
            masa = double.Parse(Console.ReadLine());

            peso = masa * gravedad;


            Console.WriteLine("El Peso es de: " + peso + " Newton");

            Console.ReadKey();

        }
    }
}
