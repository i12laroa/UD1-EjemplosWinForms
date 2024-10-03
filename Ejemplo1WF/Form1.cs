using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            listNombres.Items.Add(txtNombre.Text);
            txtNombre.Clear();
            txtNombre.Focus();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }
    }
}
