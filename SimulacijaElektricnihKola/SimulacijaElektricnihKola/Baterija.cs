using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    public class Baterija : Komponenta
    {
        public double Napon { get; set; }
        public Baterija(string ime, double napon) : base(ime)
        {
            Napon = napon;
        }
    }
}
