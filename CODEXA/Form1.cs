using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEXA
{
    public partial class Form1 : Form
    {
        Validacion v = new Validacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.valLetter(e);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.vaNumer(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inici frm2 = new Inici();

            frm2.ShowDialog();
            this.Close();
        }
    }
}
