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
    public partial class Simulacija : Form
    {
        public Simulacija()
        {
            InitializeComponent();
        }

        private void Simulacija_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Simulacija_Load(object sender, EventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.loading.Show();
        }
    }
}
