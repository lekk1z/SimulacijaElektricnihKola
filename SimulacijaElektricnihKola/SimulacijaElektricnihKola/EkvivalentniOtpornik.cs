using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    internal class EkvivalentniOtpornik<TMaterijal>:Otpornik<TMaterijal> where TMaterijal:IMaterijali
    {
        List<Otpornik<TMaterijal>> otpornici;
        public void DodajOtpornik(Otpornik<TMaterijal> novi)
        {
            otpornici.Add(novi);
        }
        public void UkloniOtpornik(Otpornik<TMaterijal> skloni)
        {
            otpornici.Remove(skloni);
        }
        public EkvivalentniOtpornik(params Otpornik<TMaterijal>[] otporniks) : base(otporniks[0])
        {
            foreach(Otpornik<TMaterijal> otpornik in otporniks)
            {
                DodajOtpornik(otpornik);
            }
        }
    }
}
