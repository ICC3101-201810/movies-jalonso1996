using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class BaseDatos
    {
        List<Pelicula> listapeliculas;
        List<Persona> listaPersona;
        List<Estudio> listaEstudio;

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
    }
    
}
