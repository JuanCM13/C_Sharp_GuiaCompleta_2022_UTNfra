
namespace EstoNoEsSteam_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataGrid_Juegos = new System.Windows.Forms.DataGridView();
            this.Btn_ModificarJuego = new System.Windows.Forms.Button();
            this.Btn_AgregarJuego = new System.Windows.Forms.Button();
            this.Btn_EliminarJuego = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Juegos)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_Juegos
            // 
            this.DataGrid_Juegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_Juegos.Location = new System.Drawing.Point(12, 86);
            this.DataGrid_Juegos.Name = "DataGrid_Juegos";
            this.DataGrid_Juegos.RowHeadersWidth = 62;
            this.DataGrid_Juegos.RowTemplate.Height = 33;
            this.DataGrid_Juegos.Size = new System.Drawing.Size(776, 248);
            this.DataGrid_Juegos.TabIndex = 0;
            // 
            // Btn_ModificarJuego
            // 
            this.Btn_ModificarJuego.Location = new System.Drawing.Point(23, 13);
            this.Btn_ModificarJuego.Name = "Btn_ModificarJuego";
            this.Btn_ModificarJuego.Size = new System.Drawing.Size(163, 34);
            this.Btn_ModificarJuego.TabIndex = 1;
            this.Btn_ModificarJuego.Text = "Modificar Juego";
            this.Btn_ModificarJuego.UseVisualStyleBackColor = true;
            this.Btn_ModificarJuego.Click += new System.EventHandler(this.Btn_ModificarJuego_Click);
            // 
            // Btn_AgregarJuego
            // 
            this.Btn_AgregarJuego.Location = new System.Drawing.Point(306, 13);
            this.Btn_AgregarJuego.Name = "Btn_AgregarJuego";
            this.Btn_AgregarJuego.Size = new System.Drawing.Size(163, 34);
            this.Btn_AgregarJuego.TabIndex = 2;
            this.Btn_AgregarJuego.Text = "Agregar Juego";
            this.Btn_AgregarJuego.UseVisualStyleBackColor = true;
            this.Btn_AgregarJuego.Click += new System.EventHandler(this.Btn_AgregarJuego_Click);
            // 
            // Btn_EliminarJuego
            // 
            this.Btn_EliminarJuego.Location = new System.Drawing.Point(625, 13);
            this.Btn_EliminarJuego.Name = "Btn_EliminarJuego";
            this.Btn_EliminarJuego.Size = new System.Drawing.Size(163, 34);
            this.Btn_EliminarJuego.TabIndex = 3;
            this.Btn_EliminarJuego.Text = "Eliminar Juego";
            this.Btn_EliminarJuego.UseVisualStyleBackColor = true;
            this.Btn_EliminarJuego.Click += new System.EventHandler(this.Btn_EliminarJuego_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(625, 370);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(163, 34);
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_EliminarJuego);
            this.Controls.Add(this.Btn_AgregarJuego);
            this.Controls.Add(this.Btn_ModificarJuego);
            this.Controls.Add(this.DataGrid_Juegos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_Juegos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_Juegos;
        private System.Windows.Forms.Button Btn_ModificarJuego;
        private System.Windows.Forms.Button Btn_AgregarJuego;
        private System.Windows.Forms.Button Btn_EliminarJuego;
        private System.Windows.Forms.Button Btn_Salir;
    }
}

