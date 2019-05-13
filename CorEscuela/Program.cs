using System;

namespace CorEscuela
{
    class Escuela
    {
        public string nombre;
        public string direccion;
        public int añofundacion;
        public string ceo;

        public void Timbrar()
        {
            //Todo
            Console.Beep(1000,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi Academy";
            miEscuela.direccion = "Cr 9 calle 72";
            miEscuela.añofundacion = 2012;
            Console.WriteLine("Timbre");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
