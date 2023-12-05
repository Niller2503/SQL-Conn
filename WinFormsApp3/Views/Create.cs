using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3.Views
{
    public partial class Create : Form
    {
        Form f1;
        VareBL data;
        public event EventHandler BackButtonClicked;
        public Create(Form f1)
        {
            InitializeComponent();
            this.f1 = f1;
            btnTilOverview.Click += btnBack_Click;
            btnCreateVare.Click += btnCreate_Click;
            data = new VareBL();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Show();
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        public void btnCreate_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string beskrivelse = txtBeskrivelse.Text;
            int antal = Convert.ToInt32(txtAntal.Text);
            decimal indkøbspris = Convert.ToDecimal(txtIndkøbspris.Text);
            decimal fortjeneste = Convert.ToDecimal(txtFortjeneste.Text);
            Vare nyVare = new Vare
            {
                Varenavn = navn,
                VareBeskrivelse = beskrivelse,
                Antal = antal,
                Indkøbspris = indkøbspris,
                Fortjeneste = fortjeneste,
            };
            bool success = data.Create(nyVare);
            if (success)
            {
                MessageBox.Show("Vare oprettet med succes!", "Vare blev oprettet!");
            }
            else
            {
                MessageBox.Show("Fejl ved oprettelse af vare.", "Fejl under oprettelse");
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            f1.Show();
            base.OnClosing(e);
        }

        private void Create_Load(object sender, EventArgs e)
        {

        }
    }
}
