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
        Pen olovka;
       
        static int brojac = 0;
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
			this.Width = 1200;
			this.Height = 800;
			SetSize();
		}

		private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1.loading.Show();
        }

		private void Simulacija_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}
        public void SetSize()
        {
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );
			btnNazad.Font = new Font( "", Width/50, FontStyle.Bold );
		}
        public void PravljenjeFunkcije(int i0,int u0,int w)
        {
            double u = u0 * Math.Sin(w * brojac);
            double i = i0 * Math.Sin(w * brojac - brojac);
            double uProslo = u0 * Math.Sin(w * (brojac - 1));
            double iProslo = i0 * Math.Sin(w * (brojac - 1) - (brojac - 1));

        }
        private void pb1_Click(object sender, EventArgs e)
        {
        }

        private void pb2_Click(object sender, EventArgs e)
        {

        }

        private void pb3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brojac++;
        }

        private void pb1_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1,(float)uProslo, brojac, (float)u);
            e.Graphics.DrawLine(olovka, brojac - 1, (float)iProslo, brojac, (float)i);
        }

        private void pb2_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1, (float)uProslo, brojac, (float)u);
            e.Graphics.DrawLine(olovka, brojac - 1, (float)iProslo, brojac, (float)i);
        }

        private void pb3_Paint(object sender, PaintEventArgs e, double u, double i, double uProslo, double iProslo)
        {
            e.Graphics.DrawLine(olovka, brojac - 1, (float)uProslo, brojac, (float)u);
            e.Graphics.DrawLine(olovka, brojac - 1, (float)iProslo, brojac, (float)i);
        }
    }
}
