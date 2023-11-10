using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Excepciones
{
    class Operaciones
    {
        public static void Sumar(double a, double b)
        {
            double resultado = a + b;
            Console.WriteLine("La suma de {0} y {1} es: {2}", a, b, resultado);
        }

        public static void Restar(double a, double b)
        {
            double resultado = a - b;
            Console.WriteLine("La resta de {0} y {1} es: {2}", a, b, resultado);
        }

        public static void Multiplicar(double a, double b)
        {
            double resultado = a * b;
            Console.WriteLine("La multiplicacion de {0} y {1} es: {2}", a, b, resultado);
        }


        public static void Dividir(double a, double b)
        {
            double resultado = a / b;
            Console.WriteLine("La división de {0} entre {1} es: {2}", a, b, resultado);
        }
    }
}
