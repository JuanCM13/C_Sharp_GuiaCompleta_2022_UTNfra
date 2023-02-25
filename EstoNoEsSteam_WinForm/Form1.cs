using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstoNoEsSteam_Entidades;

namespace EstoNoEsSteam_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            this.DataGrid_Juegos.DataSource = JuegoDao.Leer();
            this.DataGrid_Juegos.Refresh();
            this.DataGrid_Juegos.Update();
        }

        private void Btn_AgregarJuego_Click(object sender, EventArgs e)
        {
            FormAlta frmAlta = new FormAlta();

            if(frmAlta.ShowDialog() == DialogResult.OK)
            {
                this.RefrescarBiblioteca();
            }
        }

        private void Btn_EliminarJuego_Click(object sender, EventArgs e)
        {
            if(this.DataGrid_Juegos.SelectedRows.Count > 0)
            {
                Biblioteca aux = (Biblioteca)this.DataGrid_Juegos.CurrentRow.DataBoundItem;

                JuegoDao.Eliminar(aux.CodigoJuego);

                this.RefrescarBiblioteca();
            }
        }

        private void Btn_ModificarJuego_Click(object sender, EventArgs e)
        {
            if (this.DataGrid_Juegos.SelectedRows.Count > 0)
            {
                FormModificacion frmMod = new FormModificacion((Biblioteca)this.DataGrid_Juegos.CurrentRow.DataBoundItem);
                
                if(frmMod.ShowDialog() == DialogResult.OK)
                {
                    this.RefrescarBiblioteca();
                }
            }
        }


    }
}
