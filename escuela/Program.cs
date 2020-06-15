using System;

namespace escuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;

        public string ceo;

        public void Timbrar()
        {
            // to do
            Console.Beep(2000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "DevF";
            miEscuela.direccion = "Una direccion random";
            miEscuela.añoFundacion = 2014;
            Console.WriteLine("Timbrando");
            miEscuela.Timbrar();
            Console.WriteLine("Hello World!");
        }
    }
}
