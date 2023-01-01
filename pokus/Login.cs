using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokus
{
    public partial class Login : Form
    {
        public Login()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        /// <summary>
        /// Overenie formulára pri jeho zatvorení
        /// </summary>
        void LoginFormClosing(object sender, FormClosingEventArgs e)
        {
            //pri overovaní potrebujeme skontrolovať aj či sme prihlásení potvrdili alebo zrušili pomocou DialogResult
            //inak by sme nevedeli zatvoriť okno
            if ((tbLogin.Text == "" || tbHeslo.Text == "") && this.DialogResult == DialogResult.OK)
            {
                //Vypíšeme chybové hlásenie
                MessageBox.Show("Login a heslo musia byž zadané", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //zrušíme zatvorenie okna
                e.Cancel = true;
            }
        }
    }
}

