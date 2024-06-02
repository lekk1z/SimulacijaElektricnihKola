﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimulacijaElektricnihKola
{
    public partial class Simulacija : Form
    {
        Pen olovka;

        static int brojac = 0;
        //aleksa
        private const int PictureBoxWidth = 490;
        private const int PictureBoxHeight = 100;
        private const int WaveLength = 50;
        private const int Amplitude = 30;
        private const int Period = 100;

        private int phase = 0;

        private const int VoltageAmplitude = 30; // Amplitude for voltage
        private const int CurrentAmplitude = 20; // Amplitude for current

        static List<Otpornik<Srebro>> otporniciJ = new List<Otpornik<Srebro>>();
        static List<SerijskaVeza<Srebro>> serijskeVezeJ = new List<SerijskaVeza<Srebro>>();
        static List<ParalelnaVeza<Srebro>> paralelneVezeJ = new List<ParalelnaVeza<Srebro>>();
        static List<Baterija> baterijeJ = new List<Baterija>();
        static SerijskaVeza<Srebro> glavna = new SerijskaVeza<Srebro>("glavna");

        static KoloNaizmenica kolo = new KoloNaizmenica();
        static List<Kondenzator> kondenzatori = new List<Kondenzator>();
        static List<OtpornikN> otporniciN = new List<OtpornikN>();
        static List<Kalem> kalemi = new List<Kalem>();
        static List<SerijskaVezaN> serijskeVezeN = new List<SerijskaVezaN>();
        static List<ParalelnaVezaN> paralelneVezeN = new List<ParalelnaVezaN>();
        static string trenutniTxt;
        static double napon;
        static double frekvencija;

        public static IzborKola izbor= new IzborKola();
        //*aleksa
        public Simulacija()
        {
            InitializeComponent();
        }
        private void NapraviNovoKolo()
        {
            int brojaclinija = 0;
            StreamReader sr = new StreamReader(izbor.izabranoKolo);
            string vrstaStruje=sr.ReadLine();
            
            if (vrstaStruje == "J")
            {
                while (!sr.EndOfStream)
                {
                    string t = sr.ReadLine();
                    string[] split1 = t.Split();
                    if (split1[0] == "s")
                    {
                        string[] split2 = split1[2].Split('-');
                        SerijskaVeza<Srebro> privremena = new SerijskaVeza<Srebro>(split1[1]);
                        foreach (string s in split2)
                        {
                            foreach (Otpornik<Srebro> otpornik in otporniciJ)
                            {
                                if (otpornik.Ime == s)
                                {
                                    privremena.DodajKomponentu(otpornik);
                                }
                            }
                            foreach (Baterija b in baterijeJ)
                            {
                                if (b.Ime == s)
                                {
                                    privremena.DodajKomponentu(b);
                                }
                            }
                            foreach (SerijskaVeza<Srebro> serija in serijskeVezeJ)
                            {
                                if (serija.Ime == s)
                                {
                                    privremena.DodajKomponentu(serija);
                                }
                            }
                            foreach (ParalelnaVeza<Srebro> paralelna in paralelneVezeJ)
                            {
                                if (paralelna.Ime == s)
                                {
                                    privremena.DodajKomponentu(paralelna);
                                }
                            }
                        }
                        serijskeVezeJ.Add(privremena);
                    }
                    else if (split1[0] == "p")
                    {
                        string[] split2 = split1[2].Split('-');
                        ParalelnaVeza<Srebro> privremena = new ParalelnaVeza<Srebro>(split1[1]);
                        foreach (string s in split2)
                        {
                            foreach (Otpornik<Srebro> otpornik in otporniciJ)
                            {
                                if (otpornik.Ime == s)
                                {
                                    privremena.DodajKomponentu(otpornik);
                                }
                            }
                            foreach (Baterija b in baterijeJ)
                            {
                                if (b.Ime == s)
                                {
                                    privremena.DodajKomponentu(b);
                                }
                            }
                            foreach (SerijskaVeza<Srebro> serija in serijskeVezeJ)
                            {
                                if (serija.Ime == s)
                                {
                                    privremena.DodajKomponentu(serija);
                                }
                            }
                            foreach (ParalelnaVeza<Srebro> paralelna in paralelneVezeJ)
                            {
                                if (paralelna.Ime == s)
                                {
                                    privremena.DodajKomponentu(paralelna);
                                }
                            }
                        }
                        paralelneVezeJ.Add(privremena);
                    }
                    brojaclinija++;
                    foreach (SerijskaVeza<Srebro> glavna1 in serijskeVezeJ)
                    {
                        if (glavna1.Ime == "glavna")
                        {
                            glavna = glavna1;
                        }
                    }
                }
            }
            else if (vrstaStruje == "N")
            {
                napon = double.Parse(sr.ReadLine());
                frekvencija = double.Parse(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    string t = sr.ReadLine();
                    string[] split1 = t.Split();
                    if (split1[0] == "s")
                    {
                        string[] split2 = split1[2].Split('-');
                        SerijskaVezaN privremena = new SerijskaVezaN { Ime = split1[1],Komponente = new List<KomponentaNaizmenicna>() };
                        foreach (string s in split2)
                        {
                            foreach (OtpornikN otpornik in otporniciN)
                            {
                                if (otpornik.Ime == s)
                                {
                                    privremena.Komponente.Add(otpornik);
                                }
                            }
                            foreach (SerijskaVezaN serija in serijskeVezeN)
                            {
                                if (serija.Ime == s)
                                {
                                    privremena.Komponente.Add(serija);
                                }
                            }
                            foreach (ParalelnaVezaN paralelna in paralelneVezeN)
                            {
                                if (paralelna.Ime == s)
                                {
                                    privremena.Komponente.Add(paralelna);
                                }
                            }
                            foreach (Kalem kalem in kalemi)
                            {
                                if (kalem.Ime == s)
                                {
                                    privremena.Komponente.Add(kalem);
                                }
                            }
                            foreach (Kondenzator kondenzator in kondenzatori)
                            {
                                if (kondenzator.Ime == s)
                                {
                                    privremena.Komponente.Add(kondenzator);
                                }
                            }
                        }
                        serijskeVezeN.Add(privremena);
                    }
                    else if (split1[0] == "p")
                    {
                        string[] split2 = split1[2].Split('-');
                        ParalelnaVezaN privremena = new ParalelnaVezaN { Ime = split1[1] , Komponente = new List<KomponentaNaizmenicna>() };
                        foreach (string s in split2)
                        {
                            foreach (OtpornikN otpornik in otporniciN)
                            {
                                if (otpornik.Ime == s)
                                {
                                    privremena.Komponente.Add(otpornik);
                                }
                            }
                            foreach (SerijskaVezaN serija in serijskeVezeN)
                            {
                                if (serija.Ime == s)
                                {
                                    privremena.Komponente.Add(serija);
                                }
                            }
                            foreach (ParalelnaVezaN paralelna in paralelneVezeN)
                            {
                                if (paralelna.Ime == s)
                                {
                                    privremena.Komponente.Add(paralelna);
                                }
                            }
                            foreach (Kalem kalem in kalemi)
                            {
                                if (kalem.Ime == s)
                                {
                                    privremena.Komponente.Add(kalem);
                                }
                            }
                            foreach (Kondenzator kondenzator in kondenzatori)
                            {
                                if (kondenzator.Ime == s)
                                {
                                    privremena.Komponente.Add(kondenzator);
                                }
                            }
                        }
                        paralelneVezeN.Add(privremena);
                    }
                    else if (split1[0] == "kolo")
                    {
                        string[] split2 = split1[2].Split('-');
                        kolo = new KoloNaizmenica();
                        foreach (string s in split2)
                        {
                            foreach (OtpornikN otpornik in otporniciN)
                            {
                                if (otpornik.Ime == s)
                                {
                                    kolo.Komponente.Add(otpornik);
                                }
                            }
                            foreach (SerijskaVezaN serija in serijskeVezeN)
                            {
                                if (serija.Ime == s)
                                {
                                    kolo.Komponente.Add(serija);
                                }
                            }
                            foreach (ParalelnaVezaN paralelna in paralelneVezeN)
                            {
                                if (paralelna.Ime == s)
                                {
                                    kolo.Komponente.Add(paralelna);
                                }
                            }
                            foreach (Kalem kalem in kalemi)
                            {
                                if (kalem.Ime == s)
                                {
                                    kolo.Komponente.Add(kalem);
                                }
                            }
                            foreach (Kondenzator kondenzator in kondenzatori)
                            {
                                if (kondenzator.Ime == s)
                                {
                                    kolo.Komponente.Add(kondenzator);
                                }
                            }
                        }
                    }
                    brojaclinija++;
                }
            }
            }
        private void Simulacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Simulacija_Load(object sender, EventArgs e)
        {
            this.Width = 1200;
            this.Height = 800;
            timer1.Interval = Period;
            
            SetSize();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.loading.Show();
        }

        private void Simulacija_ResizeEnd(object sender, EventArgs e)
        {
            SetSize();
        }
		public void SetSize()
		{
			btnNazad.SetBounds( Width - Width / 12, Height / 50, Width / 17, Width / 17 );
			btnNazad.Font = new Font( "", Width / 50, FontStyle.Bold );

			//namestanje picture boxova
			int pbxWidth = 10*Width/17;
			int yDrugogpbx = ClientSize.Height - ClientSize.Height/20 - pbxWidth/5;
			int visinaPrvogPbx = yDrugogpbx - ClientSize.Height/10;
			pbxPrvi.SetBounds( Width/20, ClientSize.Height/20, pbxWidth, visinaPrvogPbx );
			pbxDrugi.SetBounds( Width/20, yDrugogpbx, pbxWidth, pbxWidth/5 );

			//namestanje buttona
			int btnWidth = Width/10;
			int btnHeight = Height/10;
			int velicinaFonta = Height/50;
			bttnStartStop.SetBounds( pbxWidth + Width/10, Height/20, btnWidth, btnHeight );
			bttnStartStop.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			bttnReset.SetBounds( pbxWidth + Width/5, Height/20, btnWidth, btnHeight );
			bttnReset.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			btnIzaberiKolo.SetBounds( pbxWidth + Width/10, Height/17 + btnHeight, btnWidth*2, btnHeight/2 );
			btnIzaberiKolo.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );

			//namestanje track barova
			int tbWidth = Width/5;
			int tbHeight = Height/5;
			int xtb = pbxWidth + Width/10;
			int ytb = Height/5 + btnHeight;
			int razmakIzmedjuTb = Height/6;
			tbNapon.SetBounds( xtb, ytb, tbWidth, tbHeight );
			tbKondenzator.SetBounds( xtb, ytb + razmakIzmedjuTb, tbWidth, tbHeight );
			tbKalem.SetBounds( xtb, ytb + razmakIzmedjuTb * 2, tbWidth, tbHeight );
			tbOtpornik.SetBounds( xtb, ytb + razmakIzmedjuTb * 3, tbWidth, tbHeight );

			//namestanje labela za track barove
			int yProvgLabela = 10*Height/65 + btnHeight;
			lblNapon.SetBounds( xtb, yProvgLabela, tbWidth, tbHeight );
			lblNapon.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblKondenzator.SetBounds( xtb, yProvgLabela + razmakIzmedjuTb, tbWidth, tbHeight );
			lblKondenzator.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblKalem.SetBounds( xtb, yProvgLabela + razmakIzmedjuTb * 2, tbWidth, tbHeight );
			lblKalem.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
			lblOtpornik.SetBounds( xtb, yProvgLabela + razmakIzmedjuTb * 3, tbWidth, tbHeight );
			lblOtpornik.Font = new Font( "Times New Roman", velicinaFonta, FontStyle.Bold );
		}
		public void PravljenjeFunkcije(int i0, int u0, int w)
        {
            double u = u0 * Math.Sin(w * brojac);
            double i = i0 * Math.Sin(w * brojac - brojac);
            double uProslo = u0 * Math.Sin(w * (brojac - 1));
            double iProslo = i0 * Math.Sin(w * (brojac - 1) - (brojac - 1));

        }
        private void pb1_Click(object sender, EventArgs e)
        {
        }

        private void pb2_Click(object sender, EventArgs e)
        {

        }

        private void pb3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brojac++;
            phase += 15;
            if (phase >= int.MaxValue)
            {
                phase = 0;
            }
            CrtanjeGrafika();
        }

        private void pb1_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1, (float)uProslo, brojac, (float)u);
            e.Graphics.DrawLine(olovka, brojac - 1, (float)iProslo, brojac, (float)i);
        }

        private void pb2_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1, (float)uProslo, brojac, (float)u);
            e.Graphics.DrawLine(olovka, brojac - 1, (float)iProslo, brojac, (float)i);
        }

        private void pb3_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1, (float)uProslo, brojac, (float)u);
            e.Graphics.DrawLine(olovka, brojac - 1, (float)iProslo, brojac, (float)i);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (izbor.ShowDialog()==DialogResult.OK)
            {  
                int brojaclinija = 0;
                StreamReader sr = new StreamReader(izbor.izabranoKolo);
              
                string vrstaStruje = sr.ReadLine();
                if (vrstaStruje == "J")
                {
                    while (!sr.EndOfStream)
                    {
                        string t = sr.ReadLine();
                        string[] split1 = t.Split();
                        if (split1[0] == "o")
                        {
                            otporniciJ.Add(new Otpornik<Srebro>(split1[1], double.Parse(split1[2])));
                        }
                        else if (split1[0] == "b")
                        {
                            baterijeJ.Add(new Baterija(split1[1], double.Parse(split1[2])));
                        }
                        else if (split1[0] == "s")
                        {
                            string[] split2 = split1[2].Split('-');
                            SerijskaVeza<Srebro> privremena = new SerijskaVeza<Srebro>(split1[1]);
                            foreach (string s in split2)
                            {
                                foreach (Otpornik<Srebro> otpornik in otporniciJ)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        privremena.DodajKomponentu(otpornik);
                                    }
                                }
                                foreach (Baterija b in baterijeJ)
                                {
                                    if (b.Ime == s)
                                    {
                                        privremena.DodajKomponentu(b);
                                    }
                                }
                                foreach (SerijskaVeza<Srebro> serija in serijskeVezeJ)
                                {
                                    if (serija.Ime == s)
                                    {
                                        privremena.DodajKomponentu(serija);
                                    }
                                }
                                foreach (ParalelnaVeza<Srebro> paralelna in paralelneVezeJ)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        privremena.DodajKomponentu(paralelna);
                                    }
                                }
                            }
                            serijskeVezeJ.Add(privremena);
                        }
                        else if (split1[0] == "p")
                        {
                            string[] split2 = split1[2].Split('-');
                            ParalelnaVeza<Srebro> privremena = new ParalelnaVeza<Srebro>(split1[1]);
                            foreach (string s in split2)
                            {
                                foreach (Otpornik<Srebro> otpornik in otporniciJ)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        privremena.DodajKomponentu(otpornik);
                                    }
                                }
                                foreach (Baterija b in baterijeJ)
                                {
                                    if (b.Ime == s)
                                    {
                                        privremena.DodajKomponentu(b);
                                    }
                                }
                                foreach (SerijskaVeza<Srebro> serija in serijskeVezeJ)
                                {
                                    if (serija.Ime == s)
                                    {
                                        privremena.DodajKomponentu(serija);
                                    }
                                }
                                foreach (ParalelnaVeza<Srebro> paralelna in paralelneVezeJ)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        privremena.DodajKomponentu(paralelna);
                                    }
                                }
                            }
                            paralelneVezeJ.Add(privremena);
                        }
                        brojaclinija++;



                        foreach (SerijskaVeza<Srebro> glavna1 in serijskeVezeJ)
                        {
                            if (glavna1.Ime == "glavna")
                            {
                                glavna = glavna1;
                            }
                        }
                    }
                }
                else if (vrstaStruje == "N")
                {
                    napon = double.Parse(sr.ReadLine());
                    frekvencija = double.Parse(sr.ReadLine());
                    while (!sr.EndOfStream)
                    {
                        string t = sr.ReadLine();
                        string[] split1 = t.Split();
                        if (split1[0] == "o")
                        {
                            otporniciN.Add(new OtpornikN { Ime = split1[1], Otpor = double.Parse(split1[2]) });
                        }
                        else if (split1[0] == "kondenzator")
                        {
                            kondenzatori.Add(new Kondenzator { Ime = split1[1], Kapacitet = double.Parse(split1[2]) });
                        }
                        else if (split1[0] == "kalem")
                        {
                            kalemi.Add(new Kalem { Ime = split1[1], Induktivnost = double.Parse(split1[2]) });
                        }

                        else if (split1[0] == "s")
                        {
                            string[] split2 = split1[2].Split('-');
                            SerijskaVezaN privremena = new SerijskaVezaN { Ime = split1[1],Komponente = new List<KomponentaNaizmenicna>() };
                            foreach (string s in split2)
                            {
                                foreach (OtpornikN otpornik in otporniciN)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        privremena.Komponente.Add(otpornik);
                                    }
                                }
                                foreach (SerijskaVezaN serija in serijskeVezeN)
                                {
                                    if (serija.Ime == s)
                                    {
                                        privremena.Komponente.Add(serija);
                                    }
                                }
                                foreach (ParalelnaVezaN paralelna in paralelneVezeN)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        privremena.Komponente.Add(paralelna);
                                    }
                                }
                                foreach (Kalem kalem in kalemi)
                                {
                                    if (kalem.Ime == s)
                                    {
                                        privremena.Komponente.Add(kalem);
                                    }
                                }
                                foreach (Kondenzator kondenzator in kondenzatori)
                                {
                                    if (kondenzator.Ime == s)
                                    {
                                        privremena.Komponente.Add(kondenzator);
                                    }
                                }
                            }
                            serijskeVezeN.Add(privremena);
                        }
                        else if (split1[0] == "p")
                        {
                            string[] split2 = split1[2].Split('-');
                            ParalelnaVezaN privremena = new ParalelnaVezaN { Ime = split1[1],Komponente=new List<KomponentaNaizmenicna>()};
                            foreach (string s in split2)
                            {
                                foreach (OtpornikN otpornik in otporniciN)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        privremena.Komponente.Add(otpornik);
                                    }
                                }
                                foreach (SerijskaVezaN serija in serijskeVezeN)
                                {
                                    if (serija.Ime == s)
                                    {
                                        privremena.Komponente.Add(serija);
                                    }
                                }
                                foreach (ParalelnaVezaN paralelna in paralelneVezeN)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        privremena.Komponente.Add(paralelna);
                                    }
                                }
                                foreach (Kalem kalem in kalemi)
                                {
                                    if (kalem.Ime == s)
                                    {
                                        privremena.Komponente.Add(kalem);
                                    }
                                }
                                foreach (Kondenzator kondenzator in kondenzatori)
                                {
                                    if (kondenzator.Ime == s)
                                    {
                                        privremena.Komponente.Add(kondenzator);
                                    }
                                }
                            }
                            paralelneVezeN.Add(privremena);
                        }
                        else if (split1[0] == "kolo")
                        {
                            string[] split2 = split1[2].Split('-');
                            kolo = new KoloNaizmenica { Komponente=new List<KomponentaNaizmenicna>() };
                            foreach (string s in split2)
                            {
                                foreach (OtpornikN otpornik in otporniciN)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        kolo.Komponente.Add(otpornik);
                                    }
                                }
                                foreach (SerijskaVezaN serija in serijskeVezeN)
                                {
                                    if (serija.Ime == s)
                                    {
                                        kolo.Komponente.Add(serija);
                                    }
                                }
                                foreach (ParalelnaVezaN paralelna in paralelneVezeN)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        kolo.Komponente.Add(paralelna);
                                    }
                                }
                                foreach (Kalem kalem in kalemi)
                                {
                                    if (kalem.Ime == s)
                                    {
                                        kolo.Komponente.Add(kalem);
                                    }
                                }
                                foreach (Kondenzator kondenzator in kondenzatori)
                                {
                                    if (kondenzator.Ime == s)
                                    {
                                        kolo.Komponente.Add(kondenzator);
                                    }
                                }
                            }

                        }
                        brojaclinija++;
                    }
                }
                if (izbor.izabranoKolo == "kolo1.txt")
                {
                   pbxPrvi.Image=Properties.Resources.RednoKolo;
                }
                else if(izbor.izabranoKolo == "kolo2.txt")
                {
                    pbxPrvi.Image = Properties.Resources.ParalelnoKolo;
                }
                else if (izbor.izabranoKolo == "kolo3.txt")
                {
                    pbxPrvi.Image = Properties.Resources.PrikazKola;
                }
                else if (izbor.izabranoKolo == "kolo4.txt")
                {
                    pbxPrvi.Image = Properties.Resources.Kolo4;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            kondenzatori[0].Kapacitet = tbNapon.Value;
            NapraviNovoKolo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulacija nova = new Simulacija();
            nova.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //forma za biranje kola
        }
        private void CrtanjeGrafika()
        {
            if (serijskeVezeJ.Count != 0||paralelneVezeJ.Count!=0||serijskeVezeN.Count!=0||paralelneVezeN.Count!=0)
            {
                Bitmap bmp = new Bitmap(500, 100);
                Graphics g = Graphics.FromImage(bmp);
                Pen naponPen = new Pen(Color.Blue);
                Pen strujaPen = new Pen(Color.Red);
                int halfHeight = PictureBoxHeight / 2;

                // Draw Voltage Wave
                int xPrevVoltage = 0;
                int yPrevVoltage = halfHeight - (int)(3 * napon * Math.Sin(2 * frekvencija * Math.PI / 180));
                for (int x = 1; x < PictureBoxWidth; x++)
                {
                    int yVoltage = halfHeight - (int)(3 * napon * Math.Sin(2 * Math.PI * x / WaveLength + phase * Math.PI / 180));
                    g.DrawLine(naponPen, xPrevVoltage, yPrevVoltage, x, yVoltage);
                    xPrevVoltage = x;
                    yPrevVoltage = yVoltage;
                }

                // Draw Current Wave
                int xPrevCurrent = 0;
                int yPrevCurrent = halfHeight - (int)(2* napon * Math.Sin(2 * frekvencija * Math.PI / 180 + kolo.Faza(5 * napon, frekvencija, otporniciN[0].Otpor)));
                for (int x = 1; x < PictureBoxWidth; x++)
                {
                    int yCurrent = halfHeight - (int)( 2*napon * Math.Sin(2 * Math.PI * x / WaveLength + phase * Math.PI / 180 + kolo.Faza(5 * napon, frekvencija, otporniciN[0].Otpor)));
                    g.DrawLine(strujaPen, xPrevCurrent, yPrevCurrent, x, yCurrent);
                    xPrevCurrent = x;
                    yPrevCurrent = yCurrent;
                }
                pbxDrugi.Image = bmp;
                pbxDrugi.Invalidate();
            }
        }
        private void pb3_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
    }
}
