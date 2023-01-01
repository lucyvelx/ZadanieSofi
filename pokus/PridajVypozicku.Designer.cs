namespace pokus
{
    partial class PridajVypozicku
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIdVypozicky = new System.Windows.Forms.TextBox();
            this.tbIdZakaznika = new System.Windows.Forms.TextBox();
            this.tbIdKnihy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zrušiť";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pridať";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Výpožičky:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Zákazníka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Knihy:";
            // 
            // tbIdVypozicky
            // 
            this.tbIdVypozicky.Location = new System.Drawing.Point(111, 24);
            this.tbIdVypozicky.Name = "tbIdVypozicky";
            this.tbIdVypozicky.ReadOnly = true;
            this.tbIdVypozicky.Size = new System.Drawing.Size(100, 20);
            this.tbIdVypozicky.TabIndex = 5;
            // 
            // tbIdZakaznika
            // 
            this.tbIdZakaznika.Location = new System.Drawing.Point(111, 63);
            this.tbIdZakaznika.Name = "tbIdZakaznika";
            this.tbIdZakaznika.Size = new System.Drawing.Size(100, 20);
            this.tbIdZakaznika.TabIndex = 6;
            // 
            // tbIdKnihy
            // 
            this.tbIdKnihy.Location = new System.Drawing.Point(111, 105);
            this.tbIdKnihy.Name = "tbIdKnihy";
            this.tbIdKnihy.Size = new System.Drawing.Size(100, 20);
            this.tbIdKnihy.TabIndex = 7;
            // 
            // PridajVypozicku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 262);
            this.Controls.Add(this.tbIdKnihy);
            this.Controls.Add(this.tbIdZakaznika);
            this.Controls.Add(this.tbIdVypozicky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PridajVypozicku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pridaj Výpožičku";
            this.Load += new System.EventHandler(this.PridajVypozicku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIdVypozicky;
        private System.Windows.Forms.TextBox tbIdZakaznika;
        private System.Windows.Forms.TextBox tbIdKnihy;
    }
}