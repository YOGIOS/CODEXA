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
            Actividad.Add(act);
            ActuallizacionData();
        }
        private void ActuallizacionData()
        {
            dgvGrid.DataSource = null;
            dgvGrid.DataSource = Actividad;
        }
    }
}
