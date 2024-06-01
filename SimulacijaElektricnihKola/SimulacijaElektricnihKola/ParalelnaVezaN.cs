using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class ParalelnaVezaN : KomponentaNaizmenicna
    {
        public List<KomponentaNaizmenicna> Komponente { get; set; }

        public override Complex Impedansa(double frk)
        {
            Complex ukupnaAdmitansa = Complex.Zero;
            foreach (var komponenta in Komponente)
            {
                ukupnaAdmitansa += Complex.Reciprocal(komponenta.Impedansa(frk)); // Admitansa je obrnuta vrednost impedanse
            }
            return Complex.Reciprocal(ukupnaAdmitansa); // Impedansa je obrnuta vrednost od ukupne admitanse
        }
    }
}
