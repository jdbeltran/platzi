using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace c1.Models
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var escuela = new Escuela();
            escuela.AñoDeCreación = 2019;
            escuela.UniqueId = System.Guid.NewGuid().ToString();
            escuela.Nombre = "Platzi Academy";
            escuela.Ciudad = "Bogota";
            escuela.Pais = "Colombia";
            escuela.Dirección = "Av. Siempre Viva";
            escuela.TipoEscuela = TiposEscuela.Secundaria;

            modelBuilder.Entity<Escuela>().HasData(escuela);



            var lstAsignatura = new List<Asignatura>(){
                new Asignatura {Nombre =  "Matematica",
                                UniqueId = Guid.NewGuid().ToString()},
                new Asignatura {Nombre =  "Educación Fisica",
                                UniqueId = Guid.NewGuid().ToString()},
                new Asignatura {Nombre =  "Castellano",
                                UniqueId = Guid.NewGuid().ToString()},
                new Asignatura {Nombre =  "Programación",
                                UniqueId = Guid.NewGuid().ToString()}
                                };
                                
            modelBuilder.Entity<Asignatura>().HasData(lstAsignatura.ToArray());
            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnosAlAzar().ToArray());

        }

         private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { 
                                   Nombre = $"{n1} {n2} {a1}" ,
                                   UniqueId = Guid.NewGuid().ToString()
                                   };

            return listaAlumnos.OrderBy((al) => al.UniqueId).ToList();
        }

    }
}