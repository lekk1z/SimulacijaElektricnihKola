﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    internal class Otpornik<TMaterijal> : Komponenta where TMaterijal:IMaterijali<TMaterijal>
    {
        double duzina;
        double poluprecnik;
        TMaterijal materijal;
        public Otpornik(double duzina, double poluprecnik, string ime):base(ime)
        {
            this.duzina = duzina;
            this.poluprecnik = poluprecnik;
        }
        public override double IzracunajOtpor()
        {
            return materijal.specificnaOtpornost * (duzina / (poluprecnik * poluprecnik * Math.PI));
        }
    }
}
