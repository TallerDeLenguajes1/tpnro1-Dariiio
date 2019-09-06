using System;
using System.Collections.Generic;
using System.IO;
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

        private string Nombre;

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string value)
        {
            Nombre = value;
        }

        private string Apellido;

        public string GetApellido()
        {
            return Apellido;
        }

        public void SetApellido(string value)
        {
            Apellido = value;
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
        public void InicializarId(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return Nombre + " " + Apellido + " " + curso.ToString() + " " + Id;
        }
    }

    class Alumno : Persona
    {
        public Alumno() { }
        public Alumno(string nombre, string apellido, Curso curso, int id) : base(nombre, apellido, curso, id)
        {
        }
    }

    public class HelperArchivo
    {
        private const string PathVoley = @"C:\Users\Dario\Desktop\Voley.csv";
        private const string PathFutbol = @"C:\Users\Dario\Desktop\Futbol.csv";
        private const string PathAtletismo = @"C:\Users\Dario\Desktop\Atletismo.csv";

        public static void GuardarArchivo()
        {
            using (StreamWriter sw = File.AppendText(PathVoley))
            {
                sw.WriteLine("as");
                sw.Close();
            }

        }
    }

}
