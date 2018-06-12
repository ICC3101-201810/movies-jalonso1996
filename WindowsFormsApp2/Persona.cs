using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Persona
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        string biografia;

        public Persona(string miNombre, string miApellido, DateTime miFechaNacimiento, string miBiografia)
        {
            nombre = miNombre;
            apellido = miApellido;
            fechaNacimiento = miFechaNacimiento;
            biografia = miBiografia;
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
    }
}
