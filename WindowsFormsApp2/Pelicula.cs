using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace WindowsFormsApp2
{
    [Serializable]
    public class Pelicula
    {
        string nombre;
        Persona director;
        DateTime fecha_estreno;
        string descripcion;
        int presupuesto;
        Estudio estudio;

        public Pelicula(string miNombre, Persona miDirector, DateTime miFechaEstreno, string miDescripcion, int miPresupuesto, Estudio miEstudio)
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
