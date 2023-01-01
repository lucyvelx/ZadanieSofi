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
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pokus
{
    public partial class PridajVypozicku : Form
    {
        OracleConnection spojenie;
        OracleCommand sql;
        OracleDataAdapter adapter;
        DataSet dset;
        public PridajVypozicku(OracleConnection existujuceSpojenie)
        {
            InitializeComponent();
            spojenie = existujuceSpojenie;
        }

        private void PridajVypozicku_Load(object sender, EventArgs e)
        {
            PridajVypozicku pridaj = new PridajVypozicku(spojenie);
            //Otvorenie okna ako dialogu
            pridaj.ShowDialog();

         
            dset.Tables["Vypozicky"].Clear();
            adapter.Fill(dset, "Vypozicky");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

           
            DialogResult odpoved = MessageBox.Show("Naozaj chcete pridať výpožičku: " + tbIdKnihy.Text + " " + tbIdZakaznika.Text + " ? ","Potvrdenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            //Ak sme zvolili No, ukončíme funkciu - nič nepridáme
            if (odpoved == DialogResult.No)
            {
                return;
            }

            string insert = "insert into vypozicky (id_knihy, id_zakaznika,id_vypozicky) values ("+tbIdKnihy.Text+","+tbIdZakaznika.Text+",dept_seq.nextval)";


            
                try
                {
                    sql = new OracleCommand(insert, spojenie);
                    sql.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                }
                catch (OracleException ex)
                {
                    //ak nastala chyba pri select alebo insert z/do databázy
                    MessageBox.Show(ex.Message, "Chyba pri pridávaní záznamu");
                    
                }
            
        }
    }
}
