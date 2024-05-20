using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class Otpor : Komponenta
    {
        public double OtporVrednost { get; set; }
        public Otpor(string ime, double otpor) : base(ime)
        {
            OtporVrednost = otpor;
        }
    }
 
}
