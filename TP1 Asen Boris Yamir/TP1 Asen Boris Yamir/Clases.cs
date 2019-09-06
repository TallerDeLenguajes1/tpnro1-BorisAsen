using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Asen_Boris_Yamir
{
    class Persona
    {
        int Id;
        string Nombre;
        string Apellido;

        public int id
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public string nombre
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return Apellido;
            }

            set
            {
                Apellido = value;
            }
        }
    }

    class Alumno : Persona
    {
        Materia Curso;

        public Materia curso
        {
            get
            {
                return Curso;
            }

            set
            {
                Curso = value;
            }
        }

        public override string ToString()
        {
            return id + " - " + apellido + " " + nombre + " ( " + Curso + " )";
        }

        public string ConcatenarDatos()
        {
            return id + ";" + apellido + ";" + nombre;
        }
    }

    class Personal : Persona
    {
        public override string ToString()
        {
            return apellido + "," + nombre;
        }
    }

    class Institucion
    {
        List<Alumno> Alumnos;
        List<Personal> Empleados;
    }

    class Materia
    {
        string Tema;
        Personal Profesor;

        public override string ToString()
        {
            return Tema;
        }

        public string tema
        {
            get
            {
                return Tema;
            }

            set
            {
                Tema = value;
            }
        }

        public Personal profesor
        {
            get
            {
                return Profesor;
            }

            set
            {
                Profesor = value;
            }
        }
    }
}
