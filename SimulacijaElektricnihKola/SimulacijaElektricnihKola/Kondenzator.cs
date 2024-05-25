using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class Kondenzator : KomponentaNaizmenicna
    {
        public double Kapacitet { get; set; }

        public override Complex Impedansa(double frk)
        {
            return new Complex(0, -1 / (2 * Math.PI * frk * Kapacitet));
        }
    }
}
