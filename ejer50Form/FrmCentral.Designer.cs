
namespace ejer50Form
{
    partial class FrmCentral
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
            this.Btn_GenerarLlamada = new System.Windows.Forms.Button();
            this.Btn_FacLocal = new System.Windows.Forms.Button();
            this.Btn_FacProvincial = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_FactTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_GenerarLlamada
            // 
            this.Btn_GenerarLlamada.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_GenerarLlamada.Location = new System.Drawing.Point(13, 13);
            this.Btn_GenerarLlamada.Name = "Btn_GenerarLlamada";
            this.Btn_GenerarLlamada.Size = new System.Drawing.Size(401, 95);
            this.Btn_GenerarLlamada.TabIndex = 0;
            this.Btn_GenerarLlamada.Text = "Generar Llamada";
            this.Btn_GenerarLlamada.UseVisualStyleBackColor = true;
            this.Btn_GenerarLlamada.Click += new System.EventHandler(this.Btn_GenerarLlamada_Click);
            // 
            // Btn_FacLocal
            // 
            this.Btn_FacLocal.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_FacLocal.Location = new System.Drawing.Point(13, 243);
            this.Btn_FacLocal.Name = "Btn_FacLocal";
            this.Btn_FacLocal.Size = new System.Drawing.Size(401, 95);
            this.Btn_FacLocal.TabIndex = 1;
            this.Btn_FacLocal.Text = "Facturacion Local";
            this.Btn_FacLocal.UseVisualStyleBackColor = true;
            this.Btn_FacLocal.Click += new System.EventHandler(this.Btn_FacLocal_Click);
            // 
            // Btn_FacProvincial
            // 
            this.Btn_FacProvincial.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_FacProvincial.Location = new System.Drawing.Point(13, 359);
            this.Btn_FacProvincial.Name = "Btn_FacProvincial";
            this.Btn_FacProvincial.Size = new System.Drawing.Size(401, 95);
            this.Btn_FacProvincial.TabIndex = 2;
            this.Btn_FacProvincial.Text = "Facturacion Provincial";
            this.Btn_FacProvincial.UseVisualStyleBackColor = true;
            this.Btn_FacProvincial.Click += new System.EventHandler(this.Btn_FacProvincial_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Salir.Location = new System.Drawing.Point(13, 474);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(401, 95);
            this.Btn_Salir.TabIndex = 3;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_FactTotal
            // 
            this.Btn_FactTotal.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_FactTotal.Location = new System.Drawing.Point(13, 130);
            this.Btn_FactTotal.Name = "Btn_FactTotal";
            this.Btn_FactTotal.Size = new System.Drawing.Size(401, 95);
            this.Btn_FactTotal.TabIndex = 4;
            this.Btn_FactTotal.Text = "Facturacion Total";
            this.Btn_FactTotal.UseVisualStyleBackColor = true;
            this.Btn_FactTotal.Click += new System.EventHandler(this.Btn_FactTotal_Click);
            // 
            // FrmCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 582);
            this.Controls.Add(this.Btn_FactTotal);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_FacProvincial);
            this.Controls.Add(this.Btn_FacLocal);
            this.Controls.Add(this.Btn_GenerarLlamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCentral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCentral_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_GenerarLlamada;
        private System.Windows.Forms.Button Btn_FacLocal;
        private System.Windows.Forms.Button Btn_FacProvincial;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_FactTotal;
    }
}

