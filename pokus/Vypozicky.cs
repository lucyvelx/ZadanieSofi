using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;



namespace pokus
{
    public partial class Vypozicky : Form
    {
        OracleConnection spojenie;
        OracleDataAdapter adapter;
        OracleCommand sql;
        DataSet dset;

        public Vypozicky(OracleConnection existujuceSpojenie)
        {
            InitializeComponent();
            spojenie = existujuceSpojenie;
        }

        private void vypozickyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vypozicky frmVypozicky = new Vypozicky(spojenie);
            frmVypozicky.MdiParent = this;
            frmVypozicky.Show();
        }

        private void VypozickyLoad(object sender, EventArgs e)
        {
            try
            {
                //príkaz ktorý chceme vykonať nad DB
                string select = "select id_vypozicky,nazov_knihy,meno,priezvisko from vypozicky v inner join knihy k on v.id_knihy=k.katalogove_cislo inner join zakaznik z on v.id_zakaznika=z.id_zakaznika;";
                //inicializácia Data Adapter
                adapter = new OracleDataAdapter(select, spojenie);
                //naplnenie DataSet-u dátami z databázy
                adapter.Fill(dset, "Vypozicky");
                //naplnenie DataGridView dátamy z DataSet-u
                dgvVypozicky.DataSource = dset.Tables["Vypozicky"];
            }
            catch (OracleException ex)
            {
                //ak nastala chyba pri select-e z databázy
                MessageBox.Show(ex.Message, "Chyba pri načítaní dát");
            }
        }

        private void DgvVypozickyRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //Iba ak máme vybrané riadky v dataGridView
            if (dgvVypozicky.SelectedRows.Count > 0)
            {
                // Stĺpce v tabuľke
                tbIdVypozicky.Text = dgvVypozicky.SelectedRows[0].Cells["id_vypozicky"].Value.ToString();
                tbNazovKnihy.Text =dgvVypozicky.SelectedRows[0].Cells["nazov_knihy"].Value.ToString();
                tbMeno.Text =dgvVypozicky.SelectedRows[0].Cells["Meno"].Value.ToString();
                //Komponent numericUpDown očakáva číselný vstup
                tbPriezvisko.Text = dgvVypozicky.SelectedRows[0].Cells["priezvisko"].Value.ToString();
            }
        }

        private void btnVymaz_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult odpoved = MessageBox.Show("Naozaj chcte vymazať vypozicku s ID: " + tbIdVypozicky.Text, "Vymazanie výpožičky",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //Ak je odpoveď Yes
                if (odpoved == DialogResult.Yes)
                {
                    //sql príkaz pre delete
                    string delete = "delete from vypozicky where id_vypouicky = " + tbIdVypozicky.Text;
                    // insert, update a delete vykonávame pomocou OracleComand
                    sql = new OracleCommand(delete, spojenie);
                    int result = sql.ExecuteNonQuery();
                }
            }
            catch (OracleException ex)
            {
                //ak nastala chyba pri delete z databázy
                MessageBox.Show(ex.Message, "Chyba pri mazaní dát");
            }
            finally
            {
              
                dset.Tables["Vypozicky"].Clear();
                adapter.Fill(dset, "Vypozicky");
            }

        }

        private void btnVytvor_Click(object sender, EventArgs e)
        {

        }
    }
}
