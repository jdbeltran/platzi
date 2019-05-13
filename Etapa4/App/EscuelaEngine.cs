using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar,
                                          ciudad: "Bogota");

            Escuela.Curso = new List<Curso>(){
            new Curso(){  Nombre = "101", Jornada = TiposJornada.Mañana },
            new Curso(){  Nombre = "201" , Jornada = TiposJornada.Mañana},
            new Curso{ Nombre = "301" , Jornada = TiposJornada.Mañana},
            new Curso{ Nombre = "401" , Jornada = TiposJornada.Tarde},
            new Curso{ Nombre = "501" , Jornada = TiposJornada.Tarde}
            };

        }
    }
}