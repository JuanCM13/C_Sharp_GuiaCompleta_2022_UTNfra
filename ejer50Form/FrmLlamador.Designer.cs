
namespace ejer50Form
{
    partial class FrmLlamador
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
            this.Tbt_NroDestino = new System.Windows.Forms.TextBox();
            this.Gp_Box_Panel = new System.Windows.Forms.GroupBox();
            this.Btn_Asterisco = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Btn_Numeral = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_Llamar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Tbt_NroOrigen = new System.Windows.Forms.TextBox();
            this.Cmb_Franja = new System.Windows.Forms.ComboBox();
            this.Gp_Box_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbt_NroDestino
            // 
            this.Tbt_NroDestino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbt_NroDestino.Location = new System.Drawing.Point(12, 34);
            this.Tbt_NroDestino.Name = "Tbt_NroDestino";
            this.Tbt_NroDestino.Size = new System.Drawing.Size(537, 50);
            this.Tbt_NroDestino.TabIndex = 0;
            this.Tbt_NroDestino.Click += new System.EventHandler(this.Tbt_NroDestino_Click);
            this.Tbt_NroDestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbt_NroDestino_KeyPress);
            this.Tbt_NroDestino.Leave += new System.EventHandler(this.Tbt_NroDestino_Leave);
            // 
            // Gp_Box_Panel
            // 
            this.Gp_Box_Panel.Controls.Add(this.Btn_Asterisco);
            this.Gp_Box_Panel.Controls.Add(this.Btn_0);
            this.Gp_Box_Panel.Controls.Add(this.Btn_Numeral);
            this.Gp_Box_Panel.Controls.Add(this.Btn_7);
            this.Gp_Box_Panel.Controls.Add(this.Btn_9);
            this.Gp_Box_Panel.Controls.Add(this.Btn_8);
            this.Gp_Box_Panel.Controls.Add(this.Btn_4);
            this.Gp_Box_Panel.Controls.Add(this.Btn_6);
            this.Gp_Box_Panel.Controls.Add(this.Btn_5);
            this.Gp_Box_Panel.Controls.Add(this.Btn_2);
            this.Gp_Box_Panel.Controls.Add(this.Btn_3);
            this.Gp_Box_Panel.Controls.Add(this.Btn_1);
            this.Gp_Box_Panel.Location = new System.Drawing.Point(13, 133);
            this.Gp_Box_Panel.Name = "Gp_Box_Panel";
            this.Gp_Box_Panel.Size = new System.Drawing.Size(248, 406);
            this.Gp_Box_Panel.TabIndex = 1;
            this.Gp_Box_Panel.TabStop = false;
            this.Gp_Box_Panel.Text = "Panel";
            // 
            // Btn_Asterisco
            // 
            this.Btn_Asterisco.BackColor = System.Drawing.Color.Silver;
            this.Btn_Asterisco.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Asterisco.Location = new System.Drawing.Point(7, 315);
            this.Btn_Asterisco.Name = "Btn_Asterisco";
            this.Btn_Asterisco.Size = new System.Drawing.Size(65, 63);
            this.Btn_Asterisco.TabIndex = 11;
            this.Btn_Asterisco.Text = "*";
            this.Btn_Asterisco.UseVisualStyleBackColor = false;
            this.Btn_Asterisco.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.BackColor = System.Drawing.Color.Silver;
            this.Btn_0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_0.Location = new System.Drawing.Point(89, 315);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(65, 63);
            this.Btn_0.TabIndex = 10;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = false;
            this.Btn_0.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_Numeral
            // 
            this.Btn_Numeral.BackColor = System.Drawing.Color.Silver;
            this.Btn_Numeral.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Numeral.Location = new System.Drawing.Point(172, 315);
            this.Btn_Numeral.Name = "Btn_Numeral";
            this.Btn_Numeral.Size = new System.Drawing.Size(65, 63);
            this.Btn_Numeral.TabIndex = 9;
            this.Btn_Numeral.Text = "#";
            this.Btn_Numeral.UseVisualStyleBackColor = false;
            this.Btn_Numeral.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.BackColor = System.Drawing.Color.Silver;
            this.Btn_7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_7.Location = new System.Drawing.Point(7, 231);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(65, 63);
            this.Btn_7.TabIndex = 8;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = false;
            this.Btn_7.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.BackColor = System.Drawing.Color.Silver;
            this.Btn_9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_9.Location = new System.Drawing.Point(172, 231);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(65, 63);
            this.Btn_9.TabIndex = 7;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = false;
            this.Btn_9.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.BackColor = System.Drawing.Color.Silver;
            this.Btn_8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_8.Location = new System.Drawing.Point(89, 231);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(65, 63);
            this.Btn_8.TabIndex = 6;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = false;
            this.Btn_8.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.BackColor = System.Drawing.Color.Silver;
            this.Btn_4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_4.Location = new System.Drawing.Point(7, 143);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(65, 63);
            this.Btn_4.TabIndex = 5;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = false;
            this.Btn_4.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.BackColor = System.Drawing.Color.Silver;
            this.Btn_6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_6.Location = new System.Drawing.Point(172, 143);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(65, 63);
            this.Btn_6.TabIndex = 4;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = false;
            this.Btn_6.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.BackColor = System.Drawing.Color.Silver;
            this.Btn_5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_5.Location = new System.Drawing.Point(89, 143);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(65, 63);
            this.Btn_5.TabIndex = 3;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = false;
            this.Btn_5.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.Color.Silver;
            this.Btn_2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_2.Location = new System.Drawing.Point(89, 58);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(65, 63);
            this.Btn_2.TabIndex = 2;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = false;
            this.Btn_2.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.BackColor = System.Drawing.Color.Silver;
            this.Btn_3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_3.Location = new System.Drawing.Point(172, 58);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(65, 63);
            this.Btn_3.TabIndex = 1;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = false;
            this.Btn_3.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_1
            // 
            this.Btn_1.BackColor = System.Drawing.Color.Silver;
            this.Btn_1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_1.Location = new System.Drawing.Point(7, 58);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(65, 63);
            this.Btn_1.TabIndex = 0;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = false;
            this.Btn_1.Click += new System.EventHandler(this.BtnNumeros_Click);
            // 
            // Btn_Llamar
            // 
            this.Btn_Llamar.Location = new System.Drawing.Point(298, 191);
            this.Btn_Llamar.Name = "Btn_Llamar";
            this.Btn_Llamar.Size = new System.Drawing.Size(251, 63);
            this.Btn_Llamar.TabIndex = 2;
            this.Btn_Llamar.Text = "Llamar";
            this.Btn_Llamar.UseVisualStyleBackColor = true;
            this.Btn_Llamar.Click += new System.EventHandler(this.Btn_Llamar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(298, 276);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(251, 63);
            this.Btn_Limpiar.TabIndex = 3;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(298, 448);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(251, 63);
            this.Btn_Salir.TabIndex = 4;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Tbt_NroOrigen
            // 
            this.Tbt_NroOrigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tbt_NroOrigen.Location = new System.Drawing.Point(298, 375);
            this.Tbt_NroOrigen.Name = "Tbt_NroOrigen";
            this.Tbt_NroOrigen.Size = new System.Drawing.Size(251, 39);
            this.Tbt_NroOrigen.TabIndex = 5;
            this.Tbt_NroOrigen.Click += new System.EventHandler(this.Tbt_NroOrigen_Click);
            this.Tbt_NroOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbt_NroDestino_KeyPress);
            // 
            // Cmb_Franja
            // 
            this.Cmb_Franja.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cmb_Franja.FormattingEnabled = true;
            this.Cmb_Franja.Location = new System.Drawing.Point(20, 558);
            this.Cmb_Franja.Name = "Cmb_Franja";
            this.Cmb_Franja.Size = new System.Drawing.Size(529, 46);
            this.Cmb_Franja.TabIndex = 6;
            // 
            // FrmLlamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 625);
            this.Controls.Add(this.Cmb_Franja);
            this.Controls.Add(this.Tbt_NroOrigen);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Llamar);
            this.Controls.Add(this.Gp_Box_Panel);
            this.Controls.Add(this.Tbt_NroDestino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLlamador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Llamador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLlamador_FormClosing);
            this.Load += new System.EventHandler(this.FrmLlamador_Load);
            this.Gp_Box_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbt_NroDestino;
        private System.Windows.Forms.GroupBox Gp_Box_Panel;
        private System.Windows.Forms.Button Btn_Asterisco;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button Btn_Numeral;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_Llamar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.TextBox Tbt_NroOrigen;
        private System.Windows.Forms.ComboBox Cmb_Franja;
    }
}