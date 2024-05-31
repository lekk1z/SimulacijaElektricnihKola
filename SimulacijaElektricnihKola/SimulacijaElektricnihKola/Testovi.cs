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
        
        private void btnTest3_Click( object sender, EventArgs e )
        {
            btnTest1.Hide();
            btnTest2.Hide();
            btnTest3.Hide();
            btnTest4.Hide();
            tbxOpisZadataka.Show();
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

        private void btnNazad_Click( object sender, EventArgs e )
        {
           
        }
        private void Testovi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnNazad_Click_1(object sender, EventArgs e)
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
    }
}
