﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class ParalelnaVeza<TMaterijal> : Veza where TMaterijal : IMaterijali
    {
        public ParalelnaVeza(string ime) : base(ime) { }

        public override double IzracunajOtpor()
        {
            double recipročniOtpor = 0;
            foreach (var komponenta in Komponente)
            {
                if (komponenta is Otpornik<TMaterijal>)
                {
                    recipročniOtpor += 1 / ((Otpornik<TMaterijal>)komponenta).OtporVrednost;
                }
                else if (komponenta is Veza)
                {
                    recipročniOtpor += 1 / ((Veza)komponenta).IzracunajOtpor();
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
