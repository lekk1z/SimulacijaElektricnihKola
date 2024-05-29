using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacijaElektricnihKola
{
    public partial class Testovi : Form
    {
        public Testovi()
        {
            InitializeComponent();
            btnNazad.Show();
        }
        // loadingscreen formaLS = new loadingscreen();
        private void btnTest3_Click( object sender, EventArgs e )
        {
            btnTest1.Hide();
            btnTest2.Hide();
            btnTest3.Hide();
            btnTest4.Hide();
        }

        private void btnNazad_Click( object sender, EventArgs e )
        {
            if( btnTest1.Visible && btnTest2.Visible && btnTest3.Visible && btnTest4.Visible ) ;// formaLS.Show();
            else
            {
                btnTest1.Show();
                btnTest2.Show();
                btnTest3.Show();
                btnTest4.Show();
            }
           //saska je radila
        }
    }
}
