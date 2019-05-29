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
    public partial class Inici : Form
    {

        private List<Alumno> alumnos = new List<Alumno>();
        public Inici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alumno alm = new Alumno();
            alm.nombre = txtNombre.Text;
            alm.carrera = txtCarrera.Text;
           // alm.telefono = txtTelefono.TextLength;

            Alumno.Add(alm);
            actualizarGrid();

        }
        private void actualizarGrid()
        {
            dgvDatos.DataSource = alumnos;

        }

        private void Inici_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
