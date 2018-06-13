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
    public class Estudio
    {
        string nombre;
        string direccion;
        DateTime fechaApertura;

        public Estudio(string miNombre, string miDireccion, DateTime miFechaApertura)
        {
            nombre = miNombre;
            direccion = miDireccion;
            fechaApertura = miFechaApertura;
        }
        public string GetDireccionEstudio()
        {
            return direccion;
        }
        public string GetNombreEstudio()
        {
            return nombre;
        }
    }
}
