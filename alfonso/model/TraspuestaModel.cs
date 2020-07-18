

namespace alfonso.model
{
    public class TraspuestaModel
    {
        /* Propiedades */
        private int fila; 
        private int columna;

        //Constructor
        public TraspuestaModel (int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
        }

        //Metodos get y set de las propiedades
        public int Fila { get { return fila; } set { fila = value; } }
        public int Columna { get { return columna; } set { columna = value; } }
    }
}
