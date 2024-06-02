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
		public Label naslov = new Label();
		public Button objasnjenjebtn = new Button();
		public Button testbtn = new Button();
		public Button simulacijabttn = new Button();
		public Button exitbtn = new Button();

		public void LoadingScreen_Load( object sender, EventArgs e )
		{
			this.Width = 1200;
			this.Height = 800;

			//naslov
			naslov.BackColor = Color.Transparent;
			naslov.ForeColor = ColorTranslator.FromHtml( "#C0FDF6" );
			naslov.BorderStyle = BorderStyle.None;
			naslov.Text = "SIMULACIJA KOLA";
			naslov.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( naslov );

			Color bojaButtona = ColorTranslator.FromHtml( "#3A0078" );

			//button objasnjenje
			objasnjenjebtn.BackColor = bojaButtona;
			objasnjenjebtn.ForeColor = ColorTranslator.FromHtml( "#1AB1E6" );
			objasnjenjebtn.Text = "OBJASNJENJE";
			objasnjenjebtn.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( objasnjenjebtn );
			objasnjenjebtn.Click += Objasnjenjebtn_Click;

			//button test
			testbtn.BackColor = bojaButtona;
			testbtn.ForeColor = ColorTranslator.FromHtml( "#028388" );
			testbtn.Text = "TEST";
			testbtn.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( testbtn );
			testbtn.Click += Testbtn_Click;

			//button simulacija
			simulacijabttn.BackColor = bojaButtona;
			simulacijabttn.ForeColor = ColorTranslator.FromHtml( "#FB02F4" );
			simulacijabttn.Text = "SIMULACIJA";
			simulacijabttn.TextAlign = ContentAlignment.MiddleCenter;
			Controls.Add( simulacijabttn );
			simulacijabttn.Click +=Simulacijabttn_Click;

			SetSize();
		}
		public void SetSize()
		{
			
			naslov.Font = new Font( "Times New Roman", Width/20, FontStyle.Bold );
			naslov.SetBounds( Width/2 - Width/3, Height/14, 10*Width/15, Height/4 );

			int sirinaBttn = Width/5;
			int visinaBttn = sirinaBttn/2;
			
			objasnjenjebtn.Font = new Font( "Times New Roman", Width/60, FontStyle.Bold );
			objasnjenjebtn.SetBounds( Width/6 - sirinaBttn/2, Height/2, sirinaBttn, visinaBttn );

			testbtn.Font = new Font( "Times New Roman", Width/60, FontStyle.Bold );
			testbtn.SetBounds( Width/2 - sirinaBttn/2, Height/2, sirinaBttn, visinaBttn );

			
			simulacijabttn.Font = new Font( "Times New Roman", Width / 60, FontStyle.Bold );
			simulacijabttn.SetBounds( 5*Width/6 - sirinaBttn / 2, Height/2, sirinaBttn, visinaBttn );

		}

		//ako su kliknuti dugmici
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

        private void LoadingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
			Application.Exit();
        }

		//za resize
		private void LoadingScreen_ResizeEnd( object sender, EventArgs e )
		{
			SetSize();
		}

		//Marta je pisala
	}
}
