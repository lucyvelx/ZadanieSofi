using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pokus
{
    public partial class Form1 : Form
    {
        OracleConnection spojenie;
        OracleDataAdapter adapter;
        OracleCommand sql;

        public Form1()
        {
            InitializeComponent();
        }

        void MainFormShown(object sender, EventArgs e)
        {
            try
            {
                //objekt so spojením vytvoríme ako prvý
                spojenie = new OracleConnection();

                //vytvoríme objekt okna a zobrazíme ho ako dialóg      
                Login frmLogin = new Login();
                DialogResult odpoved = frmLogin.ShowDialog();

                //ak odpoveď nášho dialógu nebola OK, zatvoríme aplikáciu 
                if (odpoved != DialogResult.OK)
                {
                    Application.Exit();
                }

                //v ConnectionStringu nahradíme pevný login a heslo za údaje z textBox-ov
                spojenie.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=147.175.226.29)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=student)));User Id=" + frmLogin.tbLogin.Text + ";Password=" + frmLogin.tbHeslo.Text + ";";
                spojenie.Open();

                //ak bolo spojenie úspešné, pridáme použitý login do titulku okna
                this.Text = this.Text + " (" + frmLogin.tbLogin.Text + ")";
            }
            catch (OracleException ex)
            {
                //ak nastala chyba pri vytvorení spojenia
                MessageBox.Show(ex.Message, "Chyba pripojenia");
                Application.Exit();
            }


            //MessageBox.Show(spojenie.State.ToString(), "Stav spojenia");
        }

        private void MainFormClosed(object sender, FormClosedEventArgs e)
        {
            spojenie.Close();


        }
    }
}
