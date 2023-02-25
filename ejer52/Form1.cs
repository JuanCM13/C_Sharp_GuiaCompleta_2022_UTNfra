using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Rbt_Result.ReadOnly = true;
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            Int32 kms;
            Int32 lts;
            Double rst;
            StringBuilder str;

            try
            {
                if( !String.IsNullOrWhiteSpace(this.Txb_Kilometros.Text) && !String.IsNullOrWhiteSpace(this.Txb_Kilometros.Text) )
                {
                    kms = int.Parse(this.Txb_Kilometros.Text);
                    lts = int.Parse(this.Txb_Litros.Text);

                    str = new StringBuilder().AppendLine($"La cantidad de consumo en {kms} kms es de: {Calculador.Calcular(kms, lts)}");
                    this.Rbt_Result.Text = str.ToString();
                }
                else
                {
                    throw new ParametrosVaciosException("Alguno de los campos no se lleno! :0");
                }
            }
            catch(ParametrosVaciosException ex)
            {
                this.TirarErrorDeExcepcion(ex, "Rellene los campos!");
            }
            catch(DivideByZeroException ex)
            {
                this.TirarErrorDeExcepcion(new Exception("No se puede dividir por cero!!",ex) , "Maquina por cero no");
            }
            catch (FormatException ex)
            {
                this.TirarErrorDeExcepcion(new Exception("Maquinola solo aceptamos numeros!!", ex), "Numeros!!!");
            }
            catch (Exception ex)
            { 
                this.TirarErrorDeExcepcion(ex, String.Empty);
            }
        }

        private void TirarErrorDeExcepcion(Exception ex , String mensaje)
        {
            if(!(ex is null))
            {                
                String aux = String.IsNullOrWhiteSpace(mensaje) ? "Ups, algo fallo.. Reintente.." : mensaje;

                MessageBox.Show(ex.Message, aux , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
}
