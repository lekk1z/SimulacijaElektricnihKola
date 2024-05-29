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
     
    public partial class Teorija: Form
    {
        public Teorija()
        {
            InitializeComponent();
        }
       // loadingscreen formaLS = new loadingscreen();
        private void tbxTeorija_TextChanged( object sender, EventArgs e )
        {
            tbxTeorija.Text = "ovde treba nesto da pise";
        }

        private void btnNazad_Click( object sender, EventArgs e )
        {
            this.Close();
           // formaLS.Show();
           //saska je radila
        }
    }
}
