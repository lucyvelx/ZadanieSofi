namespace pokus
{
    partial class Vypozicky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zobraziťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vypozickyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVypozicky = new System.Windows.Forms.DataGridView();
            this.id_vypozicky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazov_knihy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priezvisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVytvor = new System.Windows.Forms.Button();
            this.btnUprav = new System.Windows.Forms.Button();
            this.btnVymaz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdVypozicky = new System.Windows.Forms.TextBox();
            this.tbNazovKnihy = new System.Windows.Forms.TextBox();
            this.tbMeno = new System.Windows.Forms.TextBox();
            this.tbPriezvisko = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypozicky)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobraziťToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zobraziťToolStripMenuItem
            // 
            this.zobraziťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vypozickyToolStripMenuItem});
            this.zobraziťToolStripMenuItem.Name = "zobraziťToolStripMenuItem";
            this.zobraziťToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zobraziťToolStripMenuItem.Text = "Zobraziť";
            // 
            // vypozickyToolStripMenuItem
            // 
            this.vypozickyToolStripMenuItem.Name = "vypozickyToolStripMenuItem";
            this.vypozickyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vypozickyToolStripMenuItem.Text = "Vypozicky";
            this.vypozickyToolStripMenuItem.Click += new System.EventHandler(this.vypozickyToolStripMenuItem_Click);
            // 
            // dgvVypozicky
            // 
            this.dgvVypozicky.AllowUserToAddRows = false;
            this.dgvVypozicky.AllowUserToDeleteRows = false;
            this.dgvVypozicky.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVypozicky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVypozicky.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_vypozicky,
            this.nazov_knihy,
            this.meno,
            this.Priezvisko});
            this.dgvVypozicky.Location = new System.Drawing.Point(0, 36);
            this.dgvVypozicky.Name = "dgvVypozicky";
            this.dgvVypozicky.ReadOnly = true;
            this.dgvVypozicky.RowHeadersVisible = false;
            this.dgvVypozicky.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVypozicky.Size = new System.Drawing.Size(546, 400);
            this.dgvVypozicky.TabIndex = 1;
            this.dgvVypozicky.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgvVypozickyRowStateChanged);
            // 
            // id_vypozicky
            // 
            this.id_vypozicky.HeaderText = "ID výpožičky";
            this.id_vypozicky.Name = "id_vypozicky";
            this.id_vypozicky.ReadOnly = true;
            // 
            // nazov_knihy
            // 
            this.nazov_knihy.HeaderText = "Názov knihy";
            this.nazov_knihy.Name = "nazov_knihy";
            this.nazov_knihy.ReadOnly = true;
            // 
            // meno
            // 
            this.meno.HeaderText = "Meno";
            this.meno.Name = "meno";
            this.meno.ReadOnly = true;
            // 
            // Priezvisko
            // 
            this.Priezvisko.HeaderText = "Priezvisko";
            this.Priezvisko.Name = "Priezvisko";
            this.Priezvisko.ReadOnly = true;
            // 
            // btnVytvor
            // 
            this.btnVytvor.Location = new System.Drawing.Point(17, 13);
            this.btnVytvor.Name = "btnVytvor";
            this.btnVytvor.Size = new System.Drawing.Size(75, 23);
            this.btnVytvor.TabIndex = 2;
            this.btnVytvor.Text = "Vytvoriť";
            this.btnVytvor.UseVisualStyleBackColor = true;
            this.btnVytvor.Click += new System.EventHandler(this.btnVytvor_Click);
            // 
            // btnUprav
            // 
            this.btnUprav.Location = new System.Drawing.Point(97, 13);
            this.btnUprav.Name = "btnUprav";
            this.btnUprav.Size = new System.Drawing.Size(75, 23);
            this.btnUprav.TabIndex = 3;
            this.btnUprav.Text = "Upraviť";
            this.btnUprav.UseVisualStyleBackColor = true;
            // 
            // btnVymaz
            // 
            this.btnVymaz.Location = new System.Drawing.Point(178, 13);
            this.btnVymaz.Name = "btnVymaz";
            this.btnVymaz.Size = new System.Drawing.Size(75, 23);
            this.btnVymaz.TabIndex = 4;
            this.btnVymaz.Text = "Vymazať";
            this.btnVymaz.UseVisualStyleBackColor = true;
            this.btnVymaz.Click += new System.EventHandler(this.btnVymaz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPriezvisko);
            this.groupBox1.Controls.Add(this.tbMeno);
            this.groupBox1.Controls.Add(this.tbNazovKnihy);
            this.groupBox1.Controls.Add(this.tbIdVypozicky);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dáta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID výpožičky:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Názov knihy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Priezvisko:";
            // 
            // tbIdVypozicky
            // 
            this.tbIdVypozicky.Location = new System.Drawing.Point(107, 41);
            this.tbIdVypozicky.Name = "tbIdVypozicky";
            this.tbIdVypozicky.ReadOnly = true;
            this.tbIdVypozicky.Size = new System.Drawing.Size(100, 20);
            this.tbIdVypozicky.TabIndex = 4;
            // 
            // tbNazovKnihy
            // 
            this.tbNazovKnihy.Location = new System.Drawing.Point(107, 71);
            this.tbNazovKnihy.MaxLength = 3000;
            this.tbNazovKnihy.Name = "tbNazovKnihy";
            this.tbNazovKnihy.ReadOnly = true;
            this.tbNazovKnihy.Size = new System.Drawing.Size(100, 20);
            this.tbNazovKnihy.TabIndex = 5;
            // 
            // tbMeno
            // 
            this.tbMeno.Location = new System.Drawing.Point(107, 101);
            this.tbMeno.MaxLength = 30;
            this.tbMeno.Name = "tbMeno";
            this.tbMeno.ReadOnly = true;
            this.tbMeno.Size = new System.Drawing.Size(100, 20);
            this.tbMeno.TabIndex = 6;
            // 
            // tbPriezvisko
            // 
            this.tbPriezvisko.Location = new System.Drawing.Point(107, 131);
            this.tbPriezvisko.MaxLength = 30;
            this.tbPriezvisko.Name = "tbPriezvisko";
            this.tbPriezvisko.ReadOnly = true;
            this.tbPriezvisko.Size = new System.Drawing.Size(100, 20);
            this.tbPriezvisko.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnVymaz);
            this.panel1.Controls.Add(this.btnVytvor);
            this.panel1.Controls.Add(this.btnUprav);
            this.panel1.Location = new System.Drawing.Point(565, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 400);
            this.panel1.TabIndex = 6;
            // 
            // Vypozicky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVypozicky);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vypozicky";
            this.Text = "Vypozicky";
            this.Load += new System.EventHandler(this.VypozickyLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypozicky)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zobraziťToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vypozickyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvVypozicky;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_vypozicky;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazov_knihy;
        private System.Windows.Forms.DataGridViewTextBoxColumn meno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priezvisko;
        private System.Windows.Forms.Button btnVytvor;
        private System.Windows.Forms.Button btnUprav;
        private System.Windows.Forms.Button btnVymaz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbPriezvisko;
        private System.Windows.Forms.TextBox tbMeno;
        private System.Windows.Forms.TextBox tbNazovKnihy;
        private System.Windows.Forms.TextBox tbIdVypozicky;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}