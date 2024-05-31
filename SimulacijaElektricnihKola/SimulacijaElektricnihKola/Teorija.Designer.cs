namespace SimulacijaElektricnihKola
{
    partial class Teorija
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
            this.tbxTeorija = new System.Windows.Forms.TextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxTeorija
            // 
            this.tbxTeorija.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTeorija.Location = new System.Drawing.Point(16, 15);
            this.tbxTeorija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTeorija.Multiline = true;
            this.tbxTeorija.Name = "tbxTeorija";
            this.tbxTeorija.ReadOnly = true;
            this.tbxTeorija.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTeorija.Size = new System.Drawing.Size(935, 457);
            this.tbxTeorija.TabIndex = 0;
            this.tbxTeorija.TextChanged += new System.EventHandler(this.tbxTeorija_TextChanged);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(984, 15);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(67, 64);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click_1);
            // 
            // Teorija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.tbxTeorija);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Teorija";
            this.Text = "Teorija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teorija_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTeorija;
        private System.Windows.Forms.Button btnNazad;
    }
}