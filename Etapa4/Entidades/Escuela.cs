using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        string nombre;
        public string Nombre
        {
            get { return "Copia:"+nombre;}
            set{ nombre = value.ToUpper();}
        }

        public int AñoCreación { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
    
        public TiposEscuela  TiposEscuela { get; set; }
        
        public List<Curso> Curso { get; set; }

        //public Escuela(string nombre, int año) => (Nombre, AñoCreación) = (nombre,año);

        public Escuela(string nombre, int año) => (Nombre, AñoCreación) = (nombre,año);
        
        public Escuela(string nombre, int año,
                     TiposEscuela tipos,
                     string pais ="", string ciudad =""
        )
        {
            (Nombre,AñoCreación) = (nombre,año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TiposEscuela},{System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
    }
}