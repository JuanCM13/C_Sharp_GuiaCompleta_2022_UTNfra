
namespace ejer52
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
            this.Txb_Kilometros = new System.Windows.Forms.TextBox();
            this.Txb_Litros = new System.Windows.Forms.TextBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Rbt_Result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Txb_Kilometros
            // 
            this.Txb_Kilometros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txb_Kilometros.Location = new System.Drawing.Point(26, 68);
            this.Txb_Kilometros.Name = "Txb_Kilometros";
            this.Txb_Kilometros.Size = new System.Drawing.Size(273, 39);
            this.Txb_Kilometros.TabIndex = 0;
            // 
            // Txb_Litros
            // 
            this.Txb_Litros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txb_Litros.Location = new System.Drawing.Point(26, 170);
            this.Txb_Litros.Name = "Txb_Litros";
            this.Txb_Litros.Size = new System.Drawing.Size(273, 39);
            this.Txb_Litros.TabIndex = 1;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Location = new System.Drawing.Point(26, 252);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(273, 46);
            this.Btn_Calcular.TabIndex = 2;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.Btn_Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kilometros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Litros";
            // 
            // Rbt_Result
            // 
            this.Rbt_Result.Location = new System.Drawing.Point(345, 26);
            this.Rbt_Result.Name = "Rbt_Result";
            this.Rbt_Result.Size = new System.Drawing.Size(300, 272);
            this.Rbt_Result.TabIndex = 5;
            this.Rbt_Result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 329);
            this.Controls.Add(this.Rbt_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Calcular);
            this.Controls.Add(this.Txb_Litros);
            this.Controls.Add(this.Txb_Kilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_Kilometros;
        private System.Windows.Forms.TextBox Txb_Litros;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Rbt_Result;
    }
}

