
namespace EstoNoEsSteam_WinForm
{
    partial class FormAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Genero = new System.Windows.Forms.TextBox();
            this.NUD_Precio = new System.Windows.Forms.NumericUpDown();
            this.Cmb_Usuario = new System.Windows.Forms.ComboBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(38, 73);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(289, 31);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // Txt_Genero
            // 
            this.Txt_Genero.Location = new System.Drawing.Point(38, 205);
            this.Txt_Genero.Name = "Txt_Genero";
            this.Txt_Genero.Size = new System.Drawing.Size(289, 31);
            this.Txt_Genero.TabIndex = 1;
            // 
            // NUD_Precio
            // 
            this.NUD_Precio.Location = new System.Drawing.Point(38, 342);
            this.NUD_Precio.Name = "NUD_Precio";
            this.NUD_Precio.Size = new System.Drawing.Size(289, 31);
            this.NUD_Precio.TabIndex = 2;
            // 
            // Cmb_Usuario
            // 
            this.Cmb_Usuario.FormattingEnabled = true;
            this.Cmb_Usuario.Location = new System.Drawing.Point(38, 473);
            this.Cmb_Usuario.Name = "Cmb_Usuario";
            this.Cmb_Usuario.Size = new System.Drawing.Size(289, 33);
            this.Cmb_Usuario.TabIndex = 3;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(38, 558);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(289, 43);
            this.Btn_Guardar.TabIndex = 4;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "GENERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "USUARIO";
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 629);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Cmb_Usuario);
            this.Controls.Add(this.NUD_Precio);
            this.Controls.Add(this.Txt_Genero);
            this.Controls.Add(this.Txt_Nombre);
            this.Name = "FormAlta";
            this.Text = "FormAlta";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Precio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Genero;
        private System.Windows.Forms.NumericUpDown NUD_Precio;
        private System.Windows.Forms.ComboBox Cmb_Usuario;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}