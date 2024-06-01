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
    public partial class Testovi : Form
    {
        List <string> upisanaResenja = new List <string> ();
        TextBox unosResenja = new TextBox ();
        public Testovi()
        {
            InitializeComponent();
            btnNazad.Show();
            tbxOpisZadataka.Hide();
        }
        private void Testovi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnNazad_Click(object sender, EventArgs e)
        {
         
            if (btnTest1.Visible || btnTest2.Visible || btnTest3.Visible || btnTest4.Visible)
            {
                this.Visible = false;
                Form1.loading.Show();
            }
            else
            {
                btnTest1.Show();
                btnTest2.Show();
                btnTest3.Show();
                btnTest4.Show();
				lblprvi.Show();
				lbldrugi.Show();
				lbltreci.Show();
				lblcetvrti.Show();
                tbxOpisZadataka.Hide();
            }
        }
		public void KliknutoDugme()
		{
			btnTest1.Hide();
			btnTest2.Hide();
			btnTest3.Hide();
			btnTest4.Hide();
			lblprvi.Hide();
			lbldrugi.Hide();
			lbltreci.Hide();
			lblcetvrti.Hide();
			tbxOpisZadataka.Clear();
			tbxOpisZadataka.Show();
		}
		private void btnTest1_Click( object sender, EventArgs e )
        {
			KliknutoDugme();

		}
        private void btnTest2_Click( object sender, EventArgs e )
		{
			KliknutoDugme();
		}
		public void LabelFont( Label imeLabela )
		{
			imeLabela.BackColor = Color.White;
			imeLabela.ForeColor = Color.Black;
			imeLabela.BorderStyle = BorderStyle.FixedSingle;
			imeLabela.TextAlign = ContentAlignment.MiddleCenter;
		}
		private void btnTest3_Click( object sender, EventArgs e )
		{
			KliknutoDugme();

			Label lblZadatak1 = new Label();
			LabelFont( lblZadatak1 );
			lblZadatak1.Text = "1. Sta u datom kolu predstavlja R";
			Controls.Add( lblZadatak1 );

			Label lblZadatak2 = new Label();
			LabelFont( lblZadatak2 );
			lblZadatak2.Text = "2. Sta u datom kolu predstavlja L?";
			Controls.Add( lblZadatak2 );

			Label lblZadatak3 = new Label();
			LabelFont( lblZadatak3 );
			lblZadatak3.Text = "3. Sta u datom kolu predstavlja C?";
			Controls.Add( lblZadatak3 );

			Label lblZadatak4 = new Label();
			LabelFont( lblZadatak4 );
			lblZadatak4.Text = "4. Koja je frekvencija napona?";
			Controls.Add( lblZadatak4 );

			Label lblZadatak5 = new Label();
			LabelFont( lblZadatak5 );
			lblZadatak5.Text = "5. Koja je amplituda napona?";
			Controls.Add( lblZadatak5 );

		}
		private void btnTest4_Click( object sender, EventArgs e )
		{
			KliknutoDugme();
			tbxOpisZadataka.Text += "Fazorski diagram datog kola:\r\n U1 - napon na termogenom kolu\r\n " +
				"U2 - napon na induktivnom, odnosno kapacitivnom otpotu\r\n I1 - jacina struje kroz nerazgranati deo kola\r\n " +
				"I2 - jacina struje kroz kapacitivni otpor\r\n I3-jacina struje kroz induktivni otpor\r\n U - napon na krajevima veze izovoru ";

		}

		private void Testovi_Load( object sender, EventArgs e )
		{
			this.Width = 1200;
			this.Height = 800;
			SetSize();
		}

        public void SetSize()
        {
            //namestanje dugmica
			int bttnWidth = 10*Width/36;
			int bttnHeight = 10*Height/35;
			int x1, x2, y1, y2; //koordinate za pozicije dugmica
			x1 = Width/6;
			x2 = 5*Width/6 - bttnWidth;
			y1 = Height/6;
			y2 = 5*Height/6 - bttnHeight;
			btnTest1.SetBounds( x1, y1, bttnWidth, bttnHeight );
			btnTest2.SetBounds( x2, y1, bttnWidth, bttnHeight );
			btnTest3.SetBounds( x1, y2, bttnWidth, bttnHeight );
			btnTest4.SetBounds( x2, y2, bttnWidth, bttnHeight );
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );
			btnNazad.Font = new Font( "", Width/50, FontStyle.Bold );

			//namestanje labela
			int lblWidth = bttnWidth/2;
			int lblHeight = lblWidth/8;
			int x1lbl, x2lbl, y1lbl, y2lbl; //koordinate za pozicije dugmica
			x1lbl = x1 ;
			x2lbl = x2 ;
			y1lbl = y1 - Height/20;
			y2lbl = y2 - Height/20;
			int velicinaFonta = 10*lblHeight/15;
			lblprvi.SetBounds( x1lbl, y1lbl, lblWidth, lblHeight );
			lbldrugi.SetBounds( x2lbl, y1lbl, lblWidth, lblHeight );
			lbltreci.SetBounds( x1lbl, y2lbl, lblWidth, lblHeight );
			lblcetvrti.SetBounds( x2lbl, y2lbl, lblWidth, lblHeight );
			lblprvi.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lbldrugi.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lbltreci.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblcetvrti.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );

			tbxOpisZadataka.SetBounds(x1,y1, Width - 2*Width/6, Height - 2*Height/6 );
			tbxOpisZadataka.Font = new Font( "Times New Roman", Width/50, FontStyle.Bold );
		}
		private void Testovi_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}

	}
}
