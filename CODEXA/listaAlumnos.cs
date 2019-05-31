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
    public partial class listaAlumnos : Form
    {
        private List<Alumno> Alumnos = new List<Alumno>();
        public listaAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno alumn = new Alumno();
            alumn.numeroDeControl = txtNumeroControl.Text;
            alumn.nombre = txtNombreAlumno.Text;
            alumn.edad = txtEdad.Text;
            alumn.genero = txtGenero.Text;
            alumn.carrera = txtCarrera.Text;
            alumn.semestre = txtSemestre.Text;
            alumn.genero = txtGenero.Text;
            alumn.condicionDiferente = txtCondicionDiferente.Text;
            alumn.acreditaciones = txtAcreditacion.Text;
            Alumnos.Add(alumn);
            actualizarGrid();
        }
        private void actualizarGrid()
        {
            dvgGrid.DataSource = null;
            dvgGrid.DataSource = Alumnos;
        }

        private void btnRegre_Click(object sender, EventArgs e)
        {
            Inicics frm2 = new Inicics();
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
