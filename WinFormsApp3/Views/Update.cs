using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3.Views
{
    public partial class Update : Form
    {
        Form f2;
        int id;
        VareBL data1;
        public Update(Form f2, int id)
        {
            InitializeComponent();
            data1 = new VareBL();
            this.f2 = f2;
            btnFraUpdateTilOverview.Click += btnToOverview;
            btnUpdateVare.Click += btnUpdate_Click;
            this.id = id;
        }
        private void btnToOverview(object sender, EventArgs e)
        {
            this.Close();
            f2.Show();
        }
        private void btnUpdate_Click(object? sender, EventArgs e)
        {

            try
            {
                string navn = TxtUpdateNavn.Text;
                string beskrivelse = TxtUpdateBeskrivelse.Text;
                int antal = Convert.ToInt32(TxtUpdateAntal.Text);
                decimal indkøbspris = Convert.ToDecimal(TxtUpdateIndkøbspris.Text);
                decimal fortjeneste = Convert.ToDecimal(TxtUpdateFortjeneste.Text);

                Vare opdateretVare = new Vare
                {
                    ID = id,
                    Varenavn = navn,
                    VareBeskrivelse = beskrivelse,
                    Antal = antal,
                    Indkøbspris = indkøbspris,
                    Fortjeneste = fortjeneste
                };

                bool success = data1.Update(opdateretVare);

                if (success)
                {
                    MessageBox.Show("Vare opdateret med succes!", "Vare blev opdateret!");
                    this.Close();
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Fejl ved opdatering af vare.", "Fejl under opdatering");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Undtagelse ved opdatering af vare: {ex}");
                MessageBox.Show($"Fejl under opdatering af vare:\n{ex.Message}", "Fejl");
            }


        }

    }
}

