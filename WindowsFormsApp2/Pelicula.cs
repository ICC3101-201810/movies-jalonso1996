using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Pelicula
    {
        string nombre;
        Persona director;
        DateTime fecha_estreno;
        string descripcion;
        int presupuesto;
        string estudio;

        public Pelicula(string miNombre, Persona miDirector, DateTime miFechaEstreno, string miDescripcion, int miPresupuesto, string miEstudio)
        {
            nombre = miNombre;
            director = miDirector;
            fecha_estreno = miFechaEstreno;
            descripcion = miDescripcion;
            presupuesto = miPresupuesto;
            estudio = miEstudio;
        }

        public string GetNombrePel()
        {
            return nombre;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
    }
}
