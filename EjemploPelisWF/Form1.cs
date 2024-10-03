using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploPelisWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnadirPelicula_Click(object sender, EventArgs e)
        {
            //Vamos a meter la película dentro de la lista desplegable

            if (!string.IsNullOrEmpty(txtPelicula.Text))
            {
                if(txtPelicula.Text.Length < 20)
                { 
                cbPeliculas.Items.Add(txtPelicula.Text);
                txtPelicula.Clear();
                txtPelicula.Focus();
                }
                else
                {
                    MessageBox.Show("Debes escribir una película cuya longitud no excede de 20", "Advertencia al usuario");
                }

            }
            else
            {
                MessageBox.Show("Debes escribir una película en la caja de texto","Advertencia al usuario");
            }
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
