using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotePad_Utn_Form
{
    public partial class Form1 : Form
    {
        private String rutaArchivo = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String clickeado = e.ClickedItem.Text;

            switch(clickeado)
            {
                case "Abrir":
                    try 
                    {
                        this.rutaArchivo = this.Abrir_Metodo();
                    }                  
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}\nSTACKTRACE:\n{ex.StackTrace}", "Controle", MessageBoxButtons.OK);
                    }
                    break;
                case "Guardar":
                    try
                    {
                        if (!String.IsNullOrWhiteSpace(this.rutaArchivo))
                        {
                            if(this.Guardar(this.rutaArchivo))
                            {
                                MessageBox.Show("Archivo guardado","Confirmado" , MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            if(this.GuardarComo())
                            {
                                MessageBox.Show("Archivo guardado", "Confirmado", MessageBoxButtons.OK);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Rompimo todoo\nError: {ex.Message}\nSTACK: {ex.StackTrace}", "Error", MessageBoxButtons.OK);
                    }
                    break;
                case "Guardar Como":
                    try
                    {
                        if(this.GuardarComo())
                        {
                            MessageBox.Show("Archivo guardado", "Confirmado", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}\nSTACKTRACE:\n{ex.StackTrace}", "Controle", MessageBoxButtons.OK);
                    }
                    break;
            }
        }

        private bool GuardarComo()
        {
            DialogResult aux;
            String ruta;
            bool ret = false;

            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files|*.txt";
                aux = sfd.ShowDialog();
                if (aux == DialogResult.OK)
                {
                    ruta = sfd.FileName;
                    File.WriteAllText(ruta, this.Rtb_NotePad.Text);
                    this.rutaArchivo = ruta; //actualizo la ruta a la que voy a guardar desde ahora..
                    ret = true;
                }
                else
                {
                    if( !(aux == DialogResult.Cancel))
                    {
                        throw new Exception("Error, la ruta seleccionada no existe, o no es el formato .txt..");
                    }
                }
            }
            return true;
        }

        private bool Guardar(String path)
        {
            if (File.Exists(path))
            {
                File.WriteAllText(path, this.Rtb_NotePad.Text);
                return  true;
            }
            else
            {
                throw new Exception($"Error, el archivo parece que se perdio, pruebe creando un nuevo archivo (guardar como)");
            }
        }

        private String Abrir_Metodo()
        {
            String ruta = String.Empty;
            String contenido = String.Empty;
            DialogResult resultadoCarpeta = default;

            using (OpenFileDialog carpetaArchivos = new OpenFileDialog())
            {
                carpetaArchivos.InitialDirectory = "c:\\";
                //carpetaArchivos.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; asi admite todos los archivos
                carpetaArchivos.Filter = "Text Files|*.txt"; //abre archivos tipo .txt
                carpetaArchivos.FilterIndex = 2;
                carpetaArchivos.RestoreDirectory = true;

                resultadoCarpeta = carpetaArchivos.ShowDialog();
                if (resultadoCarpeta == DialogResult.OK)
                {
                    ruta = carpetaArchivos.FileName;
                    
                    if(File.Exists(ruta))
                    {
                        using (StreamReader str = File.OpenText(ruta))
                        {
                            this.Rtb_NotePad.Text = str.ReadToEnd();
                        }
                    }  
                    else
                    {
                        throw new Exception("Error, la ruta no existe..");
                    }
                }
                else
                {
                    if ( !(resultadoCarpeta == DialogResult.Cancel)) //si no selecciona archivo ni cancelo o cerro con cruz, tira excepcion
                    {
                        throw new Exception("Error, no se pudo abrir la carpeta de archivos");
                    }
                }
            }
            return ruta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Menu_Archivo.Items.Add("Abrir");
            this.Menu_Archivo.Items.Add("Guardar");
            this.Menu_Archivo.Items.Add("Guardar Como");
            this.StatusStrip_CantCaracteres.Text = $"Cantidad caracteres: {this.Rtb_NotePad.Text.Length}";
        }
    }
}
