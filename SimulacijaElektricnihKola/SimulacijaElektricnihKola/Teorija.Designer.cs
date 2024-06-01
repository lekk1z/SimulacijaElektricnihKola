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
			this.tbxTeorija.Location = new System.Drawing.Point(-4, 0);
			this.tbxTeorija.Multiline = true;
			this.tbxTeorija.Name = "tbxTeorija";
			this.tbxTeorija.ReadOnly = true;
			this.tbxTeorija.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxTeorija.Size = new System.Drawing.Size(736, 404);
			this.tbxTeorija.TabIndex = 0;
			this.tbxTeorija.TextChanged += new System.EventHandler(this.tbxTeorija_TextChanged);
			// 
			// btnNazad
			// 
			this.btnNazad.Location = new System.Drawing.Point(738, 12);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(50, 52);
			this.btnNazad.TabIndex = 1;
			this.btnNazad.Text = "<";
			this.btnNazad.UseVisualStyleBackColor = true;
			this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click_1);
			// 
			// Teorija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnNazad);
			this.Controls.Add(this.tbxTeorija);
			this.Name = "Teorija";
			this.Text = "Teorija";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teorija_FormClosed);
			this.Load += new System.EventHandler(this.Teorija_Load);
			this.ResizeEnd += new System.EventHandler(this.Teorija_ResizeEnd);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTeorija;
        private System.Windows.Forms.Button btnNazad;
    }
}