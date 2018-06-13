using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BaseDatos nuevaBD;
            if (File.Exists("../../Serialized.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Read);
                nuevaBD = (BaseDatos)bin.Deserialize(stream);
                stream.Close();
            }
            else
            {
                nuevaBD = new BaseDatos();
                string fechayhoraprueba = "1994-06-13";
                DateTime fechaprueba = DateTime.ParseExact(fechayhoraprueba, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                Persona persona1 = new Persona("Julio", "Alonso",fechaprueba,"Hombre, director, de 24 anos", "Director");
                string fechayhoraprueba1 = "2005-02-01";
                DateTime fechaprueba1 = DateTime.ParseExact(fechayhoraprueba1, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                Persona persona2 = new Persona("Javiera", "Alonso", fechaprueba1, "Mujer, actriz, de 13 anos", "Actor");
                string fechayhoraprueba2 = "1996-01-29";
                DateTime fechaprueba2 = DateTime.ParseExact(fechayhoraprueba2, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                Persona perssona3 = new Persona("Joaquin", "Alonso", fechaprueba2, "Hombre, productor, de 22 anos", "Productor");
                string fechayhoraprueba3 = "1990-11-17";
                DateTime fechaprueba3 = DateTime.ParseExact(fechayhoraprueba3, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                string fechayhoraprueba4 = "1920-12-10";
                DateTime fechaprueba4 = DateTime.ParseExact(fechayhoraprueba4, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                Estudio estudio1 = new Estudio("MarvelFoxDisneyUniversal", "Los Teletubies 1243, Las Vitachea", fechaprueba4);
                Pelicula pelicula = new Pelicula("Las mostazas asesinas", persona1,fechaprueba3, "Pelicula donde unas mostazas cobran vida y se comen a la gente para que mueran", 123456789,estudio1);
                nuevaBD.AgregarPelicula(pelicula);
                nuevaBD.AgregarPersona(persona1);
                nuevaBD.AgregarPersona(persona2);
                nuevaBD.AgregarPersona(perssona3);
                nuevaBD.AgregarEstudio(estudio1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(nuevaBD));
        }
    }
}
