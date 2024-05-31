using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacijaElektricnihKola
{
    public partial class Form1 : Form
    {
        public static Form1 forma1= new Form1();
        public static LoadingScreen loading = new LoadingScreen();
        public static Simulacija simulacija=new Simulacija();
        public static Teorija teorija=new Teorija();
        public static Testovi testovi=new Testovi();
        static List<Otpornik<Srebro>> otpornici=new List<Otpornik<Srebro>>();
        static List<SerijskaVeza<Srebro>> serijskeVeze = new List<SerijskaVeza<Srebro>>();
        static List<ParalelnaVeza<Srebro>> paralelneVeze = new List<ParalelnaVeza<Srebro>>();
        static List<Baterija> baterije = new List<Baterija>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            // Kreiraj komponente
            Baterija baterija1 = new Baterija("Baterija1", 9);  // 9 V baterija
            Otpornik<Srebro> otpor1 = new Otpornik<Srebro>("Otpor1", 250);  // 100 Ω otpornik
            Otpornik<Srebro> otpor2 = new Otpornik<Srebro>("Otpor2", 500);  // 200 Ω otpornik

            // Kreiraj serijsku vezu
            SerijskaVeza<Srebro> serijskaVeza = new SerijskaVeza<Srebro>("Serijska veza");
            serijskaVeza.DodajKomponentu(baterija1);
            serijskaVeza.DodajKomponentu(otpor1);
            serijskaVeza.DodajKomponentu(otpor2);

            // Ispis informacija o serijskoj vezi
            maskedTextBox1.Text = serijskaVeza.ToString();

            // Kreiraj paralelnu vezu
            ParalelnaVeza<Srebro> paralelnaVeza = new ParalelnaVeza<Srebro>("Paralelna veza");
            paralelnaVeza.DodajKomponentu(new Otpornik<Srebro>("Otpor3", 50));  // 50 Ω otpornik
            paralelnaVeza.DodajKomponentu(new Otpornik<Srebro>("Otpor4", 100));  // 100 Ω otpornik

            // Kreiraj kolo koje sadrži serijsku i paralelnu vezu
            SerijskaVeza<Srebro> glavnoKolo = new SerijskaVeza<Srebro>("Glavno kolo");
            glavnoKolo.DodajKomponentu(serijskaVeza);
            glavnoKolo.DodajKomponentu(paralelnaVeza);

            // Ispis informacija o glavnom kolu
            maskedTextBox2.Text =  glavnoKolo.ToString();
            */
            // Primer korišćenja klasa
            OtpornikN rezistor1 = new OtpornikN { Ime = "R1", Otpor = 10 }; // Otpornik od 10 oma
            Kondenzator kondenzator= new Kondenzator { Ime = "C1", Kapacitet = 0.000159 }; // Kondenzator od 0.00159 farada
            Kalem kalem = new Kalem { Ime = "L1", Induktivnost = 0.03 }; // Kalem od 0.03 henrija

            double napon = 5;
            double frk = 50; 
            // Kreiranje redne veze komponenata
            SerijskaVezaN srVz1 = new SerijskaVezaN
            {
                Ime = "srVz1",
                Komponente = new KomponentaNaizmenicna[] { rezistor1 }
            };

            // Kreiranje paralelne veze komponenata
            ParalelnaVezaN prlVz1 = new ParalelnaVezaN
            {
                Ime = "prlVz1",
                Komponente = new KomponentaNaizmenicna[] { kondenzator, kalem }
            };

            // Kreiranje kombinovane veze (redna veza koja sadrži paralelnu vezu)
            SerijskaVezaN srVz2 = new SerijskaVezaN
            {
                Ime = "srVz2",
                Komponente = new KomponentaNaizmenicna[] { srVz1, prlVz1 }
            };

            // Kreiranje kola sa kombinovanom vezom
            KoloNaizmenica kolo = new KoloNaizmenica
            {
                Komponete = new KomponentaNaizmenicna[] { srVz2 }
            };

            // Računanje struje u kolu
            double current = kolo.IzracunajTrenutnuStruju(napon, frk);

            // Ispis rezultata
            maskedTextBox2.Text=current.ToString();
        }

        private void btnfajl_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int brojaclinija = 0;
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    while (!sr.EndOfStream)
                    {
                        string t = sr.ReadLine();
                        listBox1.Items.Add(t);
                        string[] split1 =t.Split();
                        if (split1[0] == "o")
                        {
                            otpornici.Add(new Otpornik<Srebro>(split1[1], double.Parse(split1[2])));
                        }
                        else if (split1[0] == "b")
                        {
                            baterije.Add(new Baterija(split1[1], double.Parse(split1[2])));
                        }
                        else if (split1[0] == "s")
                        {
                            string[] split2 = split1[2].Split('-');
                            SerijskaVeza<Srebro> privremena = new SerijskaVeza<Srebro>(split1[1]);
                            foreach(string s in split2)
                            {
                                foreach(Otpornik<Srebro> otpornik in otpornici)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        privremena.DodajKomponentu(otpornik);
                                    }
                                }
                                foreach(Baterija b in baterije)
                                {
                                    if(b.Ime == s)
                                    {
                                        privremena.DodajKomponentu(b);
                                    }
                                }
                                foreach (SerijskaVeza<Srebro> serija in serijskeVeze)
                                {
                                    if (serija.Ime == s)
                                    {
                                        privremena.DodajKomponentu(serija);
                                    }
                                }
                                foreach (ParalelnaVeza<Srebro> paralelna in paralelneVeze)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        privremena.DodajKomponentu(paralelna);
                                    }
                                }
                            }
                            serijskeVeze.Add(privremena);
                        }
                        else if (split1[0] == "p")
                        {
                            string[] split2 = split1[2].Split('-');
                            ParalelnaVeza<Srebro> privremena = new ParalelnaVeza<Srebro>(split1[1]);
                            foreach (string s in split2)
                            {
                                foreach (Otpornik<Srebro> otpornik in otpornici)
                                {
                                    if (otpornik.Ime == s)
                                    {
                                        privremena.DodajKomponentu(otpornik);
                                    }
                                }
                                foreach (Baterija b in baterije)
                                {
                                    if (b.Ime == s)
                                    {
                                        privremena.DodajKomponentu(b);
                                    }
                                }
                                foreach (SerijskaVeza<Srebro> serija in serijskeVeze)
                                {
                                    if(serija.Ime == s)
                                    {
                                        privremena.DodajKomponentu(serija);
                                    }
                                }
                                foreach (ParalelnaVeza<Srebro> paralelna in paralelneVeze)
                                {
                                    if (paralelna.Ime == s)
                                    {
                                        privremena.DodajKomponentu(paralelna);
                                    }
                                }
                            }
                            paralelneVeze.Add(privremena);
                        }
                        else
                        {
                            throw new Exception($"Nepravilan podatak na liniji {brojaclinija}");
                        }
                        brojaclinija++;
                    }
                    foreach(SerijskaVeza<Srebro> glavna in serijskeVeze)
                    {
                        if (glavna.Ime == "glavna")
                        {
                            MessageBox.Show("GLAVNA VEZA: "+glavna.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
		private void button1_Click( object sender, EventArgs e )
		{
            loading.Show();
            this.Hide();
		}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
