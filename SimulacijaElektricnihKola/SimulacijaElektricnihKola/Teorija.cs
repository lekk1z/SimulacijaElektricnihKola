using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacijaElektricnihKola
{ 
     
    public partial class Teorija: Form
    {
        public Teorija()
        {
            InitializeComponent();
        }
        private void tbxTeorija_TextChanged( object sender, EventArgs e )
        {
            tbxTeorija.Text = "ovde treba nesto da pise";
        }

        private void btnNazad_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void Teorija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnNazad_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.loading.Show();
        }

		private void Teorija_Load( object sender, EventArgs e )
		{
            SetSize();
		}

		private void Teorija_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}
        public void SetSize()
        {
			tbxTeorija.SetBounds( 0, 0, 9*Width/10, 9*Height/10 );
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );
		}
	}
}
