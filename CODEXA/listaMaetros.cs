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

            MessageBox.Show("Para poder editar un elemento seleccionelo y de doble click");
        }

        private void btnAñadirMst_Click(object sender, EventArgs e)
        {
            Maestro mas = new Maestro();
            mas.Matricula = txtMatricula.Text;
            mas.Nombre = txtNombreDocente.Text;
            mas.Certificacion = txtCertificaciones.Text;
            mas.Horario_De_Trabajo = txtHorarioTrabajo.Text;
            MA.Add(mas);
            actualizaDataGrid();
        }
        private void actualizaDataGrid()
        {
            dvgFR.DataSource = null;
            dvgFR.DataSource = MA;
            
        }
    }
}
