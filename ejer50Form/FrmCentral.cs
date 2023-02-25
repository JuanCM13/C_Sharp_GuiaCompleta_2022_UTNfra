using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita2;

namespace ejer50Form
{
    public partial class FrmCentral : Form
    {
        Centralita centralTelefonica;

        public FrmCentral()
        {
            InitializeComponent();
            this.centralTelefonica = new Centralita("Lo De Juan");
        }

        private void Btn_GenerarLlamada_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmLlamador frm = new FrmLlamador(this.centralTelefonica);
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Btn_FactTotal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMostrar frm = new FrmMostrar(this.centralTelefonica , TipoLlamada.Todas , "Data de Facturacion Total");
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Btn_FacLocal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMostrar frm = new FrmMostrar(this.centralTelefonica, TipoLlamada.Local, "Data de Facturacion Llamadas Locales");
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Btn_FacProvincial_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMostrar frm = new FrmMostrar(this.centralTelefonica, TipoLlamada.Provincial, "Data de Facturacion Llamadas Provinciales");
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCentral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir? se perdera toda la informacion..","Confirme",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
