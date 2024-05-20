using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SimulacijaElektricnihKola
{
    public abstract class Komponenta
    {
        public string Ime { get; }
        public Komponenta(string ime)
        {
            Ime = ime;
        }

       // public abstract double IzracunajOtpor();
    }
}
