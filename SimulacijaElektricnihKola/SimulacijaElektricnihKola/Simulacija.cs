using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimulacijaElektricnihKola
{
    public partial class Simulacija : Form
    {
        Pen olovka;
       
        static int brojac = 0;
        //aleksa
        static List<Otpornik<Srebro>> otporniciJ = new List<Otpornik<Srebro>>();
        static List<SerijskaVeza<Srebro>> serijskeVezeJ = new List<SerijskaVeza<Srebro>>();
        static List<ParalelnaVeza<Srebro>> paralelneVezeJ = new List<ParalelnaVeza<Srebro>>();
        static List<Baterija> baterijeJ = new List<Baterija>();

        static KoloNaizmenica kolo = new KoloNaizmenica();
        static List<Kondenzator> kondenzatori = new List<Kondenzator>();
        static List<OtpornikN> otporniciN = new List<OtpornikN>();
        static List<Kalem> kalemi = new List<Kalem>();
        static List<SerijskaVezaN> serijskeVezeN = new List<SerijskaVezaN>();
        static List<ParalelnaVezaN> paralelneVezeN = new List<ParalelnaVezaN>();
        static string trenutniTxt;
        //*aleksa
        public Simulacija()
        {
            InitializeComponent();
        }
        private void NapraviNovoKolo()
        {
            int brojaclinija = 0;
            StreamReader sr = new StreamReader(openFileDialog1.FileName);
            while (!sr.EndOfStream)
            {

                string t = sr.ReadLine();
                if (brojaclinija == 0 && t == "J")
                {
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
                    foreach (SerijskaVeza<Srebro> glavna in serijskeVezeJ)
                    {
                        if (glavna.Ime == "glavna")
                        {
                            MessageBox.Show("GLAVNA VEZA: " + glavna.ToString());
                        }
                    }
                }
                else if (t == "N")
                {
                    string[] split1 = t.Split();

                    if (split1[0] == "s")
                    {
                        string[] split2 = split1[2].Split('-');
                        SerijskaVezaN privremena = new SerijskaVezaN { Ime = split1[1] };
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
                        ParalelnaVezaN privremena = new ParalelnaVezaN { Ime = split1[1] };
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
			SetSize();
		}

		private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.loading.Show();
        }

		private void Simulacija_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}
        public void SetSize()
        {
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );
			btnNazad.Font = new Font( "", Width/50, FontStyle.Bold );
		}
        public void PravljenjeFunkcije(int i0,int u0,int w)
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
        }

        private void pb1_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1,(float)uProslo, brojac, (float)u);
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int brojaclinija = 0;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                trenutniTxt = openFileDialog1.FileName;
                while (!sr.EndOfStream)
                {

                    string t = sr.ReadLine();
                    if (brojaclinija == 0 && t == "J")
                    {
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



                        foreach (SerijskaVeza<Srebro> glavna in serijskeVezeJ)
                        {
                            if (glavna.Ime == "glavna")
                            {
                                MessageBox.Show("GLAVNA VEZA: " + glavna.ToString());
                            }
                        }
                    }
                    else if (t == "N")
                    {
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
                            SerijskaVezaN privremena = new SerijskaVezaN { Ime = split1[1] };
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
                            ParalelnaVezaN privremena = new ParalelnaVezaN { Ime = split1[1] };
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
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            kondenzatori[0].Kapacitet = trackBar1.Value;
            NapraviNovoKolo();
        }
    }
}
