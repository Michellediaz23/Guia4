using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public partial class Universidad
    {

        //Lista de alumnos
        private List<Alumno> alumnoList;

        //Constructor para inicializar la lista de alumnos
        public Universidad()
        {
            alumnoList = new List<Alumno>();
        }
        public void AgregarAlumno(Alumno alumno)
        {
            alumnoList.Add(alumno);
        }

        //metodo para obtener la lista de alumnos
        public List<Alumno> ObtenerListaAlumno()
        {
            return alumnoList;
        }

    }
}