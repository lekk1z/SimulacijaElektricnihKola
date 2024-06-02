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

		Label lblPitanje1 = new Label();
		Label lblPitanje2 = new Label();
		Label lblPitanje3 = new Label();
		Label lblPitanje4 = new Label();
		Label lblPitanje5 = new Label();

		GroupBox prvoPitanjeOdgovori = new GroupBox();
		GroupBox drugoPitanjeOdgovori = new GroupBox();
		GroupBox trecePitanjeOdgovori = new GroupBox();
		GroupBox cetvrtoPitanjeOdgovori = new GroupBox();
		GroupBox petoPitanjeOdgovori = new GroupBox();

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
		Button proveri = new Button();
		public int[] tacniOdg = new int[5];
		public int[] stikliraniOdg = new int[5];
		public void SakriSve()
		{
			lblPitanje1.Hide();
			lblPitanje2.Hide();
			lblPitanje3.Hide();
			lblPitanje4.Hide();
			lblPitanje5.Hide();
			prvoPitanjeOdgovori.Hide();
			drugoPitanjeOdgovori.Hide();
			trecePitanjeOdgovori.Hide();
			cetvrtoPitanjeOdgovori.Hide();
			petoPitanjeOdgovori.Hide();
			prikaziResenje.Hide();
			proveri.Hide();
			pbxKolo1.Hide();
			pbxKolo2.Hide();
			pbxKolo3.Hide();
			pbxKolo4.Hide();
			rtbObjasnjenjeResenja.Hide();
			tbxOpisZadataka.Hide();
		}
		public void Refreshuj()
		{
			prvoPitanjeOdgovori.Enabled = true;
			drugoPitanjeOdgovori.Enabled = true;
			trecePitanjeOdgovori.Enabled = true;
			cetvrtoPitanjeOdgovori.Enabled = true;
			petoPitanjeOdgovori.Enabled = true;
			rbn1.Checked = false;
			rbn2.Checked = false;
			rbn3.Checked = false;
			rbn4.Checked = false;
			rbn5.Checked = false;
			rbn6.Checked = false;
			rbn7.Checked = false;
			rbn8.Checked = false;
			rbn9.Checked = false;
			rbn10.Checked = false;
			rbn11.Checked = false;
			rbn12.Checked = false;
			rbn13.Checked = false;
			rbn14.Checked = false;
			rbn15.Checked = false;
			lblPitanje1.BackColor = Color.White;
			lblPitanje2.BackColor = Color.White;
			lblPitanje3.BackColor = Color.White;
			lblPitanje4.BackColor = Color.White;
			lblPitanje5.BackColor = Color.White;
		}
		private void btnNazad_Click(object sender, EventArgs e)
		{
			Refreshuj();
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
			/*rbn1.Show();
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
			rbn15.Show();*/
			prvoPitanjeOdgovori.Show();
			drugoPitanjeOdgovori.Show();
			trecePitanjeOdgovori.Show();
			cetvrtoPitanjeOdgovori.Show();
			petoPitanjeOdgovori.Show();
			prikaziResenje.Show();
			proveri.Show();
			tbxOpisZadataka.Clear();
		}
		public void DodavanjeLabela(Label imeLabela)
		{
			imeLabela.BackColor = Color.White;
			imeLabela.ForeColor = Color.Black;
			imeLabela.BorderStyle = BorderStyle.FixedSingle;
			imeLabela.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add(imeLabela);
		}
		public void DodavanjeRadioButtona(RadioButton imeRadioButtona)
		{
			imeRadioButtona.BackColor = Color.White;
			imeRadioButtona.ForeColor = Color.Black;
			Controls.Add(imeRadioButtona);
		}
		public void Dodavanje()
		{
			DodavanjeLabela(lblPitanje1);
			DodavanjeLabela(lblPitanje2);
			DodavanjeLabela(lblPitanje3);
			DodavanjeLabela(lblPitanje4);
			DodavanjeLabela(lblPitanje5);
			DodavanjeRadioButtona(rbn1);
			DodavanjeRadioButtona(rbn2);
			DodavanjeRadioButtona(rbn3);
			DodavanjeRadioButtona(rbn4);
			DodavanjeRadioButtona(rbn5);
			DodavanjeRadioButtona(rbn6);
			DodavanjeRadioButtona(rbn7);
			DodavanjeRadioButtona(rbn8);
			DodavanjeRadioButtona(rbn9);
			DodavanjeRadioButtona(rbn10);
			DodavanjeRadioButtona(rbn11);
			DodavanjeRadioButtona(rbn12);
			DodavanjeRadioButtona(rbn13);
			DodavanjeRadioButtona(rbn14);
			DodavanjeRadioButtona(rbn15);
			DodajRadioButtoneUGroupBox(prvoPitanjeOdgovori, rbn1, rbn2, rbn3);
			DodajRadioButtoneUGroupBox(drugoPitanjeOdgovori, rbn4, rbn5, rbn6);
			DodajRadioButtoneUGroupBox(trecePitanjeOdgovori, rbn7, rbn8, rbn9);
			DodajRadioButtoneUGroupBox(cetvrtoPitanjeOdgovori, rbn10, rbn11, rbn12);
			DodajRadioButtoneUGroupBox(petoPitanjeOdgovori, rbn13, rbn14, rbn15);
			Controls.Add(prikaziResenje);
			Controls.Add(proveri);

		}

		private void btnTest1_Click(object sender, EventArgs e)
		{
			KliknutoDugme();
			tbxOpisZadataka.Text = "Redno RLC-kolo (R = 20Ω, L = 0,5H, C = 5μF) priključeno je na naizmenični napon efektivne vrednosti 24 V čija frekvencija može da se menja.\r\n" +
				"\r\nOdrediti: \r\n - Jačinu efektivne struje pri frekvenciji od 50Hz\r\n - Jačinu efektivne struje pri rezonantnoj frekvenciji" +
				"\r\n - Faznu razliku struje i napona pri frekvenciji\r\n - Napon na kalemu pri rezonanciji\r\n - Napon na kondezatoru pri rezonanciji";
			lblPitanje1.Text = "1. Jačina efektivne vrednosti pri frekvenciji od 50Hz je:";
			lblPitanje2.Text = "2. Jačina efektivne vrednosti pri rezonantnoj frekvenciji je:";
			lblPitanje3.Text = "3. Fazna razlika struje i napona pri frekvenciji od 50 Hz je:";
			lblPitanje4.Text = "4. Napon na kalemu pri rezonanciji je:";
			lblPitanje5.Text = "5. Napon na kondezatoru pri rezonanciji je:";
			tbxOpisZadataka.Show();
			rbn1.Text = "0.05 A";
			rbn2.Text = "0,25 A";
			rbn3.Text = "0,025 A";
			rbn4.Text = "1,5 A";
			rbn5.Text = "2,4 A";
			rbn6.Text = "1,2 A";
			rbn7.Text = "1 rad";
			rbn8.Text = "-1,53 rad";
			rbn9.Text = "1,53 rad";
			rbn10.Text = "316 V";
			rbn11.Text = "632 V";
			rbn12.Text = "256 V";
			rbn13.Text = "316 V";
			rbn14.Text = "256 V";
			rbn15.Text = "632 V";
			tacniOdg[0] = 1;
			tacniOdg[1] = 6;
			tacniOdg[2] = 8;
			tacniOdg[3] = 10;
			tacniOdg[4] = 13;
			pbxKolo1.Show();
		}
		private void btnTest2_Click(object sender, EventArgs e)
		{
			KliknutoDugme();
			pbxKolo2.Show();
		}
		private void btnTest3_Click(object sender, EventArgs e)
		{
			KliknutoDugme();
			lblPitanje1.Text = "1. Sta u datom kolu predstavlja R?";
			lblPitanje2.Text = "2. Sta u datom kolu predstavlja L?";
			lblPitanje3.Text = "3. Sta u datom kolu predstavlja C?";
			lblPitanje4.Text = "4. Koja je frekvencija napona?";
			lblPitanje5.Text = "5. Koja je amplituda napona?";
			tbxOpisZadataka.Text = "U datom kolu:\r\nR = Xl = 10 Ω\r\nXc = 20 Ω\r\nu = 5sin314t(SI)\r\n\r\nNaći jednačinu struje kroz nerazgranati deo kola(u zavisnosti od vremena).";
			tbxOpisZadataka.Show();
			pbxKolo3.Show();
		}
		private void btnTest4_Click(object sender, EventArgs e)
		{
			KliknutoDugme();
			tbxOpisZadataka.Text = "U kolu prikazanom na slici je: &1 = 10 V, &2 = 8 V, & = 6 V, R1 = 2kΩ, R2 = R = 4kΩ.\r\n Unutrašnje otpornosti izvora su zanemarljive.";
			tbxOpisZadataka.Show();
			lblPitanje1.Text = "1. Koliku jačinu struje pokazuje idealni ampermetar?";
			lblPitanje2.Text = "2. U kom smeru teče ta struja?";
			pbxKolo4.Show();
		}
		public void DodajRadioButtoneUGroupBox(GroupBox x, RadioButton a, RadioButton b, RadioButton c)
		{
			x.Controls.Add(a);
			x.Controls.Add(b);
			x.Controls.Add(c);
			Controls.Add(x);
		}
		private void Testovi_Load(object sender, EventArgs e)
		{
			this.Width = 1200;
			this.Height = 800;
			Dodavanje();
			SakriSve();
			SetSize();
			proveri.Click += Proveri_Click;
			prikaziResenje.Click += PrikaziResenje_Click;

		}

		private void PrikaziResenje_Click(object sender, EventArgs e)
		{
			SakriSve();
			rtbObjasnjenjeResenja.LoadFile("resenjaPrvogtesta.rtf");
			rtbObjasnjenjeResenja.Show();
		}

		static int ProveraSelektovanog(RadioButton levi, RadioButton srednji, RadioButton desni, int n)
		{
			if (levi.Checked) return 1 + 3 * n;
			else if (srednji.Checked) return 2 + 3 * n;
			else if (desni.Checked) return 3 + 3 * n;
			else return 0;
		}
		private void Proveri_Click(object sender, EventArgs e)
		{
			stikliraniOdg[0] = ProveraSelektovanog(rbn1, rbn2, rbn3, 0);
			stikliraniOdg[1] = ProveraSelektovanog(rbn4, rbn5, rbn6, 1);
			stikliraniOdg[2] = ProveraSelektovanog(rbn7, rbn8, rbn9, 2);
			stikliraniOdg[3] = ProveraSelektovanog(rbn10, rbn11, rbn12, 3);
			stikliraniOdg[4] = ProveraSelektovanog(rbn13, rbn14, rbn15, 4);
			int brojac = 0;
			for (int i = 0; i < 5; i++)
			{
				if (stikliraniOdg[i] == 0) brojac++;
			}
			if (brojac == 0)
			{
				prvoPitanjeOdgovori.Enabled = false;
				drugoPitanjeOdgovori.Enabled = false;
				trecePitanjeOdgovori.Enabled = false;
				cetvrtoPitanjeOdgovori.Enabled = false;
				petoPitanjeOdgovori.Enabled = false;
				if (stikliraniOdg[0] == tacniOdg[0]) lblPitanje1.BackColor = Color.Green;
				else lblPitanje1.BackColor = Color.Red;

				if (stikliraniOdg[1] == tacniOdg[1]) lblPitanje2.BackColor = Color.Green;
				else lblPitanje2.BackColor = Color.Red;

				if (stikliraniOdg[2] == tacniOdg[2]) lblPitanje3.BackColor = Color.Green;
				else lblPitanje3.BackColor = Color.Red;

				if (stikliraniOdg[3] == tacniOdg[3]) lblPitanje4.BackColor = Color.Green;
				else lblPitanje4.BackColor = Color.Red;

				if (stikliraniOdg[4] == tacniOdg[4]) lblPitanje5.BackColor = Color.Green;
				else lblPitanje5.BackColor = Color.Red;
			}
			else
			{
				MessageBox.Show("Niste odgovorili na sva pitanja. Mozete proveriti svoje odgovore tek nakon sto odgovorite na svako pitanje.", "Upozorenje");
				brojac = 0;
				proveri.Refresh();
			}
		}

		public void SetSize()
		{
			//namestanje dugmica za testove/kola
			int bttnWidth = 10 * Width / 36;
			int bttnHeight = 10 * Height / 35;
			int x1, x2, y1, y2; //koordinate za pozicije dugmica
			x1 = Width / 6;
			x2 = 5 * Width / 6 - bttnWidth;
			y1 = Height / 6;
			y2 = 5 * Height / 6 - bttnHeight;
			btnTest1.SetBounds(x1, y1, bttnWidth, bttnHeight);
			btnTest2.SetBounds(x2, y1, bttnWidth, bttnHeight);
			btnTest3.SetBounds(x1, y2, bttnWidth, bttnHeight);
			btnTest4.SetBounds(x2, y2, bttnWidth, bttnHeight);
			btnNazad.SetBounds(Width - Width / 12, Height / 50, Width / 17, Width / 17);
			btnNazad.Font = new Font("", Width / 50, FontStyle.Bold);

			//namestanje labela iznad kola
			int lblKoloWidth = bttnWidth / 2;
			int lblKoloHeight = lblKoloWidth / 8;
			int x1lbl, x2lbl, y1lbl, y2lbl; //koordinate za pozicije labela
			x1lbl = x1;
			x2lbl = x2;
			y1lbl = y1 - Height / 20;
			y2lbl = y2 - Height / 20;
			int velicinaFonta = 10 * lblKoloHeight / 15;
			lblprvi.SetBounds(x1lbl, y1lbl, lblKoloWidth, lblKoloHeight);
			lbldrugi.SetBounds(x2lbl, y1lbl, lblKoloWidth, lblKoloHeight);
			lbltreci.SetBounds(x1lbl, y2lbl, lblKoloWidth, lblKoloHeight);
			lblcetvrti.SetBounds(x2lbl, y2lbl, lblKoloWidth, lblKoloHeight);
			lblprvi.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lbldrugi.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lbltreci.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lblcetvrti.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);

			//namestanje labela za pitanja
			int razmakIzmedjuLabela = Height / 6;
			int pitanjelblWidth = Width / 4;
			int pitanjelblHeight = Height / 20;
			int xLabeliPitanja = Width / 20;
			int yLabeliPitanja = Height / 20;
			lblPitanje1.SetBounds(xLabeliPitanja, yLabeliPitanja, pitanjelblWidth, pitanjelblHeight);
			lblPitanje2.SetBounds(xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela, pitanjelblWidth, pitanjelblHeight);
			lblPitanje3.SetBounds(xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela * 2, pitanjelblWidth, pitanjelblHeight);
			lblPitanje4.SetBounds(xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela * 3, pitanjelblWidth, pitanjelblHeight);
			lblPitanje5.SetBounds(xLabeliPitanja, yLabeliPitanja + razmakIzmedjuLabela * 4, pitanjelblWidth, pitanjelblHeight);
			lblPitanje1.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lblPitanje2.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lblPitanje3.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lblPitanje4.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
			lblPitanje5.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);

			//namestanje gruop boxa
			int xGbx = Width / 20;
			int yGbxPrvi = yLabeliPitanja + razmakIzmedjuLabela / 2;
			int razmakIzmedjugbx = razmakIzmedjuLabela;
			int gbxWidth = Width / 2;
			int gbxHeight = Height / 20;
			prvoPitanjeOdgovori.SetBounds(xGbx, yGbxPrvi, gbxWidth, gbxHeight);
			drugoPitanjeOdgovori.SetBounds(xGbx, yGbxPrvi + razmakIzmedjugbx, gbxWidth, gbxHeight);
			trecePitanjeOdgovori.SetBounds(xGbx, yGbxPrvi + razmakIzmedjugbx * 2, gbxWidth, gbxHeight);
			cetvrtoPitanjeOdgovori.SetBounds(xGbx, yGbxPrvi + razmakIzmedjugbx * 3, gbxWidth, gbxHeight);
			petoPitanjeOdgovori.SetBounds(xGbx, yGbxPrvi + razmakIzmedjugbx * 4, gbxWidth, gbxHeight);

			//namestanje radio buttona u group boxu za pitanja
			int rbnWidth = gbxWidth / 3;
			int rbnHeight = Height / 20;
			int x1rbn = 0;
			int x2rbn = x1rbn + rbnWidth;
			int x3rbn = x2rbn + rbnWidth;
			int yrbn = 0;
			//za pitanje 1
			rbn1.SetBounds(x1rbn, yrbn, rbnWidth, rbnHeight);
			rbn2.SetBounds(x2rbn, yrbn, rbnWidth, rbnHeight);
			rbn3.SetBounds(x3rbn, yrbn, rbnWidth, rbnHeight);
			//za pitanje 2
			rbn4.SetBounds(x1rbn, yrbn, rbnWidth, rbnHeight);
			rbn5.SetBounds(x2rbn, yrbn, rbnWidth, rbnHeight);
			rbn6.SetBounds(x3rbn, yrbn, rbnWidth, rbnHeight);
			//za pitanje 3
			rbn7.SetBounds(x1rbn, yrbn, rbnWidth, rbnHeight);
			rbn8.SetBounds(x2rbn, yrbn, rbnWidth, rbnHeight);
			rbn9.SetBounds(x3rbn, yrbn, rbnWidth, rbnHeight);
			//za pitanje 4
			rbn10.SetBounds(x1rbn, yrbn, rbnWidth, rbnHeight);
			rbn11.SetBounds(x2rbn, yrbn, rbnWidth, rbnHeight);
			rbn12.SetBounds(x3rbn, yrbn, rbnWidth, rbnHeight);
			//za pitanje 5
			rbn13.SetBounds(x1rbn, yrbn, rbnWidth, rbnHeight);
			rbn14.SetBounds(x2rbn, yrbn, rbnWidth, rbnHeight);
			rbn15.SetBounds(x3rbn, yrbn, rbnWidth, rbnHeight);


			//namestanje button proveri
			proveri.Text = "PROVERI";
			proveri.Font = new Font("Times New Roman", Width / 70, FontStyle.Bold);
			proveri.SetBounds(Width - Width / 6, ClientSize.Height - ClientSize.Height / 6, Width / 7, Height / 7);
			proveri.ForeColor = Color.Black;
			proveri.BackColor = Color.White;

			// namestanje button prikazi resenje
			prikaziResenje.Text = "PRIKAZI RESENJE";
			prikaziResenje.Font = new Font("Times New Roman", Width / 70, FontStyle.Bold);
			prikaziResenje.SetBounds(Width - Width / 6 - Width / 6, ClientSize.Height - ClientSize.Height / 6, Width / 7, Height / 7);
			prikaziResenje.ForeColor = Color.Black;
			prikaziResenje.BackColor = Color.White;

			//namestanje picture boxova
			int pbxWidth = 10 * Width / 35;
			int pbxHeight = 10 * Height / 35;
			int xpbx = gbxWidth + Width / 6;
			int ypbx = yGbxPrvi + Height / 30;
			pbxKolo1.SetBounds(xpbx, ypbx, pbxWidth, pbxHeight);
			pbxKolo2.SetBounds(xpbx, ypbx, pbxWidth, pbxHeight);
			pbxKolo3.SetBounds(xpbx, ypbx, pbxWidth, pbxHeight);
			pbxKolo4.SetBounds(xpbx, ypbx, pbxWidth, pbxHeight);

			//namestanje text boxa sa opsiom zadatka
			tbxOpisZadataka.SetBounds(xpbx, ypbx + pbxHeight + Height / 35, pbxWidth, pbxHeight);
			tbxOpisZadataka.Font = new Font("Times New Roman", 12, FontStyle.Regular);
		}
		private void Testovi_ResizeEnd(object sender, EventArgs e)
		{
			SetSize();
		}

	}
}
