using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            double num2 = 4.5;
            double resultado;

            //Variable string
            string saludo = "Hola";
            string nombre= " Roberto";

            //Sumamos las dos variables
            //resultado = num1 + num2;

            //Sumando una variable y un dato puesto esplicitamente
            resultado = num1 + 22;
            //Console.WriteLine(resultado);

            //Sumando o cocatenando dos cadenas almacenadas en variables
            Console.WriteLine(saludo + nombre + " ¿Como estas? ");
            Console.ReadKey();
        }
    }
}
