using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19.Boligrafo
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public int GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(int gasto)
        {
            if (gasto > this.GetTinta())
            {
                Console.Write("No hay tinta suficiente");
                return false;
            }
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine("Pintando... ");
            Console.ForegroundColor = ConsoleColor.Black;
            return true;
        }

        public void Recargar()
        {
            this.tinta += 100;
        }
    }
}
