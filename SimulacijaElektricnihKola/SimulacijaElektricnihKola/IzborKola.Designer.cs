namespace SimulacijaElektricnihKola
{
    partial class IzborKola
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
			this.btnIzaberiteKolo = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pbxKolo1 = new System.Windows.Forms.PictureBox();
			this.pbxKolo2 = new System.Windows.Forms.PictureBox();
			this.pbxKolo3 = new System.Windows.Forms.PictureBox();
			this.pbxKolo4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo4)).BeginInit();
			this.SuspendLayout();
			// 
			// btnIzaberiteKolo
			// 
			this.btnIzaberiteKolo.Location = new System.Drawing.Point(288, 429);
			this.btnIzaberiteKolo.Margin = new System.Windows.Forms.Padding(2);
			this.btnIzaberiteKolo.Name = "btnIzaberiteKolo";
			this.btnIzaberiteKolo.Size = new System.Drawing.Size(127, 32);
			this.btnIzaberiteKolo.TabIndex = 4;
			this.btnIzaberiteKolo.Text = "Izaberite svoje kolo";
			this.btnIzaberiteKolo.UseVisualStyleBackColor = true;
			this.btnIzaberiteKolo.Click += new System.EventHandler(this.button5_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pbxKolo1
			// 
			this.pbxKolo1.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.RednoKolo;
			this.pbxKolo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbxKolo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbxKolo1.Location = new System.Drawing.Point(86, 32);
			this.pbxKolo1.Margin = new System.Windows.Forms.Padding(2);
			this.pbxKolo1.Name = "pbxKolo1";
			this.pbxKolo1.Size = new System.Drawing.Size(225, 162);
			this.pbxKolo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxKolo1.TabIndex = 5;
			this.pbxKolo1.TabStop = false;
			this.pbxKolo1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pbxKolo2
			// 
			this.pbxKolo2.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.ParalelnoKolo;
			this.pbxKolo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbxKolo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbxKolo2.Location = new System.Drawing.Point(398, 32);
			this.pbxKolo2.Margin = new System.Windows.Forms.Padding(2);
			this.pbxKolo2.Name = "pbxKolo2";
			this.pbxKolo2.Size = new System.Drawing.Size(225, 162);
			this.pbxKolo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxKolo2.TabIndex = 6;
			this.pbxKolo2.TabStop = false;
			this.pbxKolo2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pbxKolo3
			// 
			this.pbxKolo3.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.PrikazKola;
			this.pbxKolo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbxKolo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbxKolo3.Location = new System.Drawing.Point(86, 246);
			this.pbxKolo3.Margin = new System.Windows.Forms.Padding(2);
			this.pbxKolo3.Name = "pbxKolo3";
			this.pbxKolo3.Size = new System.Drawing.Size(225, 162);
			this.pbxKolo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxKolo3.TabIndex = 7;
			this.pbxKolo3.TabStop = false;
			this.pbxKolo3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pbxKolo4
			// 
			this.pbxKolo4.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.Kolo4;
			this.pbxKolo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pbxKolo4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbxKolo4.Location = new System.Drawing.Point(398, 246);
			this.pbxKolo4.Margin = new System.Windows.Forms.Padding(2);
			this.pbxKolo4.Name = "pbxKolo4";
			this.pbxKolo4.Size = new System.Drawing.Size(225, 162);
			this.pbxKolo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxKolo4.TabIndex = 8;
			this.pbxKolo4.TabStop = false;
			this.pbxKolo4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// IzborKola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 470);
			this.Controls.Add(this.btnIzaberiteKolo);
			this.Controls.Add(this.pbxKolo4);
			this.Controls.Add(this.pbxKolo3);
			this.Controls.Add(this.pbxKolo2);
			this.Controls.Add(this.pbxKolo1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "IzborKola";
			this.Text = "IzborKola";
			this.MaximizedBoundsChanged += new System.EventHandler(this.IzborKola_Resize);
			this.Load += new System.EventHandler(this.IzborKola_Load);
			this.Resize += new System.EventHandler(this.IzborKola_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxKolo4)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnIzaberiteKolo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pbxKolo1;
        private System.Windows.Forms.PictureBox pbxKolo2;
        private System.Windows.Forms.PictureBox pbxKolo3;
        private System.Windows.Forms.PictureBox pbxKolo4;
    }
}