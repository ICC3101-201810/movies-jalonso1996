using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void buttonActores_Click(object sender, EventArgs e)
        {

        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {

        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxBusqueda.Show();
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
                            this.listBoxBusqueda.Items.Add(s);
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
    }
}
