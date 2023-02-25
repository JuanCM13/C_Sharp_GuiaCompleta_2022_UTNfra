
namespace EstoNoEsSteam_WinForm
{
    partial class FormModificacion
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
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.NUD_PrecioMod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PrecioMod)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(12, 49);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(350, 31);
            this.Txt_Nombre.TabIndex = 0;
            // 
            // Txt_Genero
            // 
            this.Txt_Genero.Location = new System.Drawing.Point(12, 156);
            this.Txt_Genero.Name = "Txt_Genero";
            this.Txt_Genero.Size = new System.Drawing.Size(350, 31);
            this.Txt_Genero.TabIndex = 1;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(12, 331);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(350, 34);
            this.Btn_Modificar.TabIndex = 2;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // NUD_PrecioMod
            // 
            this.NUD_PrecioMod.Location = new System.Drawing.Point(13, 251);
            this.NUD_PrecioMod.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUD_PrecioMod.Name = "NUD_PrecioMod";
            this.NUD_PrecioMod.Size = new System.Drawing.Size(349, 31);
            this.NUD_PrecioMod.TabIndex = 3;
            this.NUD_PrecioMod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genero";
            // 
            // FormModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_PrecioMod);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Txt_Genero);
            this.Controls.Add(this.Txt_Nombre);
            this.Name = "FormModificacion";
            this.Text = "FormModificacion";
            this.Load += new System.EventHandler(this.FormModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_PrecioMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Genero;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.NumericUpDown NUD_PrecioMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}