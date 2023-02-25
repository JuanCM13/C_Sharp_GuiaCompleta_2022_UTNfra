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
    public partial class FrmMostrar : Form
    {
        public TipoLlamada tipo;

        public FrmMostrar(Centralita c , TipoLlamada tipo , String tituloForm)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.Text = tituloForm;
            this.Rtb_Facturacion.Text = this.GenerarData(tipo, c);
        }

        private String GenerarData(TipoLlamada tipo , Centralita central)
        {
            StringBuilder data = new StringBuilder();

            if (!(central is null))
            {
                switch (tipo)
                {
                    case TipoLlamada.Local:
                        data.AppendLine($"Ganancia por Llamadas Locales: \n{(central.GananciaPorLocal).ToString("#.#,00")}");
                    break;
                    case TipoLlamada.Provincial:
                        data.AppendLine($"Ganancia por Llamadas Provinciales: \n{(central.GananciaPorProvincial).ToString("#.#,00")}");                               
                    break;
                    case TipoLlamada.Todas:
                        data.AppendLine(central.ToString());
                    break;
                }                
            }
            else
            {
                data.AppendLine("La central no fue creada!!\n");
            }
            return data.ToString();
        }
    }
}
