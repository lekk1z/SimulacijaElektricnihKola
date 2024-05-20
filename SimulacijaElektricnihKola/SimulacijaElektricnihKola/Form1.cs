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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kreiraj komponente
            Baterija baterija1 = new Baterija("Baterija1", 9);  // 9 V baterija
            Otpor otpor1 = new Otpor("Otpor1", 100);  // 100 Ω otpornik
            Otpor otpor2 = new Otpor("Otpor2", 200);  // 200 Ω otpornik

            // Kreiraj serijsku vezu
            SerijskaVeza serijskaVeza = new SerijskaVeza("Serijska veza");
            serijskaVeza.DodajKomponentu(baterija1);
            serijskaVeza.DodajKomponentu(otpor1);
            serijskaVeza.DodajKomponentu(otpor2);

            // Ispis informacija o serijskoj vezi
            maskedTextBox1.Text = serijskaVeza.ToString();

            // Kreiraj paralelnu vezu
            ParalelnaVeza paralelnaVeza = new ParalelnaVeza("Paralelna veza");
            paralelnaVeza.DodajKomponentu(new Otpor("Otpor3", 50));  // 50 Ω otpornik
            paralelnaVeza.DodajKomponentu(new Otpor("Otpor4", 100));  // 100 Ω otpornik

            // Kreiraj kolo koje sadrži serijsku i paralelnu vezu
            SerijskaVeza glavnoKolo = new SerijskaVeza("Glavno kolo");
            glavnoKolo.DodajKomponentu(serijskaVeza);
            glavnoKolo.DodajKomponentu(paralelnaVeza);

            // Ispis informacija o glavnom kolu
            maskedTextBox2.Text =  glavnoKolo.ToString();
        }
    }
}
