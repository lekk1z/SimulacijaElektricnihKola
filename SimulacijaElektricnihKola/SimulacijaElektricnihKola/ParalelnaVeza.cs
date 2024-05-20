using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class ParalelnaVeza : Veza
    {
        public ParalelnaVeza(string ime) : base(ime) { }

        public override double IzracunajUkupanOtpor()
        {
            double recipročniOtpor = 0;
            foreach (var komponenta in Komponente)
            {
                if (komponenta is Otpor)
                {
                    recipročniOtpor += 1 / ((Otpor)komponenta).OtporVrednost;
                }
                else if (komponenta is Veza)
                {
                    recipročniOtpor += 1 / ((Veza)komponenta).IzracunajUkupanOtpor();
                }
            }
            return 1 / recipročniOtpor;
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
