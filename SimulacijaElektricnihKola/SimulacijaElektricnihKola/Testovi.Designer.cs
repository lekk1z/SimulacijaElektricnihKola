namespace SimulacijaElektricnihKola
{
    partial class Testovi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxOpisZadataka = new System.Windows.Forms.TextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.lblprvi = new System.Windows.Forms.Label();
            this.lbldrugi = new System.Windows.Forms.Label();
            this.lbltreci = new System.Windows.Forms.Label();
            this.lblcetvrti = new System.Windows.Forms.Label();
            this.pbxKolo4 = new System.Windows.Forms.PictureBox();
            this.pbxKolo3 = new System.Windows.Forms.PictureBox();
            this.pbxKolo2 = new System.Windows.Forms.PictureBox();
            this.pbxKolo1 = new System.Windows.Forms.PictureBox();
            this.btnJednosmernaStruja = new System.Windows.Forms.Button();
            this.btnNaizmenicnaStruja = new System.Windows.Forms.Button();
            this.btnParalelnoRLC = new System.Windows.Forms.Button();
            this.btnRednoRLC = new System.Windows.Forms.Button();
            this.rtbObjasnjenjeResenja = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxOpisZadataka
            // 
            this.tbxOpisZadataka.Location = new System.Drawing.Point(131, 69);
            this.tbxOpisZadataka.Multiline = true;
            this.tbxOpisZadataka.Name = "tbxOpisZadataka";
            this.tbxOpisZadataka.ReadOnly = true;
            this.tbxOpisZadataka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOpisZadataka.Size = new System.Drawing.Size(535, 312);
            this.tbxOpisZadataka.TabIndex = 4;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(738, 12);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(50, 52);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // lblprvi
            // 
            this.lblprvi.AutoSize = true;
            this.lblprvi.Location = new System.Drawing.Point(164, 216);
            this.lblprvi.Name = "lblprvi";
            this.lblprvi.Size = new System.Drawing.Size(125, 13);
            this.lblprvi.TabIndex = 6;
            this.lblprvi.Text = "Kolo 1 - Redno RLC kolo";
            this.lblprvi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldrugi
            // 
            this.lbldrugi.AutoSize = true;
            this.lbldrugi.Location = new System.Drawing.Point(470, 216);
            this.lbldrugi.Name = "lbldrugi";
            this.lbldrugi.Size = new System.Drawing.Size(137, 13);
            this.lbldrugi.TabIndex = 7;
            this.lbldrugi.Text = "Kolo 2 - Paralelno RLC kolo";
            this.lbldrugi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltreci
            // 
            this.lbltreci.AutoSize = true;
            this.lbltreci.Location = new System.Drawing.Point(164, 387);
            this.lbltreci.Name = "lbltreci";
            this.lbltreci.Size = new System.Drawing.Size(195, 13);
            this.lbltreci.TabIndex = 8;
            this.lbltreci.Text = "Kolo 3 - složeno kolo naizmenične struje";
            this.lbltreci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcetvrti
            // 
            this.lblcetvrti.AutoSize = true;
            this.lblcetvrti.Location = new System.Drawing.Point(456, 387);
            this.lblcetvrti.Name = "lblcetvrti";
            this.lblcetvrti.Size = new System.Drawing.Size(157, 13);
            this.lblcetvrti.TabIndex = 9;
            this.lblcetvrti.Text = "Kolo 4 - kolo jednosmerne struje";
            this.lblcetvrti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxKolo4
            // 
            this.pbxKolo4.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.Kolo4;
            this.pbxKolo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxKolo4.Location = new System.Drawing.Point(708, 331);
            this.pbxKolo4.Name = "pbxKolo4";
            this.pbxKolo4.Size = new System.Drawing.Size(100, 50);
            this.pbxKolo4.TabIndex = 13;
            this.pbxKolo4.TabStop = false;
            // 
            // pbxKolo3
            // 
            this.pbxKolo3.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.PrikazKola;
            this.pbxKolo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxKolo3.Location = new System.Drawing.Point(708, 275);
            this.pbxKolo3.Name = "pbxKolo3";
            this.pbxKolo3.Size = new System.Drawing.Size(100, 50);
            this.pbxKolo3.TabIndex = 12;
            this.pbxKolo3.TabStop = false;
            // 
            // pbxKolo2
            // 
            this.pbxKolo2.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.ParalelnoKolo;
            this.pbxKolo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxKolo2.Location = new System.Drawing.Point(708, 219);
            this.pbxKolo2.Name = "pbxKolo2";
            this.pbxKolo2.Size = new System.Drawing.Size(100, 50);
            this.pbxKolo2.TabIndex = 11;
            this.pbxKolo2.TabStop = false;
            // 
            // pbxKolo1
            // 
            this.pbxKolo1.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.RednoKolo;
            this.pbxKolo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxKolo1.Location = new System.Drawing.Point(708, 163);
            this.pbxKolo1.Name = "pbxKolo1";
            this.pbxKolo1.Size = new System.Drawing.Size(100, 50);
            this.pbxKolo1.TabIndex = 10;
            this.pbxKolo1.TabStop = false;
            // 
            // btnJednosmernaStruja
            // 
            this.btnJednosmernaStruja.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.Kolo4;
            this.btnJednosmernaStruja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJednosmernaStruja.Location = new System.Drawing.Point(443, 247);
            this.btnJednosmernaStruja.Name = "btnJednosmernaStruja";
            this.btnJednosmernaStruja.Size = new System.Drawing.Size(223, 137);
            this.btnJednosmernaStruja.TabIndex = 3;
            this.btnJednosmernaStruja.UseVisualStyleBackColor = true;
            this.btnJednosmernaStruja.Click += new System.EventHandler(this.btnTest4_Click);
            // 
            // btnNaizmenicnaStruja
            // 
            this.btnNaizmenicnaStruja.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.PrikazKola;
            this.btnNaizmenicnaStruja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNaizmenicnaStruja.Location = new System.Drawing.Point(131, 247);
            this.btnNaizmenicnaStruja.Name = "btnNaizmenicnaStruja";
            this.btnNaizmenicnaStruja.Size = new System.Drawing.Size(223, 137);
            this.btnNaizmenicnaStruja.TabIndex = 2;
            this.btnNaizmenicnaStruja.UseVisualStyleBackColor = true;
            this.btnNaizmenicnaStruja.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // btnParalelnoRLC
            // 
            this.btnParalelnoRLC.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.ParalelnoKolo;
            this.btnParalelnoRLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnParalelnoRLC.Location = new System.Drawing.Point(443, 72);
            this.btnParalelnoRLC.Name = "btnParalelnoRLC";
            this.btnParalelnoRLC.Size = new System.Drawing.Size(223, 137);
            this.btnParalelnoRLC.TabIndex = 1;
            this.btnParalelnoRLC.UseVisualStyleBackColor = true;
            this.btnParalelnoRLC.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnRednoRLC
            // 
            this.btnRednoRLC.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.RednoKolo;
            this.btnRednoRLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRednoRLC.Location = new System.Drawing.Point(131, 72);
            this.btnRednoRLC.Name = "btnRednoRLC";
            this.btnRednoRLC.Size = new System.Drawing.Size(223, 137);
            this.btnRednoRLC.TabIndex = 0;
            this.btnRednoRLC.UseVisualStyleBackColor = true;
            this.btnRednoRLC.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // rtbObjasnjenjeResenja
            // 
            this.rtbObjasnjenjeResenja.Location = new System.Drawing.Point(74, 29);
            this.rtbObjasnjenjeResenja.Margin = new System.Windows.Forms.Padding(2);
            this.rtbObjasnjenjeResenja.Name = "rtbObjasnjenjeResenja";
            this.rtbObjasnjenjeResenja.Size = new System.Drawing.Size(629, 396);
            this.rtbObjasnjenjeResenja.TabIndex = 14;
            this.rtbObjasnjenjeResenja.Text = "";
            // 
            // Testovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.wallpaperflare_com_wallpaper__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.rtbObjasnjenjeResenja);
            this.Controls.Add(this.pbxKolo4);
            this.Controls.Add(this.pbxKolo3);
            this.Controls.Add(this.pbxKolo2);
            this.Controls.Add(this.pbxKolo1);
            this.Controls.Add(this.lblcetvrti);
            this.Controls.Add(this.lbltreci);
            this.Controls.Add(this.lbldrugi);
            this.Controls.Add(this.lblprvi);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.tbxOpisZadataka);
            this.Controls.Add(this.btnJednosmernaStruja);
            this.Controls.Add(this.btnNaizmenicnaStruja);
            this.Controls.Add(this.btnParalelnoRLC);
            this.Controls.Add(this.btnRednoRLC);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(800, 497);
            this.Name = "Testovi";
            this.Text = "Testovi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Testovi_FormClosed);
            this.Load += new System.EventHandler(this.Testovi_Load);
            this.ResizeEnd += new System.EventHandler(this.Testovi_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKolo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRednoRLC;
        private System.Windows.Forms.Button btnParalelnoRLC;
        private System.Windows.Forms.Button btnNaizmenicnaStruja;
        private System.Windows.Forms.Button btnJednosmernaStruja;
        private System.Windows.Forms.TextBox tbxOpisZadataka;
        private System.Windows.Forms.Button btnNazad;
		private System.Windows.Forms.Label lblprvi;
		private System.Windows.Forms.Label lbldrugi;
		private System.Windows.Forms.Label lbltreci;
		private System.Windows.Forms.Label lblcetvrti;
		private System.Windows.Forms.PictureBox pbxKolo1;
		private System.Windows.Forms.PictureBox pbxKolo2;
		private System.Windows.Forms.PictureBox pbxKolo3;
		private System.Windows.Forms.PictureBox pbxKolo4;
        private System.Windows.Forms.RichTextBox rtbObjasnjenjeResenja;
    }
}