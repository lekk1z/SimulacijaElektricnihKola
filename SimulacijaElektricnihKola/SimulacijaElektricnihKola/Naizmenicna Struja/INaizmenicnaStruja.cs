using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola.Naizmenicna_Struja
{
    internal interface INaizmenicnaStruja
    {
        double naponAmplituda {  get;  }
        double strujaAmplituda {  get;  }
        double frekvencija {  get;  }
        double IzracunajEMS();
        double IzracunajKolicinuToplote(TimeSpan t);


    }
}
