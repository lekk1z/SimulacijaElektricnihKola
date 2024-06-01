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
        List <string> upisanaResenja = new List <string> ();
        TextBox unosResenja = new TextBox ();
        public Testovi()
        {
            InitializeComponent();
            btnNazad.Show();
            tbxOpisZadataka.Hide();
        }
        private void Testovi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnNazad_Click(object sender, EventArgs e)
        {
         
            if (btnTest1.Visible || btnTest2.Visible || btnTest3.Visible || btnTest4.Visible)
            {
                this.Visible = false;
                Form1.loading.Show();
            }
            else
            {
                btnTest1.Show();
                btnTest2.Show();
                btnTest3.Show();
                btnTest4.Show();
                tbxOpisZadataka.Hide();
            }
        }
		public void KliknutoDugme()
		{
			btnTest1.Hide();
			btnTest2.Hide();
			btnTest3.Hide();
			btnTest4.Hide();
			tbxOpisZadataka.Clear();
			tbxOpisZadataka.Show();
		}
		private void btnTest1_Click( object sender, EventArgs e )
        {
			KliknutoDugme();

		}
        private void btnTest2_Click( object sender, EventArgs e )
		{
			KliknutoDugme();

		}
        private void btnTest3_Click( object sender, EventArgs e )
        {
            KliknutoDugme();
            tbxOpisZadataka.Text = "Zadatak 3\nU datom kolu:\nR = Xl = 10 Ω\nXc = 20 Ω\nU = 5sin314t(5I\n\nNaci jednacinu struje kroz nerazgranati deo kola (u zavisnosti od vremena).";
            tbxOpisZadataka.Text = $"\n\nPitanja:\n1. Sta u datom kolu predstavlja R?\nR u datom kolu predstavlja {unosResenja}.\n";
            upisanaResenja.Add(unosResenja.Text); 
            tbxOpisZadataka.Text = $"2. Sta u datom kolu predstavlja L?\nL u datom kolu predstavlja{unosResenja}";
			upisanaResenja.Add( unosResenja.Text );
			tbxOpisZadataka.Text = $"3. Sta u datom kolu predstavlja C?\nC u datom kolu predstavlja{unosResenja}";
			upisanaResenja.Add( unosResenja.Text );
			tbxOpisZadataka.Text = $"4. Koja je frekvencija napona?\nFrekvencija napona je: {unosResenja}";
			upisanaResenja.Add( unosResenja.Text );
			tbxOpisZadataka.Text = $"5. Koja je amplituda napona?\namplituda napona je: {unosResenja}";
			upisanaResenja.Add( unosResenja.Text );
		}
		private void btnTest4_Click( object sender, EventArgs e )
		{
			KliknutoDugme();

		}

		private void Testovi_Load( object sender, EventArgs e )
		{
            SetSize();
		}

        public void SetSize()
        {
            //namestanje dugmica
			int bttnWidth = 10*Width/36;
			int bttnHeight = 10*Height/35;
			int x1, x2, y1, y2; //koordinate za pozicije dugmica
			x1 = Width/6;
			x2 = 5*Width/6 - bttnWidth;
			y1 = Height/6;
			y2 = 5*Height/6 - bttnHeight;
			btnTest1.SetBounds( x1, y1, bttnWidth, bttnHeight );
			btnTest2.SetBounds( x2, y1, bttnWidth, bttnHeight );
			btnTest3.SetBounds( x1, y2, bttnWidth, bttnHeight );
			btnTest4.SetBounds( x2, y2, bttnWidth, bttnHeight );
			btnNazad.SetBounds( Width - Width/12, Height/50, Width/17, Width/17 );

            tbxOpisZadataka.SetBounds(x1,y1, Width - 2*Width/6, Height - 2*Height/6 );
			tbxOpisZadataka.Font = new Font( "Times New Roman", Width/50, FontStyle.Bold );
		}
		private void Testovi_ResizeEnd( object sender, EventArgs e )
		{
            SetSize();
		}
	}
}
