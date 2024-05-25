using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public abstract class KomponentaNaizmenicna
    {
        public string Ime { get; set; }
        public abstract Complex Impedansa(double frk); // Apstraktna metoda za izračunavanje impedanse
    }
}
