using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class SerijskaVezaN : KomponentaNaizmenicna
    {
        public List<KomponentaNaizmenicna> Komponente { get; set; }

        public override Complex Impedansa(double frk)
        {
            Complex ukupnaImpedanca = Complex.Zero;
            foreach (var komponenta in Komponente)
            {
                ukupnaImpedanca += komponenta.Impedansa(frk);
            }
            return ukupnaImpedanca;
        }
    }
}
