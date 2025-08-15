using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3MLIDTS_DiegoAguilar_02c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("precionaste el boton aceptar");
        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("presionaste el boton cancelar gayy ");
        }
    }
}
