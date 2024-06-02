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
		List<string> upisanaResenja = new List<string>();
		TextBox unosResenja = new TextBox();
		public Testovi()
		{
			InitializeComponent();
			btnNazad.Show();
			tbxOpisZadataka.Hide();
		}
		private void Testovi_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.Exit();
		}

		Label lblPitanje1 = new Label();
		Label lblPitanje2 = new Label();
		Label lblPitanje3 = new Label();
		Label lblPitanje4 = new Label();
		Label lblPitanje5 = new Label();

		RadioButton rbn1 = new RadioButton();
		RadioButton rbn2 = new RadioButton();
		RadioButton rbn3 = new RadioButton();
		RadioButton rbn4 = new RadioButton();
		RadioButton rbn5 = new RadioButton();
		RadioButton rbn6 = new RadioButton();
		RadioButton rbn7 = new RadioButton();
		RadioButton rbn8 = new RadioButton();
		RadioButton rbn9 = new RadioButton();
		RadioButton rbn10 = new RadioButton();
		RadioButton rbn11 = new RadioButton();
		RadioButton rbn12 = new RadioButton();
		RadioButton rbn13 = new RadioButton();
		RadioButton rbn14 = new RadioButton();
		RadioButton rbn15 = new RadioButton();

		Button prikaziResenje = new Button();


		public void SakriSve()
		{
			lblPitanje1.Hide();
			lblPitanje2.Hide();
			lblPitanje3.Hide();
			lblPitanje4.Hide();
			lblPitanje5.Hide();
			rbn1.Hide();
			rbn2.Hide();
			rbn3.Hide();
			rbn4.Hide();
			rbn5.Hide();
			rbn6.Hide();
			rbn7.Hide();
			rbn8.Hide();
			rbn9.Hide();
			rbn10.Hide();
			rbn11.Hide();
			rbn12.Hide();
			rbn13.Hide();
			rbn14.Hide();
			rbn15.Hide();
			prikaziResenje.Hide();
			pbxKolo1.Hide();
			pbxKolo2.Hide();
			pbxKolo3.Hide();
			pbxKolo4.Hide();
		}
		private void btnNazad_Click( object sender, EventArgs e )
		{

			if( btnTest1.Visible || btnTest2.Visible || btnTest3.Visible || btnTest4.Visible )
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
				SakriSve();

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

			lblPitanje1.Show();
			lblPitanje2.Show();
			lblPitanje3.Show();
			lblPitanje4.Show();
			lblPitanje5.Show();
			rbn1.Show();
			rbn2.Show();
			rbn3.Show();
			rbn4.Show();
			rbn5.Show();
			rbn6.Show();
			rbn7.Show();
			rbn8.Show();
			rbn9.Show();
			rbn10.Show();
			rbn11.Show();
			rbn12.Show();
			rbn13.Show();
			rbn14.Show();
			rbn15.Show();
			prikaziResenje.Show();

			tbxOpisZadataka.Clear();
		}

		public void DodavanjeLabela( Label imeLabela )
		{
			imeLabela.BackColor = Color.White;
			imeLabela.ForeColor = Color.Black;
			imeLabela.BorderStyle = BorderStyle.FixedSingle;
			imeLabela.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( imeLabela );
		}
		public void DodavanjeRadioButtona( RadioButton imeRadioButtona )
		{
			imeRadioButtona.BackColor = Color.White;
			imeRadioButtona.ForeColor = Color.Black;
			Controls.Add( imeRadioButtona );
		}
		public void DodavanjeLabelaIButtona()
		{
			DodavanjeLabela( lblPitanje1 );
			DodavanjeLabela( lblPitanje2 );
			DodavanjeLabela( lblPitanje3 );
			DodavanjeLabela( lblPitanje4 );
			DodavanjeLabela( lblPitanje5 );
			DodavanjeRadioButtona( rbn1 );
			DodavanjeRadioButtona( rbn2 );
			DodavanjeRadioButtona( rbn3 );
			DodavanjeRadioButtona( rbn4 );
			DodavanjeRadioButtona( rbn5 );
			DodavanjeRadioButtona( rbn6 );
			DodavanjeRadioButtona( rbn7 );
			DodavanjeRadioButtona( rbn8 );
			DodavanjeRadioButtona( rbn9 );
			DodavanjeRadioButtona( rbn10 );
			DodavanjeRadioButtona( rbn11 );
			DodavanjeRadioButtona( rbn12 );
			DodavanjeRadioButtona( rbn13 );
			DodavanjeRadioButtona( rbn14 );
			DodavanjeRadioButtona( rbn15 );

		}
		private void btnTest1_Click( object sender, EventArgs e )
		{
			KliknutoDugme();
			pbxKolo1.Show();
		}
		private void btnTest2_Click( object sender, EventArgs e )
		{
			KliknutoDugme();
			pbxKolo2.Show();
		}
		private void btnTest3_Click( object sender, EventArgs e )
		{
			KliknutoDugme();
			lblPitanje1.Text = "1. Sta u datom kolu predstavlja R";
			lblPitanje2.Text = "2. Sta u datom kolu predstavlja L?";
			lblPitanje3.Text = "3. Sta u datom kolu predstavlja C?";
			lblPitanje4.Text = "4. Koja je frekvencija napona?";
			lblPitanje5.Text = "5. Koja je amplituda napona?";
			pbxKolo3.Show();
		}
		private void btnTest4_Click( object sender, EventArgs e )
		{
			KliknutoDugme();
			pbxKolo4.Show();
		}

		private void Testovi_Load( object sender, EventArgs e )
		{
			this.Width = 1200;
			this.Height = 800;
			DodavanjeLabelaIButtona();
			Controls.Add( prikaziResenje );
			SakriSve();

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

			//namestanje labela ispod kola
			int lblKoloWidth = bttnWidth/2;
			int lblKoloHeight = lblKoloWidth/8;
			int x1lbl, x2lbl, y1lbl, y2lbl; //koordinate za pozicije dugmica
			x1lbl = x1;
			x2lbl = x2;
			y1lbl = y1 - Height/20;
			y2lbl = y2 - Height/20;
			int velicinaFonta = 10*lblKoloHeight/15;
			lblprvi.SetBounds( x1lbl, y1lbl, lblKoloWidth, lblKoloHeight );
			lbldrugi.SetBounds( x2lbl, y1lbl, lblKoloWidth, lblKoloHeight );
			lbltreci.SetBounds( x1lbl, y2lbl, lblKoloWidth, lblKoloHeight );
			lblcetvrti.SetBounds( x2lbl, y2lbl, lblKoloWidth, lblKoloHeight );
			lblprvi.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lbldrugi.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lbltreci.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblcetvrti.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );

			//namestanje labela za pitanja
			int razmakIzmedjuLabela = Height/6;
			int pitanjelblWidth = Width/4;
			int pitanjelblHeight = Height/20;
			int xLabeliPitanja = Width/20;
			int yLabeliPitanja = Height/20;
			lblPitanje1.SetBounds( xLabeliPitanja, yLabeliPitanja, pitanjelblWidth, pitanjelblHeight );
			lblPitanje2.SetBounds( xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela, pitanjelblWidth, pitanjelblHeight );
			lblPitanje3.SetBounds( xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela*2, pitanjelblWidth, pitanjelblHeight );
			lblPitanje4.SetBounds( xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela*3, pitanjelblWidth, pitanjelblHeight );
			lblPitanje5.SetBounds( xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela * 4, pitanjelblWidth, pitanjelblHeight );
			lblPitanje1.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblPitanje2.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblPitanje3.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblPitanje4.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblPitanje5.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );

			//namestanje radio buttona za pitanja
			int rbnWidth = Width/6;
			int rbnHeight = Height/20;
			int velicinaRbn = rbnWidth;
			int x1rbn = Width/20;
			int x2rbn = x1rbn + Width/5;
			int x3rbn = x2rbn + Width/5;
			int yrbn = yLabeliPitanja + razmakIzmedjuLabela/2;
			int razmakIzmedjurbn = razmakIzmedjuLabela;
			//za pitanje 1
			rbn1.SetBounds( x1rbn, yrbn, rbnWidth, rbnHeight );
			rbn2.SetBounds( x2rbn, yrbn, rbnWidth, rbnHeight );
			rbn3.SetBounds( x3rbn, yrbn, rbnWidth, rbnHeight );
			//za pitanje 2
			rbn4.SetBounds( x1rbn, yrbn + razmakIzmedjurbn, rbnWidth, rbnHeight );
			rbn5.SetBounds( x2rbn, yrbn + razmakIzmedjurbn, rbnWidth, rbnHeight );
			rbn6.SetBounds( x3rbn, yrbn + razmakIzmedjurbn, rbnWidth, rbnHeight );
			//za pitanj 3
			rbn7.SetBounds( x1rbn, yrbn + razmakIzmedjurbn * 2, rbnWidth, rbnHeight );
			rbn8.SetBounds( x2rbn, yrbn + razmakIzmedjurbn * 2, rbnWidth, rbnHeight );
			rbn9.SetBounds( x3rbn, yrbn + razmakIzmedjurbn * 2, rbnWidth, rbnHeight );
			//za pitanje 4
			rbn10.SetBounds( x1rbn, yrbn + razmakIzmedjurbn * 3, rbnWidth, rbnHeight );
			rbn11.SetBounds( x2rbn, yrbn + razmakIzmedjurbn * 3, rbnWidth, rbnHeight );
			rbn12.SetBounds( x3rbn, yrbn + razmakIzmedjurbn * 3, rbnWidth, rbnHeight );
			//za pitanje 5
			rbn13.SetBounds( x1rbn, yrbn + razmakIzmedjurbn * 4, rbnWidth, rbnHeight );
			rbn14.SetBounds( x2rbn, yrbn + razmakIzmedjurbn * 4, rbnWidth, rbnHeight );
			rbn15.SetBounds( x3rbn, yrbn + razmakIzmedjurbn * 4, rbnWidth, rbnHeight );

			//namestanje button prikazi resenje
			prikaziResenje.Text = "PROVERI";
			prikaziResenje.Font = new Font( "Times New Roman", Width/70, FontStyle.Bold );
			prikaziResenje.SetBounds( Width - Width/6, ClientSize.Height - ClientSize.Height/6, Width/7, Height/7 );
			prikaziResenje.ForeColor = Color.Black;
			prikaziResenje.BackColor = Color.White;

			//namestanje picture boxova
			int pbxWidth = 10*Width/35;
			int pbxHeight = 10*Height/35;
			int xpbx = x3rbn + Width/5;
			int ypbx = Height/4;
			pbxKolo1.SetBounds( xpbx, ypbx, pbxWidth, pbxHeight );
			pbxKolo2.SetBounds( xpbx, ypbx, pbxWidth, pbxHeight );
			pbxKolo3.SetBounds( xpbx, ypbx, pbxWidth, pbxHeight );
			pbxKolo4.SetBounds( xpbx, ypbx, pbxWidth, pbxHeight );

			tbxOpisZadataka.SetBounds( x1, y1, Width - 2*Width/6, Height - 2*Height/6 );
			tbxOpisZadataka.Font = new Font( "Times New Roman", Width/50, FontStyle.Bold );
		}
		private void Testovi_ResizeEnd( object sender, EventArgs e )
		{
			SetSize();
		}

	}
}
