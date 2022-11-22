namespace Estructura
{
    partial class Colas1_2_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colas1_2_3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreNodo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txtNombreNodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEncolar);
            this.panel1.Controls.Add(this.btnDesencolar);
            this.panel1.Controls.Add(this.lstCola);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 439);
            this.panel1.TabIndex = 0;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 15;
            this.lstCola.Location = new System.Drawing.Point(27, 28);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(259, 289);
            this.lstCola.TabIndex = 0;
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.Location = new System.Drawing.Point(42, 346);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(75, 23);
            this.btnDesencolar.TabIndex = 1;
            this.btnDesencolar.Text = "desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = true;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnEncolar
            // 
            this.btnEncolar.Location = new System.Drawing.Point(428, 229);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(75, 23);
            this.btnEncolar.TabIndex = 2;
            this.btnEncolar.Text = "ENCOLAR";
            this.btnEncolar.UseVisualStyleBackColor = true;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            // 
            // txtNombreNodo
            // 
            this.txtNombreNodo.Location = new System.Drawing.Point(399, 105);
            this.txtNombreNodo.Name = "txtNombreNodo";
            this.txtNombreNodo.Size = new System.Drawing.Size(197, 23);
            this.txtNombreNodo.TabIndex = 4;
            // 
            // Colas1_2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 439);
            this.Controls.Add(this.panel1);
            this.Name = "Colas1_2_3";
            this.Text = "Colas1_2_3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtNombreNodo;
        private Label label1;
        private Button btnEncolar;
        private Button btnDesencolar;
        private ListBox lstCola;
    }
}