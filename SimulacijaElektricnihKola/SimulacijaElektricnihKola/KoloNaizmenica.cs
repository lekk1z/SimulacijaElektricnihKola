using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class KoloNaizmenica
    {
        public KomponentaNaizmenicna[] Komponete { get; set; }

        public Complex IzracunajImpedansu(double frk)
        {
            Complex ukupnaImpedansa = Complex.Zero;
            foreach (var komponenta in Komponete)
            {
                ukupnaImpedansa += komponenta.Impedansa(frk);
            }
            return ukupnaImpedansa;
        }

        public double IzracunajTrenutnuStruju(double napon, double frk)
        {
            Complex ukupnaImpedansa = IzracunajImpedansu(frk);
            Complex trenutno = napon / ukupnaImpedansa;
            return trenutno.Magnitude;
        }
        public double Faza(double amplitudaNapona,double frk)
        {
            double realniOdnos = amplitudaNapona / IzracunajTrenutnuStruju(amplitudaNapona,frk);
            double faza = Math.Acos(IzracunajImpedansu(frk).Real / realniOdnos);
            return faza;
        }
    }
}
