using alfonso.model;
using System;

namespace alfonso.controller
{
    public class TraspuestaControlloer
    {

        private TraspuestaModel c;  // Esta variable contiene el valor de cuantas filas y columna va a tener la matriz
        private int[,] matrizInicial;  // Esta variable va conteber los valores de la matriz original
        private int[,] matrizTraspuesta; // Esta variable va conteber los valores de la matriz traspuesta

        public TraspuestaControlloer(int fila, int columna)
        {
            c = new TraspuestaModel(fila, columna); // se inicializa y se le pasa por parametro  el numero de filas y columnas, que viene de la vista
        }


        public void llenarMatriz ()
        {
            this.matrizInicial = new int[c.Fila, c.Columna]; // se inicializa la matriz, indicandole cual va hacer su dimension


            for(int fila = 0; fila< c.Fila; fila++)
            {
                for(int columna = 0; columna < c.Columna; columna++)
                {
                    // se llena la matriz con los datos
                    Console.WriteLine("Datos para la fila y columna en la posicion"+ "["+fila+"]" + "[" + columna + "]");
                    this.matrizInicial[fila, columna] = Convert.ToInt16(Console.ReadLine());
                }
            }

            borrarConsole();
            MostrarMatrizInicial(); // con esta funcion mostramos los elementos que contiene la matrizInicial
            llenarMatrizTraspuesta(); //con esta funcion llenamos la matrizTraspuesta
            MostrarMatrizTraspuesta(); //Muestra los elementos que contiene la matrizTradpuesta
        }

        private void MostrarMatrizInicial()
        {
            Console.WriteLine("Matriz Original");
            for (int fila = 0; fila < c.Fila; fila++)
            {
                for (int columna = 0; columna < c.Columna; columna++)
                {
                    Console.Write(" "+this.matrizInicial[fila, columna]);//mostrar elemento
                }
                Console.WriteLine();//salto de linea
            }
        }

        private void llenarMatrizTraspuesta()
        {
            matrizTraspuesta = new int[c.Columna, c.Fila];// inicializamos a matrizTraspuesta indicandole que su fila va a ser la columna que indicamos anteriormente y que su columna va a ser fila que indicamos anteriormente
            for (int fila = 0; fila < c.Fila; fila++)
            {
                for (int col = 0; col < c.Columna; col++)
                {
                    //llenamos la matrizTraspuesta indicandole que sus filas van a ser las columnas de la matrizOriginal
                    // y que sus columnas van a ser las filas de la matrizOriginal
                    matrizTraspuesta[col,fila] = matrizInicial[fila, col];
                }
            }
        }

        private void MostrarMatrizTraspuesta()
        {
            Console.WriteLine("Matriz Traspuesta");
            for (int fila = 0; fila < c.Columna; fila++)
            {
                for (int columna = 0; columna < c.Fila; columna++)
                {
                    Console.Write(" " + this.matrizTraspuesta[fila, columna]);//mostrar elemento
                }
                Console.WriteLine();//salto de linea
            }
        }


        private void borrarConsole() 
        {
            Console.Clear();
        }

    }
}
