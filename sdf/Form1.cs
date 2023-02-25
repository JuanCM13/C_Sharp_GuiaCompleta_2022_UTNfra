using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElDelegado_Form
{
    public partial class Form1 : Form
    {
        private sdf.FrmTestDelegados delegados;
        private FrmMostrar mostrar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar = new FrmMostrar();
            delegados = new sdf.FrmTestDelegados(new sdf.FrmTestDelegados.CambiarNombreDelegate(mostrar.ActualizarNombre));

            delegados.MdiParent = this;
            mostrar.MdiParent = this;

            this.mostrarToolStripMenuItem.Enabled = false;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.delegados.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mostrar.Show();
        }
    }
}
