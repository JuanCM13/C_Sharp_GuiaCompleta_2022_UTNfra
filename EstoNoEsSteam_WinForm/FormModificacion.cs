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
    public partial class FormModificacion : Form
    {
        private Biblioteca game;

        public FormModificacion()
        {
            InitializeComponent();
        }

        public FormModificacion(Biblioteca juego)
            :this()
        {
            this.game = juego;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if( !String.IsNullOrWhiteSpace(this.Txt_Genero.Text) && !String.IsNullOrWhiteSpace(this.Txt_Nombre.Text))
            {
                try
                {
                    Juego aModificar = JuegoDao.LeerPorId(game.CodigoJuego);
                    Juego aux = new Juego(this.Txt_Nombre.Text.ToString(), (Double)this.NUD_PrecioMod.Value, this.Txt_Genero.Text.ToString(), aModificar.CodigoJuego , aModificar.CodigoUsuario);
                    if(!(aux is null))
                    {
                        if (JuegoDao.Modificar(aux))
                        {
                            MessageBox.Show("Juego modificado!", "Confirmado", MessageBoxButtons.OK);
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar!", "Rompimotodo", MessageBoxButtons.OK);
                        }
                    }                    
                }    
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK);
                }
            }
        }

        private void FormModificacion_Load(object sender, EventArgs e)
        {
            if(this.game is not null)
            {
                Juego aux = JuegoDao.LeerPorId(this.game.CodigoJuego);

                this.Txt_Genero.Text = aux.Genero;
                this.Txt_Nombre.Text = aux.Nombre;
                this.NUD_PrecioMod.Value = (Decimal)aux.Precio;
            }                     
        }
    }
}
