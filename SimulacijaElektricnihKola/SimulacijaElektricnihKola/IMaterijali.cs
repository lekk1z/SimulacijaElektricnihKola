using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacijaElektricnihKola
{
    internal interface IMaterijali<TMaterijali>
    {
        double specificnaOtpornost {  get; }
    }
}
