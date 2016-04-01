using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19.Boligrafos
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            if (this.tinta > 100)
                tinta = 100;
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
                Console.WriteLine("No hay tinta suficiente");
                return false;
            }
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine("Pintando... ");
            Console.ForegroundColor = ConsoleColor.White;
            this.tinta -= gasto;
            return true;
        }

        public void Recargar()
        {
            this.tinta = 100;
        }
    }
}
