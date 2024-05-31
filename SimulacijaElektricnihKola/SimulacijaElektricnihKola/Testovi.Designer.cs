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
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.btnTest4 = new System.Windows.Forms.Button();
            this.tbxOpisZadataka = new System.Windows.Forms.TextBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(175, 89);
            this.btnTest1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(297, 169);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.UseVisualStyleBackColor = true;
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(591, 89);
            this.btnTest2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(297, 169);
            this.btnTest2.TabIndex = 1;
            this.btnTest2.UseVisualStyleBackColor = true;
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(175, 304);
            this.btnTest3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(297, 169);
            this.btnTest3.TabIndex = 2;
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // btnTest4
            // 
            this.btnTest4.Location = new System.Drawing.Point(591, 304);
            this.btnTest4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTest4.Name = "btnTest4";
            this.btnTest4.Size = new System.Drawing.Size(297, 169);
            this.btnTest4.TabIndex = 3;
            this.btnTest4.UseVisualStyleBackColor = true;
            // 
            // tbxOpisZadataka
            // 
            this.tbxOpisZadataka.Location = new System.Drawing.Point(175, 89);
            this.tbxOpisZadataka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxOpisZadataka.Multiline = true;
            this.tbxOpisZadataka.Name = "tbxOpisZadataka";
            this.tbxOpisZadataka.ReadOnly = true;
            this.tbxOpisZadataka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOpisZadataka.Size = new System.Drawing.Size(712, 383);
            this.tbxOpisZadataka.TabIndex = 4;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(984, 15);
            this.btnNazad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(67, 64);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "<";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // Testovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.tbxOpisZadataka);
            this.Controls.Add(this.btnTest4);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Testovi";
            this.Text = "Testovi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Testovi_FormClosed);
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
    }
}