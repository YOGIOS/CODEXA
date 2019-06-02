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
    public partial class listaActividades : Form
    {
        private List<Actividades> Actividad = new List<Actividades>();
        private int edit_indx = -1;
        public listaActividades()
        {
            InitializeComponent();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para poder editar un elemento seleccionelo y de doble click");
        }

        private void btnRegr_Click(object sender, EventArgs e)
        {
            Inicics frm2 = new Inicics();
            this.Hide();
            frm2.ShowDialog();
        }

        private void btnAñadr_Click(object sender, EventArgs e)
        {
            Actividades act = new Actividades();
            act.ID_Actividad = txtIDACT.Text;
            act.Nombre_Actividad = txtNombreACT.Text;
            act.Docente = txtDocenteACT.Text;
            act.Grupo = txtGrupoACT.Text;
            if(edit_indx > -1)
            {
                Actividad[edit_indx] = act;
                edit_indx = -1;

            }
            else
            {
                Actividad.Add(act);
            }
            
            ActuallizacionData();
            limpiar();
        }
        private void ActuallizacionData()
        {
            dgvGrid.DataSource = null;
            dgvGrid.DataSource = Actividad;
        }
        private void limpiar()
        {
            txtIDACT.Text = "";
            txtNombreACT.Text = "";
            txtDocenteACT.Text = "";
            txtGrupoACT.Text = "";

        }
        private void dgvGrid_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccionada = dgvGrid.SelectedRows[0];
            int pos = dgvGrid.Rows.IndexOf(seleccionada);
            edit_indx = pos;
            Actividades act = Actividad[pos];
            txtIDACT.Text = act.ID_Actividad;
            txtNombreACT.Text = act.Nombre_Actividad;
            txtDocenteACT.Text = act.Docente;
            txtGrupoACT.Text = act.Grupo;
        }
        private void btnElimn_Click(object sender, EventArgs e)
        {
            if (edit_indx > -1)
            {
                Actividad.RemoveAt(edit_indx);
                edit_indx = -1;
                limpiar();
                ActuallizacionData();
            }
            else
            {
                MessageBox.Show("Presione el boton AYUDA para saber como ingresar al modo edicion");
            }
        }

       
    }
}
