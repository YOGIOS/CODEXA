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
    public partial class listaEventos : Form
    {
        private List<Eventos> even = new List<Eventos>();
        private int edit_indx = -1;
        public listaEventos()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Inicics frm2 = new Inicics();
            this.Hide();
            frm2.ShowDialog();
        }

        private void btnAyda_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Para poder editar un elemento seleccionelo y de doble click");
        }

        private void btnAñadirEve_Click(object sender, EventArgs e)
        {
            Eventos eve = new Eventos();
            eve.ID_Evento = txtIDeve.Text;
            eve.Nombre_Evento = txtNombreEve.Text;
            eve.Tipo = txttipoEve.Text;
            eve.Fecha = txtFechaEve.Text;
            eve.Lugar_Evento = txtLugarEve.Text;
            if (edit_indx > -1)
            {
                even[edit_indx] = eve;
                edit_indx = -1;

            }
            else
            {
                even.Add(eve);
            }
         
            actualizacionDataGrid();
            LimpiarDatos();
        }
        private void actualizacionDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = even;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccionada = dataGridView1.SelectedRows[0];
            int pos = dataGridView1.Rows.IndexOf(seleccionada);
            edit_indx = pos;
            Eventos eve = even[pos];
            txtIDeve.Text = eve.ID_Evento;
            txtNombreEve.Text = eve.Nombre_Evento;
            txttipoEve.Text = eve.Tipo;
            txtFechaEve.Text = eve.Fecha;
            txtLugarEve.Text = eve.Lugar_Evento;
        }
        private void LimpiarDatos()
        {
            txtIDeve.Text = "";
            txtNombreEve.Text = "";
            txttipoEve.Text = "";
            txtFechaEve.Text = "";
            txtLugarEve.Text = "";


        }

        private void btnEliminarEve_Click(object sender, EventArgs e)
        {
            if (edit_indx > -1)
            {
                even.RemoveAt(edit_indx);
                edit_indx = -1;
                LimpiarDatos();
                actualizacionDataGrid();
            }
            else
            {
                MessageBox.Show("Presione el boton AYUDA para saber como ingresar al modo edicion");
            }
        }
    }
}
