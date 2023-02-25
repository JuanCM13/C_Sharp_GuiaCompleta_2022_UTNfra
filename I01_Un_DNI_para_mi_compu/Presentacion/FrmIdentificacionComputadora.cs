using System.Windows.Forms;
using System.IO;
using System.Text; 

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = "Compu de " + System.Environment.UserName;
            this.lblSistemaOperativo.Text = "Sistema operativo: " + System.Environment.OSVersion;
            this.lblNombreMaquina.Text = "Nombre de la maquina: " + System.Environment.MachineName;
            this.lblCantProcesadores.Text = "Cant procesadores: " + System.Environment.ProcessorCount.ToString() + " procesadores logicos";
            this.lblDirectorioActual.Text = "Identificacion ejecutada en: " + System.Environment.NewLine + System.Environment.CurrentDirectory;
            this.ConfigurarLogoSistemaOperativo();
            this.ConfigurarArquitectura();
            this.ConfigurarEspacioTotalYDisponible();
        }   

        private void ConfigurarLogoSistemaOperativo()
        {
            if(System.OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else
            {
                if (System.OperatingSystem.IsLinux())
                {
                    this.picboxSistemaOperativo.Image = Properties.Resources.linux;
                }
                else
                {
                    if (System.OperatingSystem.IsIOS())
                    {
                        this.picboxSistemaOperativo.Image = Properties.Resources.mac;
                    }
                }
            }
        }

        private void ConfigurarArquitectura()
        {
            if(System.Environment.Is64BitProcess)
            {
                this.lblArquitectura.Text = "Arquitectura de: 64bits";
            }
            else
            {
                this.lblArquitectura.Text = "Arquitectura de: 32bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            double espacioTotal = 0;
            double espacioDisponible = 0;
            
            foreach(DriveInfo item in DriveInfo.GetDrives())
            {
                espacioTotal += item.TotalSize;
                espacioDisponible += item.AvailableFreeSpace;
            }

            this.lblEspacioTotal.Text = "Espacio total: " + System.Math.Round(espacioTotal).ToString() + "Gygabytes";
            this.lblEspacioDisponible.Text = "Espacio disponible: " + System.Math.Round(espacioDisponible).ToString() + "Gygabytes";
        }
    }
}
