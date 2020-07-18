using alfonso.controller;
using System;

namespace alfonso
{
    class Program
    {
        static void Main(string[] args)
        {

            /* VISTA */

            Console.WriteLine("Introduzca el numero de Filas :");
            int fila = Convert.ToInt16(Console.ReadLine()); // asignamos el numero de filas que contiene la matriz



            Console.WriteLine("Introduzca el numero de Columnas :");
            int col = Convert.ToInt16(Console.ReadLine());// asignamos el numero de columnas que contiene la matriz


            TraspuestaControlloer c = new TraspuestaControlloer(fila, col); // inicializamos TrapuestaController y le pasamos por parametros la fila y la columna
            c.llenarMatriz();
        }
    }
}
