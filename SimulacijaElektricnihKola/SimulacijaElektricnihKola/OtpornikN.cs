using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class OtpornikN : KomponentaNaizmenicna
    {
        public double Otpor { get; set; }

        public override Complex Impedansa(double frk)
        {
            return new Complex(Otpor, 0);
        }
    }
}
