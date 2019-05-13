using System;
using CoreEscuela.App;
using CoreEscuela.Entidades; 
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();

            ImprimirCursoEscuela(engine.Escuela);
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
