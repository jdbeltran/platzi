using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy",2012,TiposEscuela.PreEscolar,
                                      ciudad: "Bogota"); 
            escuela.TiposEscuela = TiposEscuela.Primaria;

            Console.WriteLine(escuela);
            //Console.WriteLine("Hello World!");
        }
    }
}
