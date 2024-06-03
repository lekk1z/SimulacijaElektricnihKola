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
            this.tbxJacinaStruje = new System.Windows.Forms.TextBox();
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
            // lblOtpornik
            // 
            this.lblOtpornik.AutoSize = true;
            this.lblOtpornik.Location = new System.Drawing.Point(516, 363);
            this.lblOtpornik.Name = "lblOtpornik";
            this.lblOtpornik.Size = new System.Drawing.Size(57, 16);
            this.lblOtpornik.TabIndex = 25;
            this.lblOtpornik.Text = "Otpornik";
            // 
            // tbOtpornik
            // 
            this.tbOtpornik.Location = new System.Drawing.Point(519, 382);
            this.tbOtpornik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOtpornik.Maximum = 100;
            this.tbOtpornik.Minimum = 1;
            this.tbOtpornik.Name = "tbOtpornik";
            this.tbOtpornik.Size = new System.Drawing.Size(280, 56);
            this.tbOtpornik.TabIndex = 24;
            this.tbOtpornik.Value = 1;
            this.tbOtpornik.Scroll += new System.EventHandler(this.tbOtpornik_Scroll);
            this.tbOtpornik.ValueChanged += new System.EventHandler(this.tbOtpornik_ValueChanged);
            // 
            // lblKalem
            // 
            this.lblKalem.AutoSize = true;
            this.lblKalem.Location = new System.Drawing.Point(516, 304);
            this.lblKalem.Name = "lblKalem";
            this.lblKalem.Size = new System.Drawing.Size(102, 16);
            this.lblKalem.TabIndex = 23;
            this.lblKalem.Text = "Induktivni kalem";
            // 
            // tbKalem
            // 
            this.tbKalem.LargeChange = 1;
            this.tbKalem.Location = new System.Drawing.Point(519, 322);
            this.tbKalem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKalem.Maximum = 100;
            this.tbKalem.Minimum = 1;
            this.tbKalem.Name = "tbKalem";
            this.tbKalem.Size = new System.Drawing.Size(280, 56);
            this.tbKalem.TabIndex = 22;
            this.tbKalem.Value = 1;
            this.tbKalem.Scroll += new System.EventHandler(this.tbKalem_Scroll);
            this.tbKalem.ValueChanged += new System.EventHandler(this.tbKalem_ValueChanged);
            // 
            // lblKondenzator
            // 
            this.lblKondenzator.AutoSize = true;
            this.lblKondenzator.Location = new System.Drawing.Point(516, 242);
            this.lblKondenzator.Name = "lblKondenzator";
            this.lblKondenzator.Size = new System.Drawing.Size(82, 16);
            this.lblKondenzator.TabIndex = 21;
            this.lblKondenzator.Text = "Kondenzator";
            // 
            // tbKondenzator
            // 
            this.tbKondenzator.LargeChange = 1;
            this.tbKondenzator.Location = new System.Drawing.Point(519, 261);
            this.tbKondenzator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbKondenzator.Maximum = 100;
            this.tbKondenzator.Minimum = 1;
            this.tbKondenzator.Name = "tbKondenzator";
            this.tbKondenzator.Size = new System.Drawing.Size(280, 56);
            this.tbKondenzator.TabIndex = 20;
            this.tbKondenzator.Value = 1;
            this.tbKondenzator.Scroll += new System.EventHandler(this.tbKondenzator_Scroll);
            this.tbKondenzator.ValueChanged += new System.EventHandler(this.tbKondenzator_ValueChanged);
            // 
            // lblNapon
            // 
            this.lblNapon.AutoSize = true;
            this.lblNapon.Location = new System.Drawing.Point(516, 148);
            this.lblNapon.Name = "lblNapon";
            this.lblNapon.Size = new System.Drawing.Size(85, 16);
            this.lblNapon.TabIndex = 19;
            this.lblNapon.Text = "Ulazni napon";
            // 
            // tbNapon
            // 
            this.tbNapon.Location = new System.Drawing.Point(519, 167);
            this.tbNapon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNapon.Maximum = 25;
            this.tbNapon.Minimum = 1;
            this.tbNapon.Name = "tbNapon";
            this.tbNapon.Size = new System.Drawing.Size(280, 56);
            this.tbNapon.TabIndex = 18;
            this.tbNapon.Value = 1;
            this.tbNapon.ValueChanged += new System.EventHandler(this.tbNapon_ValueChanged);
            // 
            // btnIzaberiKolo
            // 
            this.btnIzaberiKolo.Location = new System.Drawing.Point(519, 81);
            this.btnIzaberiKolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzaberiKolo.Name = "btnIzaberiKolo";
            this.btnIzaberiKolo.Size = new System.Drawing.Size(137, 23);
            this.btnIzaberiKolo.TabIndex = 28;
            this.btnIzaberiKolo.Text = "Izaberi kolo";
            this.btnIzaberiKolo.UseVisualStyleBackColor = true;
            this.btnIzaberiKolo.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttnStartStop
            // 
            this.bttnStartStop.Location = new System.Drawing.Point(661, 12);
            this.bttnStartStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnStartStop.Name = "bttnStartStop";
            this.bttnStartStop.Size = new System.Drawing.Size(137, 50);
            this.bttnStartStop.TabIndex = 27;
            this.bttnStartStop.Text = "Start/Stop";
            this.bttnStartStop.UseVisualStyleBackColor = true;
            this.bttnStartStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(520, 14);
            this.bttnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(137, 50);
            this.bttnReset.TabIndex = 26;
            this.bttnReset.Text = "Reset";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(707, 12);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(51, 52);
            this.btnNazad.TabIndex = 2;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // pbxDrugi
            // 
            this.pbxDrugi.Location = new System.Drawing.Point(9, 324);
            this.pbxDrugi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxDrugi.Name = "pbxDrugi";
            this.pbxDrugi.Size = new System.Drawing.Size(500, 100);
            this.pbxDrugi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDrugi.TabIndex = 6;
            this.pbxDrugi.TabStop = false;
            // 
            // pbxPrvi
            // 
            this.pbxPrvi.Location = new System.Drawing.Point(9, 12);
            this.pbxPrvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxPrvi.Name = "pbxPrvi";
            this.pbxPrvi.Size = new System.Drawing.Size(500, 305);
            this.pbxPrvi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPrvi.TabIndex = 29;
            this.pbxPrvi.TabStop = false;
            // 
            // tbxJacinaStruje
            // 
            this.tbxJacinaStruje.Location = new System.Drawing.Point(17, 16);
            this.tbxJacinaStruje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxJacinaStruje.Name = "tbxJacinaStruje";
            this.tbxJacinaStruje.Size = new System.Drawing.Size(132, 22);
            this.tbxJacinaStruje.TabIndex = 30;
            this.tbxJacinaStruje.Text = "I: ";
            // 
            // Simulacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.tbxJacinaStruje);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "Simulacija";
            this.Text = "Simulacija";
            this.MaximizedBoundsChanged += new System.EventHandler(this.Simulacija_ResizeEnd);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulacija_FormClosed);
            this.Load += new System.EventHandler(this.Simulacija_Load);
            this.Resize += new System.EventHandler(this.Simulacija_ResizeEnd);
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
		private System.Windows.Forms.TextBox tbxJacinaStruje;
	}
}