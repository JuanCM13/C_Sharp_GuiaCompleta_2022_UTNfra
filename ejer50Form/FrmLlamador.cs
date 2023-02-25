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
    public partial class FrmLlamador : Form
    {
        private Centralita cen;
        private TextBox auxTbxSeleccionado;
        private Int32 flagControlTbxDestinoVacio;
        private Int32 flagControlTbxOrigenVacio;
        private Random randomPrecio;
        private Random randomDuracion;

        public FrmLlamador(Centralita llamadas)
        {
            InitializeComponent();
            this.cen = llamadas;
            this.randomDuracion = new Random();
            this.randomPrecio = new Random();
        }

        public Centralita CentralTelefonica
        {
            get { return this.cen; }
        }

        /// <summary>
        /// Setea el combobox de franjas horarias y llama al metodo Limpiar() para setear todo por default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.Cmb_Franja.DataSource = Enum.GetValues(typeof(Franja));            
            this.Cmb_Franja.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Limpiar();

        }

        #region Logica Form

        /// <summary>
        /// Llama al metodo Limpiar()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Setea valores por default, asigna texto guia a los textbox numOrigen y numDestino
        /// </summary>
        private void Limpiar()
        {
            this.Tbt_NroDestino.Text = "Nro Destino";
            this.Tbt_NroOrigen.Text = "Nro Origen";
            this.flagControlTbxDestinoVacio = 0;
            this.flagControlTbxOrigenVacio = 0;
            this.auxTbxSeleccionado = null;
            this.Cmb_Franja.Enabled = false;
        }

        /// <summary>
        /// Evento relacionado a el tablero numerico, setea el numero seleccionado en el textbox seleccionado...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNumeros_Click(object sender, EventArgs e)
        {
            if( !(this.auxTbxSeleccionado is null) )
            {
                this.auxTbxSeleccionado.Text += ((Button)sender).Text; 
            }
            else
            {
                this.GeneradorMensajeError("Debe seleccionar el cuadro de nro de destino o origen.." , this.Tbt_NroDestino);
            }
        }

        /// <summary>
        /// Genera un mensaje de error tipo MessegeBox, con el mensaje pasado por parametro y da el foco al control pasado
        /// por parametro
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="control"></param>
        private void GeneradorMensajeError(String mensaje , Control control)
        {
            if( !String.IsNullOrWhiteSpace(mensaje) )
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
            }
        }

        /// <summary>
        /// Asigna distintas flags para el control de los textbox tanto de destino como origen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbt_NroDestino_Click(object sender, EventArgs e)
        {
            this.auxTbxSeleccionado = this.Tbt_NroDestino;
            if (this.flagControlTbxDestinoVacio == 0)
            {
                this.Tbt_NroDestino.Text = String.Empty;
                this.flagControlTbxDestinoVacio = 1;
                
                if (this.flagControlTbxOrigenVacio == 0)
                {
                    this.Tbt_NroOrigen.Text = String.Empty;
                    this.flagControlTbxOrigenVacio = 1;
                }
            }
        }

        /// <summary>
        /// Asigna distintas flags para el control de los textbox tanto de destino como origen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbt_NroOrigen_Click(object sender, EventArgs e)
        {
            this.auxTbxSeleccionado = this.Tbt_NroOrigen;
            if (this.flagControlTbxOrigenVacio == 0)
            {
                this.Tbt_NroOrigen.Text = String.Empty;
                this.flagControlTbxOrigenVacio = 1;

                if(this.flagControlTbxDestinoVacio == 0)
                {
                    this.Tbt_NroDestino.Text = String.Empty;
                    this.flagControlTbxDestinoVacio = 1;
                }
            }
        }

        /// <summary>
        /// Habilita la seleccion de franja horaria solo si el tipo de llamada es de tipo Provincial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbt_NroDestino_Leave(object sender, EventArgs e)
        {
            if((this.Tbt_NroDestino.Text).Length > 0 && this.Tbt_NroDestino.Text.ElementAt(0) == '#')
            {
                this.Cmb_Franja.Enabled = true;
            }
        }

        /// <summary>
        /// Genera una llamada filtrando por tipo, y la asigna a el listado de llamadas de la centralita, evalua errores..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Llamar_Click(object sender, EventArgs e)
        {
            Franja franjas;
            String nroDest;
            String nroOrin;
            Single auxPrecio;
            Single auxDuracion;

            if ( !String.IsNullOrWhiteSpace(this.Tbt_NroDestino.Text) && !String.IsNullOrWhiteSpace(this.Tbt_NroOrigen.Text))
            {
                nroDest = this.Tbt_NroDestino.Text;
                nroOrin = this.Tbt_NroOrigen.Text;
                auxDuracion = this.randomDuracion.Next(1, 50);

                if (this.Tbt_NroDestino.Text.ElementAt(0) == '#')
                {
                    if (this.Cmb_Franja.SelectedItem != null)
                    {
                        if (Enum.TryParse<Franja>(Cmb_Franja.SelectedValue.ToString(), out franjas))
                        {
                            this.cen += new Provincial(nroOrin, franjas, auxDuracion, nroDest);
                            MessageBox.Show($"La llamada provincial a: {nroDest} , se realizo con exito!", "Cargado!", MessageBoxButtons.OK);
                        }                        
                    }                    
                    else
                    {
                        this.GeneradorMensajeError("Error, debe seleccionar alguna franja horaria..", this.Cmb_Franja);
                    }
                }
                else
                {
                    //auxPrecio = ((Single)(this.randomPrecio.Next() * (5.6 - 0.5) + 0.5));
                    auxPrecio = (Single)(this.randomPrecio.NextDouble() * (5.6F - 0.5F) + 0.5F);
                    this.cen += new Local(nroOrin, auxDuracion, nroDest, auxPrecio);
                    MessageBox.Show($"La llamada local a: {nroDest} , se realizo con exito!", "Cargado!", MessageBoxButtons.OK);
                }
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Maquina tenes que tener lleno los dos recuadros..", "Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Evita que se puedan ingresar caracteres via teclado a los textbox del form.. 
        /// Solo se podran cargar a travez del panel numerico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbt_NroDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            //asi ignora el ingreso por teclas..i
            e.Handled = true; 
        }

        /// <summary>
        /// Cierra el formulario, pidiendo confirmacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?" , "Confirm!" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
