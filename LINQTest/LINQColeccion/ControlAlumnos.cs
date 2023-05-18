using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQColeccion
{
    internal class ControlAlumnos
    {

        List<Carrera> Carreras = new List<Carrera>();
        List<Alumno> Alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            Carreras.Add(new Carrera{IdCarrera = 1, Nombre = "Ingenieria de Software"});
            Carreras.Add(new Carrera {IdCarrera = 2, Nombre = "Redes y Servicios de Computo"});

            Alumnos.Add(new Alumno {IdAlumno = 1, Nombre = "Juan Perez Sanchez", Matricula = "S20015751", Promedio = 8.9f, IdCarrera = 1});
            Alumnos.Add(new Alumno {IdAlumno = 2, Nombre = "Maria Rodriguez Martinez", Matricula = "S20014367", Promedio = 9.2f, IdCarrera = 2});
            Alumnos.Add(new Alumno {IdAlumno = 3, Nombre = "José Trellez Jimenez", Matricula = "S20013298", Promedio = 9.9f, IdCarrera = 2});

        }

        public void obtenerAlumnosPorCarrera(int IdCarrera)
        {
            var Resultado = from alumno in Alumnos
                            join carrera in Carreras on alumno.IdCarrera equals carrera.IdCarrera
                            where alumno.IdCarrera == IdCarrera
                            select new { Alumno = alumno, NombreCarrera = carrera.Nombre };

            foreach (var item in Resultado)
            {
                Alumno alumno = item.Alumno;
                string nombreCarrera = item.NombreCarrera;
                alumno.getDatosAlumno();
                Console.WriteLine("Carrera: " + nombreCarrera);
            }
        }

    }
}
