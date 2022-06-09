using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {

            int num1, num2, limite, i, auxiliar;
            Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
            limite = int.Parse(Console.ReadLine());
            num1 = 0;
            num2 = 1;
            for (i = 0; i < limite; i++)
            {
                auxiliar = num1;
                num1 = num2;
                num2 = auxiliar + num1;
                Console.WriteLine(num1);
            }
            Console.ReadKey();
        }
    }
}