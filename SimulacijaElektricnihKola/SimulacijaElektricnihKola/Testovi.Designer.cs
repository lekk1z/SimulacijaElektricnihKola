﻿namespace SimulacijaElektricnihKola
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
			this.btnTest2 = new System.Windows.Forms.Button();
			this.btnTest4 = new System.Windows.Forms.Button();
			this.tbxOpisZadataka = new System.Windows.Forms.TextBox();
			this.btnNazad = new System.Windows.Forms.Button();
			this.btnTest3 = new System.Windows.Forms.Button();
			this.btnTest1 = new System.Windows.Forms.Button();
			this.lblprvi = new System.Windows.Forms.Label();
			this.lbldrugi = new System.Windows.Forms.Label();
			this.lbltreci = new System.Windows.Forms.Label();
			this.lblcetvrti = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnTest2
			// 
			this.btnTest2.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.RednoKolo;
			this.btnTest2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTest2.Location = new System.Drawing.Point(443, 72);
			this.btnTest2.Name = "btnTest2";
			this.btnTest2.Size = new System.Drawing.Size(223, 137);
			this.btnTest2.TabIndex = 1;
			this.btnTest2.UseVisualStyleBackColor = true;
			// 
			// btnTest4
			// 
			this.btnTest4.Location = new System.Drawing.Point(443, 247);
			this.btnTest4.Name = "btnTest4";
			this.btnTest4.Size = new System.Drawing.Size(223, 137);
			this.btnTest4.TabIndex = 3;
			this.btnTest4.UseVisualStyleBackColor = true;
			// 
			// tbxOpisZadataka
			// 
			this.tbxOpisZadataka.Location = new System.Drawing.Point(131, 72);
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
			// btnTest3
			// 
			this.btnTest3.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.PrikazKola;
			this.btnTest3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTest3.Location = new System.Drawing.Point(131, 247);
			this.btnTest3.Name = "btnTest3";
			this.btnTest3.Size = new System.Drawing.Size(223, 137);
			this.btnTest3.TabIndex = 2;
			this.btnTest3.UseVisualStyleBackColor = true;
			this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
			// 
			// btnTest1
			// 
			this.btnTest1.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.ParalelnoKolo;
			this.btnTest1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTest1.Location = new System.Drawing.Point(131, 72);
			this.btnTest1.Name = "btnTest1";
			this.btnTest1.Size = new System.Drawing.Size(223, 137);
			this.btnTest1.TabIndex = 0;
			this.btnTest1.UseVisualStyleBackColor = true;
			this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
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
			this.lbltreci.Size = new System.Drawing.Size(46, 13);
			this.lbltreci.TabIndex = 8;
			this.lbltreci.Text = "Kolo 3 - ";
			this.lbltreci.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblcetvrti
			// 
			this.lblcetvrti.AutoSize = true;
			this.lblcetvrti.Location = new System.Drawing.Point(456, 387);
			this.lblcetvrti.Name = "lblcetvrti";
			this.lblcetvrti.Size = new System.Drawing.Size(43, 13);
			this.lblcetvrti.TabIndex = 9;
			this.lblcetvrti.Text = "Kolo 4 -";
			this.lblcetvrti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Testovi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 461);
			this.Controls.Add(this.lblcetvrti);
			this.Controls.Add(this.lbltreci);
			this.Controls.Add(this.lbldrugi);
			this.Controls.Add(this.lblprvi);
			this.Controls.Add(this.btnNazad);
			this.Controls.Add(this.tbxOpisZadataka);
			this.Controls.Add(this.btnTest4);
			this.Controls.Add(this.btnTest3);
			this.Controls.Add(this.btnTest2);
			this.Controls.Add(this.btnTest1);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Testovi";
			this.Text = "Testovi";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Testovi_FormClosed);
			this.Load += new System.EventHandler(this.Testovi_Load);
			this.ResizeEnd += new System.EventHandler(this.Testovi_ResizeEnd);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.Button btnTest4;
        private System.Windows.Forms.TextBox tbxOpisZadataka;
        private System.Windows.Forms.Button btnNazad;
		private System.Windows.Forms.Label lblprvi;
		private System.Windows.Forms.Label lbldrugi;
		private System.Windows.Forms.Label lbltreci;
		private System.Windows.Forms.Label lblcetvrti;
	}
}