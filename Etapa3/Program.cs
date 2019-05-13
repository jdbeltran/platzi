using System;
using CoreEscuela.Entidades;
using Etapa2.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar,
                                          ciudad: "Bogota");

            escuela.Curso = new Curso[]{
            new Curso(){  Nombre = "101"},
            new Curso(){  Nombre = "102"},
            new Curso{ Nombre = "103"} };


            //Console.WriteLine(escuela);            
            //Console.WriteLine(arrCursos[0].Nombre);
            //Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            //ImprimirCursosWhile(arrCursos);
            //ImprimirCursosDoWhile(arrCursos);
            //ImprimirCursosFor(arrCursos);

            //escuela = null;
            ImprimirCursoEscuela(escuela);
        }

        private static void ImprimirCursoEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");

            if (escuela?.Curso != null)
            {
                foreach (var curso in escuela.Curso)
                {
                    WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
        }

        private static void ImprimirCursosFor(Curso[] arrCursos)
        {
            for (int i = 0; i < arrCursos.Length; i++)
            {
                WriteLine($"Nombre {arrCursos[i].Nombre}, Id {arrCursos[i].UniqueId}");
            }
        }

        private static void ImprimirCursosWhile(Curso[] arrCursos)
        {
            int contador = 0;
            while (contador < arrCursos.Length)
            {
                WriteLine($"Nombre {arrCursos[contador].Nombre}, Id {arrCursos[contador].UniqueId}");
                contador++;
            }
        }




        private static void ImprimirCursosDoWhile(Curso[] arrCursos)
        {
            int contador = 0;
            do
            {
                WriteLine($"Nombre {arrCursos[contador].Nombre}, Id {arrCursos[contador].UniqueId}");
            } while (++contador < arrCursos.Length);
        }
    }
}
