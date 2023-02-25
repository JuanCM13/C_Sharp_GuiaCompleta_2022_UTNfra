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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(String nombre)
        {
            String aux;
            if(String.IsNullOrEmpty(nombre))
            {
                 aux = "Sin especificar";
            }
            else
            {
                aux = nombre;
            }

            this.label1.Text = aux;
        }
    }
}
