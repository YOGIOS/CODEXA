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
    public partial class listaMaetros : Form
    {
        private List<Maestro> MA = new List<Maestro>();
        private int edit_indx = -1;
        public listaMaetros()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicics frm2 = new Inicics();
            this.Hide();
            frm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Para poder editar o eliminar un elemento seleccionelo y de doble click");
        }

        private void btnAñadirMst_Click(object sender, EventArgs e)
        {
            Maestro mas = new Maestro();
            mas.Matricula = txtMatricula.Text;
            mas.Nombre = txtNombreDocente.Text;
            mas.Certificacion = txtCertificaciones.Text;
            mas.Horario_De_Trabajo = txtHorarioTrabajo.Text;
            
            if (edit_indx > -1)
            {
                MA[edit_indx] = mas;
                edit_indx = -1;

            }
            else
            {
                MA.Add(mas);
            }
            actualizaDataGrid();
            LimpiarD();
        }
        private void actualizaDataGrid()
        {
            dvgFR.DataSource = null;
            dvgFR.DataSource = MA;
            
        }

        private void dvgFR_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccionada = dvgFR.SelectedRows[0];
            int pos = dvgFR.Rows.IndexOf(seleccionada);
            edit_indx = pos;
            Maestro mas = MA[pos];
            txtMatricula.Text = mas.Matricula;
            txtNombreDocente.Text = mas.Nombre;
            txtCertificaciones.Text = mas.Certificacion;
            txtHorarioTrabajo.Text = mas.Horario_De_Trabajo;
            
        }
        private void LimpiarD()
        {
            txtMatricula.Text = "";
            txtNombreDocente.Text = "";
            txtCertificaciones.Text = "";
            txtHorarioTrabajo.Text = "";


        }

        private void btnEliminarMs_Click(object sender, EventArgs e)
        {
            if (edit_indx > -1)
            {
                MA.RemoveAt(edit_indx);
                edit_indx = -1;
                LimpiarD();
                actualizaDataGrid();
            }
            else
            {
                MessageBox.Show("Presione el boton AYUDA para saber como ingresar al modo edicion");
            }
        }
    }
}
