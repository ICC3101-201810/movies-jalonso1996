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
    public class BaseDatos
    {
        List<Pelicula> listapeliculas = new List<Pelicula>();
        List<Persona> listaPersona = new List<Persona>();
        List<Estudio> listaEstudio = new List<Estudio>();

        public List<string> listaStrings()
        {
            List<string> listastringes = new List<string>();
            foreach (Pelicula p in listapeliculas)
            {
                listastringes.Add(p.GetDescripcion());
                listastringes.Add(p.GetNombrePel());
            }
            foreach (Persona p in listaPersona)
            {
                listastringes.Add(p.GetBiografia());
                listastringes.Add(p.GetNombreApellido());
            }
            foreach (Estudio e in listaEstudio)
            {
                listastringes.Add(e.GetDireccionEstudio());
                listastringes.Add(e.GetNombreEstudio());
            }
            return listastringes;
        }

        public List<Persona> GetListaPersonas()
        {
            return listaPersona;
        }
        public List<Estudio> GetListaEstudio()
        {
            return listaEstudio;
        }
        public List<Pelicula> GetListaPelicula()
        {
            return listapeliculas;
        }
        public void AgregarPersona(Persona p)
        {
            listaPersona.Add(p);
        }
        public void AgregarEstudio(Estudio es)
        {
            listaEstudio.Add(es);
        }
        public void AgregarPelicula(Pelicula pe)
        {
            listapeliculas.Add(pe);
        }
    }
    
}
