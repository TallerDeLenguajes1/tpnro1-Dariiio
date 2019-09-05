using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public enum Curso
    {
        Voley = 0,
        Futbol = 1,
        Atletismo = 2
    }
    class Persona
    {
        public Persona() { }
        public Persona(string nombre, string apellido, Curso curso, int id)
        {
            SetNombre(nombre ?? throw new ArgumentNullException(nameof(nombre)));
            SetApellido(apellido ?? throw new ArgumentNullException(nameof(apellido)));
            SetCurso(curso);
            Id = id;
        }

        private string nombre;

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string value)
        {
            nombre = value;
        }

        private string apellido;

        public string GetApellido()
        {
            return apellido;
        }

        public void SetApellido(string value)
        {
            apellido = value;
        }

        private Curso curso;

        public Curso GetCurso()
        {
            return curso;
        }

        public void SetCurso(Curso value)
        {
            curso = value;
        }

        private int Id { get; set; }
    }

    class Alumno : Persona
    {
        public Alumno() { }
        public Alumno(string nombre, string apellido, Curso curso, int id) : base(nombre, apellido, curso, id)
        {
        }
    }
}
