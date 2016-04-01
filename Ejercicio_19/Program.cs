using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ejercicio_19.Boligrafos;

namespace Ejercicio_19
{

    /*   
    19.  Crear la clase Bolígrafo. 
 
    Generar sólo los métodos getters para ambos atributos.  
    En el Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue) 
    y una cantidad inicial de tinta de 100 (cantidad máxima para 
    todos los bolígrafos) y otro de tinta roja (ConsoleColor.Red) y 
    50 de tinta. Utilizar todos los métodos en el Main.  
 
    Nota: Crear el constructor que crea conveniente. La clase 
    Boligrafo y el Program deben estar en namespaces distintos.
    */

    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 19";

            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red, 50);

            if (boligrafo1.Pintar(100))
            {
                Console.ForegroundColor = boligrafo1.GetColor();
                Console.WriteLine("Pintando... ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
                Console.WriteLine("No hay tinta suficiente");
            if (boligrafo2.Pintar(75))
            {
                Console.ForegroundColor = boligrafo2.GetColor();
                Console.WriteLine("Pintando... ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
                Console.WriteLine("No hay tinta suficiente");
            boligrafo2.Recargar();
            if (boligrafo2.Pintar(75))
            {
                Console.ForegroundColor = boligrafo2.GetColor();
                Console.WriteLine("Pintando... ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Estado del boligrafo 1: Tinta => {0}, Color => {1}.", boligrafo1.GetTinta(), boligrafo1.GetColor());
            Console.WriteLine("Estado del boligrafo 2: Tinta => {0}, Color => {1}.", boligrafo2.GetTinta(), boligrafo2.GetColor());

            Console.ReadKey();
        }
    }
}
