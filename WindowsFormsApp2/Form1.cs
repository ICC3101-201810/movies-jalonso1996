using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        BaseDatos nuevaBD;
        public Form1(BaseDatos miNuevaBD)
        {
            InitializeComponent();
            nuevaBD = miNuevaBD;
            listBoxBusqueda.Hide();
            listBoxPersonas.Hide();
            listBoxDirectores.Hide();
            listBoxProductores.Hide();
            listBoxEstudios.Hide();
            listBoxPeliculas.Hide();
            buttonVolver.Hide();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxPersonas.Hide();
                listBoxBusqueda.Hide();
                listBoxDirectores.Hide();
                listBoxProductores.Hide();
                listBoxEstudios.Hide();
                listBoxPeliculas.Show();
                buttonVolver.Show();
                List<Pelicula> listaPe = nuevaBD.GetListaPelicula();
                foreach (Pelicula pe in listaPe)
                {
                    if (listBoxPeliculas.Items.Contains(pe.GetNombrePel()))
                    {
                        continue;
                    }
                    else
                    {
                        this.listBoxPeliculas.Items.Add(pe.GetNombrePel());
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxDirectores.Hide();
                listBoxBusqueda.Hide();
                listBoxPersonas.Show();
                listBoxProductores.Hide();
                listBoxEstudios.Hide();
                listBoxPeliculas.Hide();
                buttonVolver.Show();
                List<Persona> listaP = nuevaBD.GetListaPersonas();
                foreach (Persona p in listaP)
                {
                    if (p.GetTipoPersona() == "Actor")
                    {
                        if (listBoxPersonas.Items.Contains(p.GetNombreApellido()))
                        {
                            continue;
                        }
                        else
                        {
                            this.listBoxPersonas.Items.Add(p.GetNombreApellido());
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxProductores.Hide();
                listBoxPersonas.Hide();
                listBoxBusqueda.Hide();
                listBoxDirectores.Show();
                listBoxEstudios.Hide();
                listBoxPeliculas.Hide();
                buttonVolver.Show();
                List<Persona> listaP = nuevaBD.GetListaPersonas();
                foreach (Persona p in listaP)
                {
                    if (p.GetTipoPersona() == "Director")
                    {
                        if (listBoxDirectores.Items.Contains(p.GetNombreApellido()))
                        {
                            continue;
                        }
                        else
                        {
                            this.listBoxDirectores.Items.Add(p.GetNombreApellido());
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxPersonas.Hide();
                listBoxBusqueda.Hide();
                listBoxDirectores.Hide();
                listBoxProductores.Show();
                listBoxEstudios.Hide();
                listBoxPeliculas.Hide();
                buttonVolver.Show();
                List<Persona> listaP = nuevaBD.GetListaPersonas();
                foreach (Persona p in listaP)
                {
                    if (p.GetTipoPersona() == "Productor")
                    {
                        if (listBoxProductores.Items.Contains(p.GetNombreApellido()))
                        {
                            continue;
                        }
                        else
                        {
                            this.listBoxProductores.Items.Add(p.GetNombreApellido());
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxPersonas.Hide();
            listBoxDirectores.Hide();
            listBoxProductores.Hide();
            listBoxBusqueda.Show();
            listBoxEstudios.Hide();
            listBoxPeliculas.Hide();
            buttonVolver.Show();
            listBoxBusqueda.Items.Clear();
            string texto = textBoxSearch.Text;
            try
            {
                if (texto.Length >= 3)
                {
                    List<string> listas = nuevaBD.listaStrings();
                    foreach (string s in listas)
                    {
                        if (s.Contains(texto))
                        {
                            if (listBoxBusqueda.Items.Contains(s))
                            {
                                continue;
                            }
                            else
                            {
                                this.listBoxBusqueda.Items.Add(s);
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void listBoxBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDirectores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxPersonas.Hide();
                listBoxBusqueda.Hide();
                listBoxDirectores.Hide();
                listBoxProductores.Hide();
                listBoxEstudios.Show();
                listBoxPeliculas.Hide();
                buttonVolver.Show();
                List<Estudio> listaE = nuevaBD.GetListaEstudio();
                foreach (Estudio es in listaE)
                {
                    if (listBoxEstudios.Items.Contains(es.GetNombreEstudio()))
                    {
                        continue;
                    }
                    else
                    {
                        this.listBoxEstudios.Items.Add(es.GetNombreEstudio());
                    }
                }
            }
            catch
            {

            }
        }

        private void listBoxProductores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEstudios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            listBoxPeliculas.Hide();
            listBoxPersonas.Hide();
            listBoxProductores.Hide();
            listBoxDirectores.Hide();
            listBoxEstudios.Hide();
            listBoxBusqueda.Hide();
            buttonVolver.Hide();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            if (File.Exists("../../Serialized.txt"))
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, nuevaBD);
                stream.Close();
            }
            else
            {
                Stream stream = new FileStream("../../Serialized.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, nuevaBD);
                stream.Close();
            }
            base.OnFormClosing(e);
        }
    }
}
