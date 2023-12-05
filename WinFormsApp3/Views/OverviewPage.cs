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
using WinFormsApp3.Views;


namespace WinFormsApp3
{
    public partial class OverviewPage : Form
    {
        List<Vare> vare;
        VareBL data;
        public OverviewPage()
        {
            InitializeComponent();
            //lblHelloWorld.Text = "My First Form";
            btnToCreate.Click += btnToCreate_Click;
            btnUpdate.Click += CreateBackButtonClicked;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
            
            data = new VareBL();
            vare = data.Get();
            LoadData();
        }

        private void dgvVare_DoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int row = e.RowIndex;
            DataGridViewRow temp = dgv.Rows[row];
            int id = (int)temp.Cells[0].Value;
            Update up = new Update(this,id);
            this.Hide();
            up.Show();
        }

        public void LoadData()
        {
            // Kald din metode til at hente data fra databasen og opdatere DataGridView
            vare = data.Get();
            dgvVare.DataSource = vare;
            this.dgvVare.Columns["ID"].Visible = false;
        }

        public void btnSearch_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearch.Text))
            {
                if (int.TryParse(TxtSearch.Text, out int id))
                {
                    try
                    {
                        bool success = data.TryGetVare(id, out Vare vare);

                        if (success)
                        {
                            MessageBox.Show("Vare søgt med succes!", "Vare blev fundet!");

                            // Opdater DataGridView til kun at vise den søgte vare
                            dgvVare.DataSource = new List<Vare> { vare };
                        }
                        else
                        {
                            MessageBox.Show("Fejl ved søgning af vare.", "Fejl under søgning");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Undtagelse ved søgning af vare: {ex}");
                        MessageBox.Show($"Fejl under søgning af vare:\n{ex.Message}", "Fejl");
                    }
                }
                else
                {
                    MessageBox.Show("Indtast venligst et gyldigt heltal som Vare ID.", "Ugyldig input");
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst et Vare ID for at søge.", "Tomt input");
            }
        }


        private void TxtMyFirstTxtBoxChanged(object? sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtSearch.Text))
            {
                lblHelloWorld.Text = TxtSearch.Text; ;
            }
            else
            {
                lblHelloWorld.Text = "Hello world!!!";
            }
        }
        public void btnToCreate_Click(object? sender, EventArgs e)
        {
            Create cr = new Create(this);
            cr.BackButtonClicked += CreateBackButtonClicked;
            this.Hide();
            cr.Show();
        }
        private void CreateBackButtonClicked(object sender, EventArgs e)
        {
            // Opdater DataGridView
            LoadData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtDelete.Text))
            {
                int vareIdToDelete;
                if (int.TryParse(TxtDelete.Text, out vareIdToDelete))
                {
                    try
                    {
                        bool success = data.Delete(vareIdToDelete);

                        if (success)
                        {
                            MessageBox.Show("Vare slettet med succes!", "Vare blev slettet!");
                            LoadData(); // Opdater DataGridView efter sletning
                        }
                        else
                        {
                            MessageBox.Show("Fejl ved sletning af vare.", "Fejl under sletning");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Undtagelse ved sletning af vare: {ex}");
                        MessageBox.Show($"Fejl under sletning af vare:\n{ex.Message}", "Fejl");
                    }
                }
                else
                {
                    MessageBox.Show("Indtast venligst et gyldigt heltal som Vare ID.", "Ugyldig input");
                }
            }
            else
            {
                MessageBox.Show("Indtast venligst et Vare ID for at slette.", "Tomt input");
            }
        }
    }
}
