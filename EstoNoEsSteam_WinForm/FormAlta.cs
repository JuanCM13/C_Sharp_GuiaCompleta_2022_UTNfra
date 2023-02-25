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
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            this.Cmb_Usuario.DataSource = UsuarioDao.Leer();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Juego juego = new Juego(this.Txt_Nombre.Text , (Double)this.NUD_Precio.Value , this.Txt_Genero.Text , ((Usuario)this.Cmb_Usuario.SelectedItem).CodigoUsuario);

            JuegoDao.Guardar(juego);

            DialogResult = DialogResult.OK; //retorno que se guardo bien
        }
    }
}
