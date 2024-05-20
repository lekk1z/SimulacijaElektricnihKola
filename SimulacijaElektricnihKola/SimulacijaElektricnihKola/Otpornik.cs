using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    internal class Otpornik<TMaterijal> : Komponenta where TMaterijal:IMaterijali
    {
        double duzina;
        double poluprecnik;
        TMaterijal materijal;
        double otporvrednost;

        public double OtporVrednost { get => otporvrednost; set => otporvrednost = value; }

        public Otpornik(double duzina, double poluprecnik, string ime):base(ime)
        {
            this.duzina = duzina;
            this.poluprecnik = poluprecnik;
        }
        public Otpornik(Otpornik<TMaterijal> otpornik):base(otpornik.Ime)
        {
            otpornik.duzina=this.duzina;
            otpornik.poluprecnik=this.poluprecnik;
            otpornik.materijal=this.materijal;
            
        }
        public Otpornik(string ime, double otpor) : base(ime)
        {
            OtporVrednost = otpor;
        }
        public double IzracunajOtpor()
        {
            return materijal.specificnaOtpornost * (duzina / (poluprecnik * poluprecnik * Math.PI));
        }
    }
}
