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
        private int edit_index = -1;
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
            if(edit_index > -1)
            {
                Alumnos[edit_index] = alumn;
                edit_index = -1;
            }
            else
            {
                Alumnos.Add(alumn);
            }
           
            actualizarGrid();
            Limpiar();

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

        private void dvgGrid_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccionada = dvgGrid.SelectedRows[0];
            int pos = dvgGrid.Rows.IndexOf(seleccionada);
            edit_index = pos;
            Alumno alumn = Alumnos[pos];
            txtNumeroControl.Text = alumn.numeroDeControl;
            txtNombreAlumno.Text = alumn.nombre;
            txtEdad.Text = alumn.edad;
            txtGenero.Text = alumn.genero;
            txtCarrera.Text = alumn.carrera;
            txtCondicionDiferente.Text = alumn.condicionDiferente;
            txtSemestre.Text = alumn.semestre;
            txtAcreditacion.Text = alumn.acreditaciones;
           // MessageBox.Show(pos.ToString());
        }
        private void Limpiar()
        {
            txtNumeroControl.Text = "";
            txtNombreAlumno.Text = "";
            txtEdad.Text = "";
            txtGenero.Text = "";
            txtCarrera.Text = "";
            txtCondicionDiferente.Text = "";
            txtSemestre.Text = "";
            txtAcreditacion.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(edit_index > -1)
            {
                Alumnos.RemoveAt(edit_index);
                edit_index = -1;
                Limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe de ingresar al modo edicion para poder eliminar esta informacion, presione el boton de ayuda para saber como ingresar a este modo");
            }
        }
    }
}
