using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPrimerCruz_BaseDatos;

namespace BaseDatos_Persona_WinForm_Vista
{
    public partial class Form1 : Form
    {
        List<Persona> personas;
        PersonaDAO gestor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.gestor = new PersonaDAO();
            this.personas = new List<Persona>();
        }

        private void Leer_Click(object sender, EventArgs e)
        {
            this.lstPersonas.Enabled = true;
            this.lstPersonas.Items.Clear();
            this.personas = gestor.Leer();

            if(personas.Count > 0)
            {
                foreach(Persona item in this.personas)
                {
                    lstPersonas.Items.Add(item);
                }
            }
            else
            {
                this.lstPersonas.Enabled = false;
                this.lstPersonas.Items.Add("Sin elementos al momento..");
            }
        }

        private void DobleClick_DatosUsuario_Click(object sender, EventArgs e)
        {
            Persona auxP = default;
            if(this.lstPersonas.Enabled == true)
            {
                auxP = (Persona)this.lstPersonas.SelectedItem;
                if(!(auxP is null))
                {
                    this.txtApellido.Text = auxP.Apellido;
                    this.txtNombre.Text = auxP.Nombre;
                }
            }
            else
            {
                MessageBox.Show("Viejo, no tenes usuarios cargados todavia duh","Avivate negro",MessageBoxButtons.OK);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 id;
            String nombre;
            String apellido;

            if(String.IsNullOrWhiteSpace(this.txtApellido.Text) && String.IsNullOrWhiteSpace(this.txtApellido.Text) || this.lstPersonas.SelectedIndex > -1)
            {
                MessageBox.Show("Asegurese de seleccionar un usuario para modificar..");
            }
            else
            {
                id = ((Persona)this.lstPersonas.SelectedItem).ID;
                nombre = this.txtNombre.Text;
                apellido = this.txtApellido.Text;

                if(gestor.ModificarPorID(id , nombre , apellido))
                {
                    this.Leer_Click(sender , e);
                    MessageBox.Show($"El usuario con ID: {id}, fue modificado con exito!", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"Algo salio mal reintente!", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLiberarListbox_Click(object sender, EventArgs e)
        {
            this.txtApellido.Text = String.Empty;
            this.txtNombre.Text = String.Empty;
            this.lstPersonas.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String nombre = default;
            String apellido = default;

            if(this.lstPersonas.SelectedIndex == -1 && !String.IsNullOrWhiteSpace(this.txtApellido.Text) && !String.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                if (MessageBox.Show($"Seguro que desea cargar al usuario: {nombre} {apellido}?","Confirme",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if(this.gestor.Guardar(new Persona(nombre , apellido)))
                    {
                        this.Leer_Click(sender , e);
                        MessageBox.Show("El cliente fue cargado con exito", "All good", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo con la carga del cliente, reintente", "Non good", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            Persona auxP;
            if (this.lstPersonas.SelectedIndex > -1)
            {
                auxP = (Persona)this.lstPersonas.SelectedItem;
                if(MessageBox.Show($"Seguro que desea eliminar el usuario: {auxP.Nombre} {auxP.Apellido}?","Confirme",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (this.gestor.Borrar(auxP.ID))
                    {
                        this.Leer_Click(sender,e);
                        MessageBox.Show("Usuario dado de baja!", "Exito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Algo fallo, reintente!", "Cagamo`", MessageBoxButtons.OK);
                    }
                }                
            }           
            else
            {
                MessageBox.Show("Seleccione un elemento para ser eliminado!", "Preste atencion", MessageBoxButtons.OK);
            }
        }
    }
}
