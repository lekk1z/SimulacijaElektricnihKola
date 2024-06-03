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
    public partial class IzborKola : Form
    {
        public string izabranoKolo;
        public IzborKola()
        {
            InitializeComponent();

        }

        private void IzborKola_Load(object sender, EventArgs e)
        {
            SetSize();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                izabranoKolo = openFileDialog1.FileName;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            izabranoKolo = "kolo1.txt";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            izabranoKolo = "kolo2.txt";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            izabranoKolo = "kolo3.txt";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            izabranoKolo = "kolo4.txt";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

		private void IzborKola_Resize( object sender, EventArgs e )
		{
            SetSize();
		}
        public void SetSize()
        {
			int bttnWidth = 10 * Width / 36;
			int bttnHeight = 10 * Height / 35;
			int x1, x2, y1, y2; //koordinate za pozicije dugmica
			x1 = Width / 6;
			x2 = 5 * Width / 6 - bttnWidth;
			y1 = Height / 8;
			y2 = 6 * Height / 8 - bttnHeight;
			pbxKolo1.SetBounds( x1, y1, bttnWidth, bttnHeight );
			pbxKolo2.SetBounds( x2, y1, bttnWidth, bttnHeight );
			pbxKolo3.SetBounds( x1, y2, bttnWidth, bttnHeight );
			pbxKolo4.SetBounds( x2, y2, bttnWidth, bttnHeight );
            int btnIzaberiWidth = Width / 6;
            btnIzaberiteKolo.SetBounds( Width/2 - btnIzaberiWidth/2, 8*Height/10, btnIzaberiWidth, Height/10 );
		}
	}
}
