namespace Estructura
{
    partial class Pilas1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pilas1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ListaPilas = new System.Windows.Forms.ListBox();
            this.ListaColas = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ListaColas);
            this.panel1.Controls.Add(this.ListaPilas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 294);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "EJERCICIO 1 AGREGAMOS A LA PILA";
            // 
            // ListaPilas
            // 
            this.ListaPilas.FormattingEnabled = true;
            this.ListaPilas.ItemHeight = 15;
            this.ListaPilas.Items.AddRange(new object[] {
            "ListaPilas"});
            this.ListaPilas.Location = new System.Drawing.Point(15, 84);
            this.ListaPilas.Name = "ListaPilas";
            this.ListaPilas.Size = new System.Drawing.Size(185, 124);
            this.ListaPilas.TabIndex = 1;
            // 
            // ListaColas
            // 
            this.ListaColas.FormattingEnabled = true;
            this.ListaColas.ItemHeight = 15;
            this.ListaColas.Items.AddRange(new object[] {
            "ListaColas"});
            this.ListaColas.Location = new System.Drawing.Point(278, 84);
            this.ListaColas.Name = "ListaColas";
            this.ListaColas.Size = new System.Drawing.Size(185, 124);
            this.ListaColas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "INSERTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pilas1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.panel1);
            this.Name = "Pilas1";
            this.Text = "Pilas1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private ListBox ListaColas;
        private ListBox ListaPilas;
        private Label label1;
    }
}