using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
        private const int DuzinaTalasa = 50;
        private const int Period = 100;

        private double otpornikA;
        private double kalemA;
        private double kondenzatorA;

        private int phase = 0;
         List<Otpornik<Srebro>> otporniciJ = new List<Otpornik<Srebro>>();
         List<SerijskaVeza<Srebro>> serijskeVezeJ = new List<SerijskaVeza<Srebro>>();
         List<ParalelnaVeza<Srebro>> paralelneVezeJ = new List<ParalelnaVeza<Srebro>>();
         List<Baterija> baterijeJ = new List<Baterija>();
         SerijskaVeza<Srebro> glavna = new SerijskaVeza<Srebro>("glavna");

         KoloNaizmenica kolo = new KoloNaizmenica();
         List<Kondenzator> kondenzatori = new List<Kondenzator>();
         List<OtpornikN> otporniciN = new List<OtpornikN>();
         List<Kalem> kalemi = new List<Kalem>();
         List<SerijskaVezaN> serijskeVezeN = new List<SerijskaVezaN>();
         List<ParalelnaVezaN> paralelneVezeN = new List<ParalelnaVezaN>();
         string vrstastruje;
         double napon;
         double frekvencija;

        public static IzborKola izbor = new IzborKola();
        //*aleksa
        public Simulacija()
        {
            InitializeComponent();
        }
        private void NapraviNovoKolo()
        {
            int brojaclinija = 0;
            StreamReader sr = new StreamReader(izbor.izabranoKolo);
            string vrstaStruje = sr.ReadLine();
            serijskeVezeJ = new List<SerijskaVeza<Srebro>>();
            paralelneVezeJ = new List<ParalelnaVeza<Srebro>>();
            glavna = new SerijskaVeza<Srebro>("glavna");

            serijskeVezeN = new List<SerijskaVezaN>();
            paralelneVezeN = new List<ParalelnaVezaN>();
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
                frekvencija = double.Parse(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    string t = sr.ReadLine();
                    string[] split1 = t.Split();
                    if (split1[0] == "s")
                    {
                        string[] split2 = split1[2].Split('-');
                        SerijskaVezaN privremena = new SerijskaVezaN { Ime = split1[1], Komponente = new List<KomponentaNaizmenicna>() };
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
                        ParalelnaVezaN privremena = new ParalelnaVezaN { Ime = split1[1], Komponente = new List<KomponentaNaizmenicna>() };
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
                        kolo = new KoloNaizmenica { Komponente=new List<KomponentaNaizmenicna>()};
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
            tbxJacinaStruje.Hide();
            timer1.Interval = Period;
            SetSize();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoadingScreen.loading.Show();
        }

        private void Simulacija_ResizeEnd(object sender, EventArgs e)
        {
            SetSize();
        }
        public void SetSize()
        {
            btnNazad.SetBounds(Width - Width / 12, Height / 50, Width / 17, Width / 17);
            btnNazad.Font = new Font("", Width / 50, FontStyle.Bold);

            //namestanje picture boxova
            int pbxWidth = 10 * Width / 17;
            int yDrugogpbx = ClientSize.Height - ClientSize.Height / 20 - pbxWidth / 5;
            int visinaPrvogPbx = yDrugogpbx - ClientSize.Height / 10;
            pbxPrvi.SetBounds(Width / 20, ClientSize.Height / 20, pbxWidth, visinaPrvogPbx);
            pbxDrugi.SetBounds(Width / 20, yDrugogpbx, pbxWidth, pbxWidth / 5);

            //namestanje buttona
            int btnWidth = Width / 10;
            int btnHeight = Height / 10;
            int velicinaFonta = Height / 50;
            bttnStartStop.SetBounds(pbxWidth + Width / 10, Height / 20, btnWidth, btnHeight);
            bttnStartStop.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
            bttnReset.SetBounds(pbxWidth + Width / 5, Height / 20, btnWidth, btnHeight);
            bttnReset.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
            btnIzaberiKolo.SetBounds(pbxWidth + Width / 10, Height / 17 + btnHeight, btnWidth * 2, btnHeight / 2);
            btnIzaberiKolo.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);

            //namestanje track barova
            int tbWidth = Width / 5;
            int tbHeight = Height / 5;
            int xtb = pbxWidth + Width / 10;
            int ytb = Height / 5 + btnHeight;
            int razmakIzmedjuTb = Height / 6;
            tbNapon.SetBounds(xtb, ytb, tbWidth, tbHeight);
            tbKondenzator.SetBounds(xtb, ytb + razmakIzmedjuTb, tbWidth, tbHeight);
            tbKalem.SetBounds(xtb, ytb + razmakIzmedjuTb * 2, tbWidth, tbHeight);
            tbOtpornik.SetBounds(xtb, ytb + razmakIzmedjuTb * 3, tbWidth, tbHeight);

            //namestanje labela za track barove
            int yProvgLabela = 10 * Height / 65 + btnHeight;
            lblNapon.SetBounds(xtb, yProvgLabela, tbWidth, tbHeight);
            lblNapon.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
            lblKondenzator.SetBounds(xtb, yProvgLabela + razmakIzmedjuTb, tbWidth, tbHeight);
            lblKondenzator.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
            lblKalem.SetBounds(xtb, yProvgLabela + razmakIzmedjuTb * 2, tbWidth, tbHeight);
            lblKalem.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);
            lblOtpornik.SetBounds(xtb, yProvgLabela + razmakIzmedjuTb * 3, tbWidth, tbHeight);
            lblOtpornik.Font = new Font("Times New Roman", velicinaFonta, FontStyle.Bold);

            //textbox za jacinu struje
            tbxJacinaStruje.SetBounds(Width/20, ClientSize.Height/40, Width/15, ClientSize.Height/20 );
            tbxJacinaStruje.Font = new Font( "Times New Roman", ClientSize.Height/40, FontStyle.Regular );
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            phase += 15;
            if (phase >= int.MaxValue)
            {
                phase = 0;
            }
            if (izbor.izabranoKolo == "kolo4.txt")
            {
                GrafikJednosmerneStruje(glavna.IzracunajStruju().ToString());
            }
            else
            {
                tbxJacinaStruje.Hide();
                CrtanjeGrafika();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (izbor.ShowDialog() == DialogResult.OK)
            {

                int brojaclinija = 0;
                StreamReader sr = new StreamReader(izbor.izabranoKolo);
                  otporniciJ = new List<Otpornik<Srebro>>();
              serijskeVezeJ = new List<SerijskaVeza<Srebro>>();
                 paralelneVezeJ = new List<ParalelnaVeza<Srebro>>();
                baterijeJ = new List<Baterija>();
                  glavna = new SerijskaVeza<Srebro>("glavna");

                 kolo = new KoloNaizmenica();
                 kondenzatori = new List<Kondenzator>();
                 otporniciN = new List<OtpornikN>();
                 kalemi = new List<Kalem>();
                serijskeVezeN = new List<SerijskaVezaN>();
                 paralelneVezeN = new List<ParalelnaVezaN>();
                string vrstaStruje = sr.ReadLine();
                if (vrstaStruje == "J")
                {
                    tbNapon.Enabled = false;
                    lblKondenzator.Text = "Otpornik 1";
                    lblKalem.Text = "Otpornik 2";
                    lblOtpornik.Text = "Otpornik 3";
                    vrstastruje = "J";
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
                    vrstastruje = "N";
                    tbNapon.Enabled = true;
                    lblKondenzator.Text = "Kondenzator";
                    lblKalem.Text = "Induktivni kalem";
                    lblOtpornik.Text = "Otpornik";
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
                            SerijskaVezaN privremena = new SerijskaVezaN { Ime = split1[1], Komponente = new List<KomponentaNaizmenicna>() };
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
                            ParalelnaVezaN privremena = new ParalelnaVezaN { Ime = split1[1], Komponente = new List<KomponentaNaizmenicna>() };
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
                            kolo = new KoloNaizmenica { Komponente = new List<KomponentaNaizmenicna>() };
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
                    otpornikA = otporniciN[0].Otpor;
                    kondenzatorA = kondenzatori[0].Kapacitet;
                    kalemA = kalemi[0].Induktivnost;
                    tbNapon.Minimum = (int)napon;
                }

                if (izbor.izabranoKolo == "kolo1.txt")
                {
                    pbxPrvi.Image = Properties.Resources.RednoKolo;
                }
                else if (izbor.izabranoKolo == "kolo2.txt")
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
        public void GrafikJednosmerneStruje(string tekstZaPrikaz) //treba poslati struju.ToString
        {
			tbxJacinaStruje.Show();
            tbxJacinaStruje.Text += tekstZaPrikaz;
			Bitmap bmp = new Bitmap(500, 100);
            double struja=glavna.IzracunajStruju();
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawLine(new Pen(Color.Red), new Point(0, (int)(50 * struja * 10)),new Point(500, (int)(50 * struja * 10)));
                // Kreiranje fonta i četkice za crtanje teksta
            }

            pbxDrugi.Image = bmp;
            pbxDrugi.Invalidate();
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
        private void CrtanjeGrafika()
        {
            if (serijskeVezeJ.Count != 0 || paralelneVezeJ.Count != 0 || serijskeVezeN.Count != 0 || paralelneVezeN.Count != 0)
            {
                Bitmap bmp = new Bitmap(500, 100);
                Graphics g = Graphics.FromImage(bmp);
                Pen naponPen = new Pen(Color.Blue);
                Pen strujaPen = new Pen(Color.Red);
                int halfHeight = PictureBoxHeight / 2;

                // Draw Voltage Wave
                
                int xPrevVoltage = 0;
                int yPrevVoltage = halfHeight - (int)( napon * Math.Sin(2 * frekvencija * Math.PI / 180));
                for (int x = 1; x < PictureBoxWidth; x++)
                {
                    int yVoltage = halfHeight - (int)( napon * Math.Sin(2 * Math.PI * x / DuzinaTalasa + phase * Math.PI / 180));
                    g.DrawLine(naponPen, xPrevVoltage, yPrevVoltage, x, yVoltage);
                    xPrevVoltage = x;
                    yPrevVoltage = yVoltage;
                }
                
                if (izbor.izabranoKolo == "kolo2.txt")
                {
                    double faza = Math.Atan(otporniciN[0].Otpor * (2 * Math.PI * frekvencija * kondenzatori[0].Kapacitet - 1 / (2 * Math.PI * frekvencija * kalemi[0].Induktivnost)));
                    int xPrevCurrent = 0;
                    int oduzmi = (int)(kolo.IzracunajTrenutnuStruju(napon, frekvencija) * Math.Sin(2 * frekvencija * Math.PI / 180 + faza));
                    int yPrevCurrent = halfHeight - oduzmi;
                    for (int x = 1; x < PictureBoxWidth; x++)
                    {
                        double oduzmi2 = (kolo.IzracunajTrenutnuStruju(napon, frekvencija) * Math.Sin(2 * Math.PI * x / DuzinaTalasa + phase * Math.PI / 180 + faza));
                        int yCurrent = halfHeight - (int)oduzmi2;
                        g.DrawLine(strujaPen, xPrevCurrent, yPrevCurrent, x, yCurrent);
                        xPrevCurrent = x;
                        yPrevCurrent = yCurrent;
                    }
                    pbxDrugi.Image = bmp;
                    pbxDrugi.Invalidate();
                }
                else
                {
                    double faza = kolo.Faza(napon, frekvencija, otporniciN[0].Otpor);
                    double struja = kolo.IzracunajTrenutnuStruju(napon, frekvencija)*1000;
                    int xPrevStruja = 0;
                    int yPrevStruja = halfHeight - (int)(struja* Math.Sin(2 * frekvencija * Math.PI / 180+faza));
                    for (int x = 1; x < PictureBoxWidth; x++)
                    {
                        int yStruja = halfHeight - (int)(struja * Math.Sin(2 * Math.PI * x / DuzinaTalasa + phase * Math.PI / 180+faza));
                        g.DrawLine(strujaPen, xPrevStruja, yPrevStruja, x, yStruja);
                        xPrevStruja = x;
                        yPrevStruja = yStruja;
                    }
                    pbxDrugi.Image = bmp;
                    pbxDrugi.Invalidate();
                }
                    
            }
        }
        private void tbNapon_ValueChanged(object sender, EventArgs e)
        {
            if (vrstastruje == "N")
            {
                napon = (int)tbNapon.Value;
                NapraviNovoKolo();
            }
            
        }

        private void tbKondenzator_ValueChanged(object sender, EventArgs e)
        {
            /*
            timer1.Stop();
            if (vrstastruje == "N")
            {
                kondenzatori[0].Kapacitet = kondenzatorA * tbKondenzator.Value/100;
                
            }
            else if (vrstastruje == "J")
            {
                otporniciJ[0].OtporVrednost = kondenzatorA * tbKondenzator.Value/100;
            }
            NapraviNovoKolo();
            timer1.Start();
            */
        }

        private void tbKalem_ValueChanged(object sender, EventArgs e)
        {
            /*
            timer1.Stop();
            if (vrstastruje == "N")
            {
                kalemi[0].Induktivnost = kalemA* tbKalem.Value/100;

            }
            else if (vrstastruje == "J")
            {
                otporniciJ[0].OtporVrednost =kalemA * tbKalem.Value/100;
            }
            NapraviNovoKolo();
            timer1.Start();
            */
        }

        private void tbOtpornik_ValueChanged(object sender, EventArgs e)
        {
            /*
            timer1.Stop();
            if (vrstastruje == "N")
            {
                otporniciN[0].Otpor =otpornikA* tbOtpornik.Value/100;

            }
            else if (vrstastruje == "J")
            {
                otporniciJ[0].OtporVrednost = otpornikA * tbOtpornik.Value /100;
            }
            NapraviNovoKolo();
            timer1.Start();
            */
        }

        private void tbKondenzator_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            if (vrstastruje == "N")
            {
                kondenzatori[0].Kapacitet = kondenzatorA * tbKondenzator.Value;

            }
            else if (vrstastruje == "J")
            {
                otporniciJ[0].OtporVrednost = tbKondenzator.Value*100;
            }
            NapraviNovoKolo();
            timer1.Start();
        }

        private void tbKalem_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            if (vrstastruje == "N")
            {
                kalemi[0].Induktivnost = kalemA * tbKalem.Value;

            }
            else if (vrstastruje == "J")
            {
                otporniciJ[1].OtporVrednost =   tbKalem.Value *100;
            }
            NapraviNovoKolo();
            timer1.Start();
        }

        private void tbOtpornik_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            if (vrstastruje == "N")
            {
                otporniciN[0].Otpor = otpornikA * tbOtpornik.Value;

            }
            else if (vrstastruje == "J")
            {
                otporniciJ[2].OtporVrednost =  tbOtpornik.Value * 100;
            }
            NapraviNovoKolo();
            timer1.Start();
        }
    }
}
