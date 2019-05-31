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
    public partial class Inicics : Form
    {
        public Inicics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaAlumnos frm2 = new listaAlumnos();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaMaetros frm2 = new listaMaetros();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaEventos frm2 = new listaEventos();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaActividades frm2 = new listaActividades();
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
