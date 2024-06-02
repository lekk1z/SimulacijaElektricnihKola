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

		}
        private void InsertImage(RichTextBox richTextBox, Image image)
        {
            Clipboard.SetImage(image);
            richTextBox.Paste();
            Clipboard.Clear();
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
            rtbTeorija.SelectionAlignment = HorizontalAlignment.Center;
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("JEDNOSMERNA STRUJA");
            rtbTeorija.SelectionLength = "JEDNOSMERNA STRUJA".Length;
             rtbTeorija.SelectionFont = new Font("",Width/50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Primer:");
            rtbTeorija.SelectionLength = "Primer:".Length;
            rtbTeorija.SelectionFont = new Font(rtbTeorija.Font, FontStyle.Italic);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("PRVI KIRHOFOV ZAKON");
            rtbTeorija.SelectionLength = "PRVI KIRHOFOV ZAKON".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("DRUGI KIRHOFOV ZAKON");
            rtbTeorija.SelectionLength = "DRUGI KIRHOFOV ZAKON".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("NAIZMENIČNA STRUJA");
            rtbTeorija.SelectionLength = "NAIZMENIČNA STRUJA".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionAlignment = HorizontalAlignment.Center;
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Termogeni otpor (R)");
            rtbTeorija.SelectionLength = "Termogeni otpor (R)".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Induktivni otpor (XL)");
            rtbTeorija.SelectionLength = "Induktivni otpor (XL)".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Kapacitivni otpor (XC)");
            rtbTeorija.SelectionLength = "Kapacitivni otpor (XC)".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Induktivna otpornost");
            rtbTeorija.SelectionLength = "Induktivna otpornost".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Kapacitivna otpornost");
            rtbTeorija.SelectionLength = "Kapacitivna otpornost".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
            rtbTeorija.SelectionStart = rtbTeorija.Text.IndexOf("Kapacitivna otpornost");
            rtbTeorija.SelectionLength = "Kapacitivna otpornost".Length;
            rtbTeorija.SelectionFont = new Font("", Width / 50, FontStyle.Bold);
          //  Bitmap b = new Bitmap("C:\\Users\\PC\\Source\\Repos\\SimulacijaElektricnihKolaasdf\\SimulacijaElektricnihKola\\SimulacijaElektricnihKola\\slikaFaznoKasnjenjeNapona.jpg");
          // InsertImage(rtbTeorija,b);
        }
    }
}
