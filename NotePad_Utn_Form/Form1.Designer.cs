
namespace NotePad_Utn_Form
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
            this.Rtb_NotePad = new System.Windows.Forms.RichTextBox();
            this.Menu_Archivo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_CantCaracteres = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rtb_NotePad
            // 
            this.Rtb_NotePad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_NotePad.Location = new System.Drawing.Point(0, 32);
            this.Rtb_NotePad.Name = "Rtb_NotePad";
            this.Rtb_NotePad.Size = new System.Drawing.Size(1095, 540);
            this.Rtb_NotePad.TabIndex = 0;
            this.Rtb_NotePad.Text = "";
            // 
            // Menu_Archivo
            // 
            this.Menu_Archivo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_Archivo.Location = new System.Drawing.Point(0, 0);
            this.Menu_Archivo.Name = "Menu_Archivo";
            this.Menu_Archivo.Size = new System.Drawing.Size(1095, 32);
            this.Menu_Archivo.TabIndex = 3;
            this.Menu_Archivo.Text = "Archivo";
            this.Menu_Archivo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_CantCaracteres});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusStrip_CantCaracteres
            // 
            this.StatusStrip_CantCaracteres.Name = "StatusStrip_CantCaracteres";
            this.StatusStrip_CantCaracteres.Size = new System.Drawing.Size(179, 25);
            this.StatusStrip_CantCaracteres.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rtb_NotePad);
            this.Controls.Add(this.Menu_Archivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu_Archivo;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtb_NotePad;
        private System.Windows.Forms.MenuStrip Menu_Archivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_CantCaracteres;
    }
}

