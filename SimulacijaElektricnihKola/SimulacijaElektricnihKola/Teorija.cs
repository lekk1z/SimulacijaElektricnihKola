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
            this.Width = 1200;
            this.Height = 800;
            rtbTeorija.LoadFile("teorija.rtf");
            SetSize();

		}
        private void Teorija_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}
        public void SetSize()
        {
			rtbTeorija.SetBounds( 0, 0, 9*Width/10, ClientSize.Height );
            rtbTeorija.Font = new Font("", Width/70);
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );
			btnNazad.Font = new Font( "", Width/50, FontStyle.Bold );
            
        }
    }
}
