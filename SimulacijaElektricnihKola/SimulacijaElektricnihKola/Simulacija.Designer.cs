namespace SimulacijaElektricnihKola
{
    partial class Simulacija
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
			this.btnNazad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNazad
			// 
			this.btnNazad.Location = new System.Drawing.Point(696, 12);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(50, 52);
			this.btnNazad.TabIndex = 2;
			this.btnNazad.Text = "<";
			this.btnNazad.UseVisualStyleBackColor = true;
			this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
			// 
			// Simulacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.btnNazad);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Simulacija";
			this.Text = "Simulacija";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulacija_FormClosed);
			this.Load += new System.EventHandler(this.Simulacija_Load);
			this.ResizeEnd += new System.EventHandler(this.Simulacija_ResizeEnd);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazad;
    }
}