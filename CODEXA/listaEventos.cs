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
            even.Add(eve);
            actualizacionDataGrid();
        }
        private void actualizacionDataGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = even;
           
        }
    }
}
