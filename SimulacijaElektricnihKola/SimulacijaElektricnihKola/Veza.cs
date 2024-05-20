using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public abstract class Veza : Komponenta
    {
        public List<Komponenta> Komponente { get; private set; }

        public Veza(string ime) : base(ime)
        {
            Komponente = new List<Komponenta>();
        }

        public void DodajKomponentu(Komponenta komponenta)
        {
            Komponente.Add(komponenta);
        }

        public abstract double IzracunajUkupanOtpor();
        public abstract double IzracunajUkupanNapon();

        public double IzracunajStruju()
        {
            double ukupanNapon = IzracunajUkupanNapon();
            double ukupanOtpor = IzracunajUkupanOtpor();
            return ukupanOtpor == 0 ? double.PositiveInfinity : ukupanNapon / ukupanOtpor;
        }

        public override string ToString()
        {
            return $"{Ime} - Ukupan otpor: {IzracunajUkupanOtpor()} Ω, Struja: {IzracunajStruju()} A";
        }
    }
}
