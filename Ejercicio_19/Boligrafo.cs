using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19.Boligrafos
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        /// <summary>
        /// Crea un nuevo boligrafo.
        /// </summary>
        /// <param name="color">
        /// Define el color de tinta que tendra el boligrafo.
        /// </param>
        /// <param name="tinta">
        /// Define la cantidad de tinta que tendra el boligrafo.
        /// </param>
        public Boligrafo(ConsoleColor color, int tinta)
        {
            this._color = color;
            if (tinta > 100)
                tinta = 100;
            else if (tinta < 0)
                tinta = 0;
            this._tinta = tinta;
        }

        /// <summary>
        /// Retorna el color de tinta del boligrafo.
        /// </summary>
        public ConsoleColor GetColor()
        {
            return this._color;
        }

        /// <summary>
        /// Retorna la tinta disponible que tiene el boligrafo.
        /// </summary>
        public int GetTinta()
        {
            return this._tinta;
        }

        /// <summary>
        /// Pinta con el boligrafo solo si alcanza la tinta.
        /// </summary>
        /// <param name="gasto">
        /// Cantidad de tinta que se utilizara.
        /// </param>
        /// <returns>
        /// Retornara true si ha alcanzado la tinta.
        /// </returns>
        public bool Pintar(int gasto)
        {
            if (gasto > this.GetTinta())
                return false;
            this._tinta -= gasto;
            return true;
        }

        /// <summary>
        /// Recarga el boligrafo, estableciendo la tinta en 100.
        /// </summary>
        public void Recargar()
        {
            this._tinta = 100;
        }
    }
}
