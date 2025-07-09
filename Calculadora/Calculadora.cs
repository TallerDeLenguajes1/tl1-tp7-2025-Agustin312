namespace EspacioCalculadora // Definimos el namespace EspacioCalculadora para poder usarla en el Program.cs
{
    public class Calculadora
    {   // Defino la clase clase publica Calculadora  en donde pondremos sus campos, constructores y metodos pertenecientes a esa clase

        private double dato;  // campo/propiedad privado, al cual se le va a asignar el dato del calculo

        //es el getter del atributo dato, getDato
        public double Resultado   // al haber sido definido como privado dato, esto nos obliga a tener un campo publico en donde guardaremos el valor ingresado en dato con el set
        {
            get => dato;
        }

        // en otro caso hariamos esto:

        // public double dato { get; } y nos ahorrariamos todo lo de arriba :/


        //Constructor por defecto, Este siempre estara cuando creemos una clase pero no sera visible y sera usado cuando no tengamos un constructor
        // public Calculadora()
        // {
        //
        // }

        //Constructor sin parametros, este haria que en cada instancia de la Calculadora Iniciase con el valor 0
        // public Calculadora()
        // {
        //  
        //    dato = 0;
        //
        // }

        //Contructor por parametro
        public Calculadora(double valorInicial)
        {
            dato = valorInicial;
        }

        //----- METODOS DE LA CALCULADORA ------

        // notese que estos metodos y la forma en la que esta pensada la calculadora es la de acumular y/o guardar la operacion sobre el mismo valor
        public void Sumar(double termino) // Metodo que realiza la Suma
        {

            dato += termino;

        }
        public void Restar(double termino) // Metodo que realiza la Resta
        {

            dato -= termino;

        }
        public void Multiplicar(double termino) // Metodo que realiza la Multiplicacion
        {

            dato *= termino;

        }
        public void Dividir(double termino) // Metodo que realiza la Division
        {

            if (termino != 0) // control para evitar la division en 0
            {

                dato /= termino;

            }

        }
        public void Limpiar()  // Metodo que resetea la calculadora (en tucumano Pone el dato en 0 de nuevo )
        {

            dato = 0;

        }

    }
    
}