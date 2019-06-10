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
    public partial class PaseDeLista : Form
    {
        public PaseDeLista()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Inicics frm2 = new Inicics();
            this.Hide();
            frm2.ShowDialog();
        }
    }
}
