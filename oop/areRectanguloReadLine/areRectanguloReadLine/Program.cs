//
// proyecto....: areaRectanguloReadLine
// fecha.......: 14-05-2016
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace areRectanguloReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseR;
            string altura;

            Console.Write("Ingresa la base: ");
            baseR = Console.ReadLine();
            Console.Write("Ingresa la altura: ");
            altura = Console.ReadLine();

            Console.WriteLine("Base: " + baseR);
            Console.WriteLine("Altura: " + altura);

            //foat area = baseR * altura;

            double area = Convert.ToDouble(baseR) * Convert.ToDouble(altura);

            Console.WriteLine("Área: " + area + " unidades cuadradas");

            Console.WriteLine("La raíz cuadrada de " + area + " es " + Math.Sqrt(area));

            int tope = 10;
            if (area > tope)
            {
                Console.WriteLine("Area es mayor que " + tope);
            }
            else
            {
                Console.WriteLine("Area no es mayor que " + tope);
            }

        }
    }
}
