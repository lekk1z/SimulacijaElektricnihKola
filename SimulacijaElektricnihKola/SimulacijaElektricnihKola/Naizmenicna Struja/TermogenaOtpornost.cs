using System;

namespace SimulacijaElektricnihKola.Naizmenicna_Struja
{
    internal class TermogenaOtpornost<TMaterijal> : Otpornik<TMaterijal>, INaizmenicnaStruja where TMaterijal : IMaterijali
    {
        public double naponAmplituda { get; }
       public  double naponEfektivna { get { return naponAmplituda / Math.Sqrt(2); } }

        public double strujaAmplituda { get; }
        public double strujaEfektivna { get { return strujaAmplituda / Math.Sqrt(2); } }
        public double frekvencija { get; }
        public double IzracunajEMS()
        {
            return naponEfektivna * strujaEfektivna;
        }
        public double IzracunajKolicinuToplote(TimeSpan t)
        {
            return IzracunajEMS()*t.TotalSeconds;
        }

        public TermogenaOtpornost(double napon, double struja, double frekvencija,double duzina,double poluprecnik, string ime):base(duzina,poluprecnik,ime)
        {
            this.naponAmplituda = napon;
            this.strujaAmplituda = struja;
            this.frekvencija = frekvencija;
        }

        
    }
}
