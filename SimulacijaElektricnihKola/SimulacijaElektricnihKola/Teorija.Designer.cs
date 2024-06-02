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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teorija));
			this.btnNazad = new System.Windows.Forms.Button();
			this.rtbTeorija = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
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
			// rtbTeorija
			// 
			this.rtbTeorija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
			this.rtbTeorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbTeorija.Location = new System.Drawing.Point(78, 29);
			this.rtbTeorija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rtbTeorija.Name = "rtbTeorija";
			this.rtbTeorija.ReadOnly = true;
			this.rtbTeorija.Size = new System.Drawing.Size(590, 379);
			this.rtbTeorija.TabIndex = 2;
			this.rtbTeorija.Text = resources.GetString("rtbTeorija.Text");
			// 
			// Teorija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(230)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 461);
			this.Controls.Add(this.rtbTeorija);
			this.Controls.Add(this.btnNazad);
			this.MinimumSize = new System.Drawing.Size(800, 497);
			this.Name = "Teorija";
			this.Text = "Teorija";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teorija_FormClosed);
			this.Load += new System.EventHandler(this.Teorija_Load);
			this.ResizeEnd += new System.EventHandler(this.Teorija_ResizeEnd);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.RichTextBox rtbTeorija;
    }
}