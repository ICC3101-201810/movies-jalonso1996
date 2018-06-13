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
    public class Persona
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        string biografia;
        string tipo;

        public Persona(string miNombre, string miApellido, DateTime miFechaNacimiento, string miBiografia, string miTipo)
        {
            nombre = miNombre;
            apellido = miApellido;
            fechaNacimiento = miFechaNacimiento;
            biografia = miBiografia;
            tipo = miTipo;
        }
        public string GetNombreApellido()
        {
            string nombreC = nombre + " " + apellido;
            return nombreC;
        }
        public string GetBiografia()
        {
            return biografia;
        }
        public string GetTipoPersona()
        {
            return tipo;
        }
    }
}
