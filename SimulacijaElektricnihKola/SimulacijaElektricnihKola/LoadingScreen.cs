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
	public partial class LoadingScreen : Form
	{
		public LoadingScreen()
		{
			InitializeComponent();
		}

		private void LoadingScreen_Load( object sender, EventArgs e )
		{
			this.Width = 1200;
			this.Height = 800;

			//naslov
			Label naslov = new Label();
			naslov.BackColor = Color.White;
			naslov.ForeColor = Color.Black;
			naslov.BorderStyle = BorderStyle.FixedSingle;
			naslov.Text = "SIMULACIJA KOLA";
			naslov.Font = new Font( "Times New Roman", 20, FontStyle.Bold );
			naslov.SetBounds( Width/2 - Width/6, Height/10, Width/3, Width/10 );
			naslov.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( naslov );

			int sirinaBttn = Width/5;
			int visinaBttn = sirinaBttn/2;

			//button objasnjenje
			Button objasnjenjebtn = new Button();
			objasnjenjebtn.BackColor = Color.White;
			objasnjenjebtn.ForeColor = Color.Black;
			objasnjenjebtn.Text = "OBJASNJENJE";
			objasnjenjebtn.Font = new Font( "Times New Roman", 20, FontStyle.Bold );
			objasnjenjebtn.SetBounds( Width/6 - sirinaBttn/2, Height/2, sirinaBttn, visinaBttn );
			objasnjenjebtn.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( objasnjenjebtn );
            objasnjenjebtn.Click += Objasnjenjebtn_Click;

			//button test
			Button testbtn = new Button();
			testbtn.BackColor = Color.White;
			testbtn.ForeColor = Color.Black;
			testbtn.Text = "TEST";
			testbtn.Font = new Font( "Times New Roman", 20, FontStyle.Bold );
			testbtn.SetBounds( Width/2 - sirinaBttn/2, Height/2, sirinaBttn, visinaBttn );
			testbtn.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( testbtn );
            testbtn.Click += Testbtn_Click; ;

			//button simulacija
			Button simulacijabttn = new Button();
			simulacijabttn.BackColor = Color.White;
			simulacijabttn.ForeColor = Color.Black;
			simulacijabttn.Text = "SIMULACIJA";
			simulacijabttn.Font = new Font( "Times New Roman", 20, FontStyle.Bold );
			simulacijabttn.SetBounds( 5*Width/6 - sirinaBttn / 2, Height/2, sirinaBttn, visinaBttn );
			simulacijabttn.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( simulacijabttn );
            simulacijabttn.Click += Simulacijabttn_Click;

		
		}

		Simulacija simulacijaForma = new Simulacija();
        private void Simulacijabttn_Click(object sender, EventArgs e)
        {
            simulacijaForma.Show();
            this.Hide();
        }

		Testovi testoviForma = new Testovi();
        private void Testbtn_Click(object sender, EventArgs e)
        {
            testoviForma.Show();
            this.Hide();
        }

        Teorija teorijaForma = new Teorija();
        private void Objasnjenjebtn_Click(object sender, EventArgs e)
        {
            teorijaForma.Show();
            this.Hide();
        }
    }
}
