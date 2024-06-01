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
            SetSize();
            rtbTeorija.SelectionAlignment = HorizontalAlignment.Center;
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("JEDNOSMERNA STRUJA");
            rtbTeorija.SelectionLength = "JEDNOSMERNA STRUJA".Length;
            rtbTeorija.SelectionFont = new Font(rtbTeorija.Font, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Primer:");
            rtbTeorija.SelectionLength = "Primer:".Length;
            rtbTeorija.SelectionFont = new Font(rtbTeorija.Font, FontStyle.Italic);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("PRVI KIRHOFOV ZAKON");
            rtbTeorija.SelectionLength = "PRVI KIRHOFOV ZAKON".Length;
            rtbTeorija.SelectionFont = new Font(rtbTeorija.Font, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("DRUGI KIRHOFOV ZAKON");
            rtbTeorija.SelectionLength = "DRUGI KIRHOFOV ZAKON".Length;
            rtbTeorija.SelectionFont = new Font(rtbTeorija.Font, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("DRUGI KIRHOFOV ZAKON");
            rtbTeorija.SelectionLength = "DRUGI KIRHOFOV ZAKON".Length;
            rtbTeorija.SelectionFont = new Font(rtbTeorija.Font, FontStyle.Bold);

        }

        private void Teorija_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}
        public void SetSize()
        {
			rtbTeorija.SetBounds( 0, 0, 9*Width/10, 9*Height/10 );
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );
			btnNazad.Font = new Font( "", Width/50, FontStyle.Bold );
		}

        private void rtbTeorija_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
