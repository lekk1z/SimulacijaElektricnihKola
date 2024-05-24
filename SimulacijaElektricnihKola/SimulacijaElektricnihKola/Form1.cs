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
    }
}
