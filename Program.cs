using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios03
{
    class Program
    {
        static void Main(string[] args)
        { /* permite pedir el nombre y la edad al usuario y los imprime por pantalla*/
            Console.SetCursorPosition(20, 4); Console.Write("Cual es tu nombre: ");
            string name = Console.ReadLine();
            Console.SetCursorPosition(20, 6); Console.Write("Cual es tu edad: ");
            int years = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(20, 8); Console.WriteLine($"Te llamas {name} y tienes {years} años");
            Console.Read();
        }
    }
}

