﻿namespace SimulacijaElektricnihKola
{
	partial class LoadingScreen
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
			this.SuspendLayout();
			// 
			// LoadingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImage = global::SimulacijaElektricnihKola.Properties.Resources.wallpaperflare_com_wallpaper__1_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 461);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "LoadingScreen";
			this.Text = "LoadingScreen";
			this.MaximizedBoundsChanged += new System.EventHandler(this.LoadingScreen_ResizeEnd);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingScreen_FormClosed);
			this.Load += new System.EventHandler(this.LoadingScreen_Load);
			this.Resize += new System.EventHandler(this.LoadingScreen_ResizeEnd);
			this.ResumeLayout(false);

		}

		#endregion
	}
}