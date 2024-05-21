using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class SerijskaVeza<TMaterijal> : Veza where TMaterijal:IMaterijali
    {
        public SerijskaVeza(string ime) : base(ime) { }

        public override double IzracunajOtpor()
        {
            double ukupanOtpor = 0;
            foreach (var komponenta in Komponente)
            {
                if (komponenta is Otpornik<TMaterijal>)
                {
                    ukupanOtpor += ((Otpornik<TMaterijal>)komponenta).OtporVrednost;
                }
                else if (komponenta is Veza)
                {
                    ukupanOtpor += ((Veza)komponenta).IzracunajOtpor();
                }
            }
            return ukupanOtpor;
        }

        public override double IzracunajUkupanNapon()
        {
            double ukupanNapon = 0;
            foreach (var komponenta in Komponente)
            {
                if (komponenta is Baterija)
                {
                    ukupanNapon += ((Baterija)komponenta).Napon;
                }
                else if (komponenta is Veza)
                {
                    ukupanNapon += ((Veza)komponenta).IzracunajUkupanNapon();
                }
            }
            return ukupanNapon;
        }

    }
}
