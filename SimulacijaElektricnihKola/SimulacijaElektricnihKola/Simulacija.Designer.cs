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
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lblOtpornik = new System.Windows.Forms.Label();
			this.tbOtpornik = new System.Windows.Forms.TrackBar();
			this.lblKalem = new System.Windows.Forms.Label();
			this.tbKalem = new System.Windows.Forms.TrackBar();
			this.lblKondenzator = new System.Windows.Forms.Label();
			this.tbKondenzator = new System.Windows.Forms.TrackBar();
			this.lblNapon = new System.Windows.Forms.Label();
			this.tbNapon = new System.Windows.Forms.TrackBar();
			this.btnIzaberiKolo = new System.Windows.Forms.Button();
			this.bttnStartStop = new System.Windows.Forms.Button();
			this.bttnReset = new System.Windows.Forms.Button();
			this.btnNazad = new System.Windows.Forms.Button();
			this.pbxDrugi = new System.Windows.Forms.PictureBox();
			this.pbxPrvi = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.tbOtpornik)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbKalem)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbKondenzator)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbNapon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDrugi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPrvi)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// lblOtpornik
			// 
			this.lblOtpornik.AutoSize = true;
			this.lblOtpornik.Location = new System.Drawing.Point(387, 295);
			this.lblOtpornik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOtpornik.Name = "lblOtpornik";
			this.lblOtpornik.Size = new System.Drawing.Size(47, 13);
			this.lblOtpornik.TabIndex = 25;
			this.lblOtpornik.Text = "Otpornik";
			// 
			// tbOtpornik
			// 
			this.tbOtpornik.Location = new System.Drawing.Point(389, 310);
			this.tbOtpornik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbOtpornik.Name = "tbOtpornik";
			this.tbOtpornik.Size = new System.Drawing.Size(210, 45);
			this.tbOtpornik.TabIndex = 24;
			// 
			// lblKalem
			// 
			this.lblKalem.AutoSize = true;
			this.lblKalem.Location = new System.Drawing.Point(387, 247);
			this.lblKalem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblKalem.Name = "lblKalem";
			this.lblKalem.Size = new System.Drawing.Size(88, 13);
			this.lblKalem.TabIndex = 23;
			this.lblKalem.Text = "Induktivni kalem*";
			// 
			// tbKalem
			// 
			this.tbKalem.Location = new System.Drawing.Point(389, 262);
			this.tbKalem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbKalem.Name = "tbKalem";
			this.tbKalem.Size = new System.Drawing.Size(210, 45);
			this.tbKalem.TabIndex = 22;
			// 
			// lblKondenzator
			// 
			this.lblKondenzator.AutoSize = true;
			this.lblKondenzator.Location = new System.Drawing.Point(387, 197);
			this.lblKondenzator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblKondenzator.Name = "lblKondenzator";
			this.lblKondenzator.Size = new System.Drawing.Size(67, 13);
			this.lblKondenzator.TabIndex = 21;
			this.lblKondenzator.Text = "Kondenzator";
			// 
			// tbKondenzator
			// 
			this.tbKondenzator.Location = new System.Drawing.Point(389, 212);
			this.tbKondenzator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbKondenzator.Name = "tbKondenzator";
			this.tbKondenzator.Size = new System.Drawing.Size(210, 45);
			this.tbKondenzator.TabIndex = 20;
			// 
			// lblNapon
			// 
			this.lblNapon.AutoSize = true;
			this.lblNapon.Location = new System.Drawing.Point(387, 120);
			this.lblNapon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNapon.Name = "lblNapon";
			this.lblNapon.Size = new System.Drawing.Size(69, 13);
			this.lblNapon.TabIndex = 19;
			this.lblNapon.Text = "Ulazni napon";
			// 
			// tbNapon
			// 
			this.tbNapon.Location = new System.Drawing.Point(389, 136);
			this.tbNapon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tbNapon.Maximum = 20;
			this.tbNapon.Name = "tbNapon";
			this.tbNapon.Size = new System.Drawing.Size(210, 45);
			this.tbNapon.TabIndex = 18;
			// 
			// btnIzaberiKolo
			// 
			this.btnIzaberiKolo.Location = new System.Drawing.Point(389, 66);
			this.btnIzaberiKolo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnIzaberiKolo.Name = "btnIzaberiKolo";
			this.btnIzaberiKolo.Size = new System.Drawing.Size(103, 19);
			this.btnIzaberiKolo.TabIndex = 28;
			this.btnIzaberiKolo.Text = "Izaberi kolo";
			this.btnIzaberiKolo.UseVisualStyleBackColor = true;
			this.btnIzaberiKolo.Click += new System.EventHandler(this.button3_Click);
			// 
			// bttnStartStop
			// 
			this.bttnStartStop.Location = new System.Drawing.Point(496, 10);
			this.bttnStartStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bttnStartStop.Name = "bttnStartStop";
			this.bttnStartStop.Size = new System.Drawing.Size(103, 41);
			this.bttnStartStop.TabIndex = 27;
			this.bttnStartStop.Text = "Start/Stop";
			this.bttnStartStop.UseVisualStyleBackColor = true;
			this.bttnStartStop.Click += new System.EventHandler(this.button2_Click);
			// 
			// bttnReset
			// 
			this.bttnReset.Location = new System.Drawing.Point(389, 10);
			this.bttnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bttnReset.Name = "bttnReset";
			this.bttnReset.Size = new System.Drawing.Size(103, 41);
			this.bttnReset.TabIndex = 26;
			this.bttnReset.Text = "Reset";
			this.bttnReset.UseVisualStyleBackColor = true;
			this.bttnReset.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnNazad
			// 
			this.btnNazad.Location = new System.Drawing.Point(530, 10);
			this.btnNazad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnNazad.Name = "btnNazad";
			this.btnNazad.Size = new System.Drawing.Size(38, 42);
			this.btnNazad.TabIndex = 2;
			this.btnNazad.Text = "<";
			this.btnNazad.UseVisualStyleBackColor = true;
			this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
			// 
			// pbxDrugi
			// 
			this.pbxDrugi.Location = new System.Drawing.Point(7, 263);
			this.pbxDrugi.Name = "pbxDrugi";
			this.pbxDrugi.Size = new System.Drawing.Size(375, 81);
			this.pbxDrugi.TabIndex = 6;
			this.pbxDrugi.TabStop = false;
			this.pbxDrugi.Click += new System.EventHandler(this.pb3_Click);
			this.pbxDrugi.Paint += new System.Windows.Forms.PaintEventHandler(this.pb3_Paint);
			// 
			// pbxPrvi
			// 
			this.pbxPrvi.Location = new System.Drawing.Point(9, 10);
			this.pbxPrvi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pbxPrvi.Name = "pbxPrvi";
			this.pbxPrvi.Size = new System.Drawing.Size(375, 248);
			this.pbxPrvi.TabIndex = 29;
			this.pbxPrvi.TabStop = false;
			// 
			// Simulacija
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 366);
			this.Controls.Add(this.pbxPrvi);
			this.Controls.Add(this.btnIzaberiKolo);
			this.Controls.Add(this.bttnStartStop);
			this.Controls.Add(this.bttnReset);
			this.Controls.Add(this.lblOtpornik);
			this.Controls.Add(this.tbOtpornik);
			this.Controls.Add(this.lblKalem);
			this.Controls.Add(this.tbKalem);
			this.Controls.Add(this.lblKondenzator);
			this.Controls.Add(this.tbKondenzator);
			this.Controls.Add(this.lblNapon);
			this.Controls.Add(this.tbNapon);
			this.Controls.Add(this.pbxDrugi);
			this.Controls.Add(this.btnNazad);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Simulacija";
			this.Text = "Simulacija";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulacija_FormClosed);
			this.Load += new System.EventHandler(this.Simulacija_Load);
			this.ResizeEnd += new System.EventHandler(this.Simulacija_ResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.tbOtpornik)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbKalem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbKondenzator)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbNapon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxDrugi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxPrvi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblOtpornik;
        private System.Windows.Forms.TrackBar tbOtpornik;
        private System.Windows.Forms.Label lblKalem;
        private System.Windows.Forms.TrackBar tbKalem;
        private System.Windows.Forms.Label lblKondenzator;
        private System.Windows.Forms.TrackBar tbKondenzator;
        private System.Windows.Forms.Label lblNapon;
        private System.Windows.Forms.TrackBar tbNapon;
        private System.Windows.Forms.Button btnIzaberiKolo;
        private System.Windows.Forms.Button bttnStartStop;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.PictureBox pbxDrugi;
        private System.Windows.Forms.PictureBox pbxPrvi;
    }
}