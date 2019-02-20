namespace SimpleCalc
{

    //
    //  CIJELI IZGLED NAPRAVLJEN IZ TOOLBOX, DRAG AND DROP, OVDJE NIJE BILO KODIRANJA ZA OVAJ PRIMJER
    //



    partial class Form1
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
            this.buttonZbrajanje = new System.Windows.Forms.Button();
            this.prviBrojLabel = new System.Windows.Forms.Label();
            this.textPrviBroj = new System.Windows.Forms.TextBox();
            this.textRezultat = new System.Windows.Forms.TextBox();
            this.rezultatLabel = new System.Windows.Forms.Label();
            this.textDrugiBroj = new System.Windows.Forms.TextBox();
            this.drugiBrojLabel = new System.Windows.Forms.Label();
            this.buttonMnozenje = new System.Windows.Forms.Button();
            this.buttonOduzimanje = new System.Windows.Forms.Button();
            this.buttonDijeljenje = new System.Windows.Forms.Button();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonZbrajanje
            // 
            this.buttonZbrajanje.Location = new System.Drawing.Point(94, 142);
            this.buttonZbrajanje.Name = "buttonZbrajanje";
            this.buttonZbrajanje.Size = new System.Drawing.Size(75, 23);
            this.buttonZbrajanje.TabIndex = 0;
            this.buttonZbrajanje.Text = "Zbrajanje";
            this.buttonZbrajanje.UseVisualStyleBackColor = true;
            this.buttonZbrajanje.Click += new System.EventHandler(this.buttonZbrajanje_Click);
            // 
            // prviBrojLabel
            // 
            this.prviBrojLabel.AutoSize = true;
            this.prviBrojLabel.Location = new System.Drawing.Point(21, 49);
            this.prviBrojLabel.Name = "prviBrojLabel";
            this.prviBrojLabel.Size = new System.Drawing.Size(51, 13);
            this.prviBrojLabel.TabIndex = 1;
            this.prviBrojLabel.Text = "Prvi broj: ";
            // 
            // textPrviBroj
            // 
            this.textPrviBroj.Location = new System.Drawing.Point(94, 46);
            this.textPrviBroj.Name = "textPrviBroj";
            this.textPrviBroj.Size = new System.Drawing.Size(200, 20);
            this.textPrviBroj.TabIndex = 2;
            this.textPrviBroj.Text = "0.00";
            this.textPrviBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrviBroj_KeyPress);
            // 
            // textRezultat
            // 
            this.textRezultat.Location = new System.Drawing.Point(94, 95);
            this.textRezultat.Name = "textRezultat";
            this.textRezultat.ReadOnly = true;
            this.textRezultat.Size = new System.Drawing.Size(200, 20);
            this.textRezultat.TabIndex = 4;
            // 
            // rezultatLabel
            // 
            this.rezultatLabel.AutoSize = true;
            this.rezultatLabel.Location = new System.Drawing.Point(21, 98);
            this.rezultatLabel.Name = "rezultatLabel";
            this.rezultatLabel.Size = new System.Drawing.Size(52, 13);
            this.rezultatLabel.TabIndex = 3;
            this.rezultatLabel.Text = "Rezultat: ";
            // 
            // textDrugiBroj
            // 
            this.textDrugiBroj.Location = new System.Drawing.Point(94, 71);
            this.textDrugiBroj.Name = "textDrugiBroj";
            this.textDrugiBroj.Size = new System.Drawing.Size(200, 20);
            this.textDrugiBroj.TabIndex = 6;
            this.textDrugiBroj.Text = "0.00";
            this.textDrugiBroj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDrugiBroj_KeyPress);
            // 
            // drugiBrojLabel
            // 
            this.drugiBrojLabel.AutoSize = true;
            this.drugiBrojLabel.Location = new System.Drawing.Point(21, 74);
            this.drugiBrojLabel.Name = "drugiBrojLabel";
            this.drugiBrojLabel.Size = new System.Drawing.Size(58, 13);
            this.drugiBrojLabel.TabIndex = 5;
            this.drugiBrojLabel.Text = "Drugi broj: ";
            // 
            // buttonMnozenje
            // 
            this.buttonMnozenje.Location = new System.Drawing.Point(94, 171);
            this.buttonMnozenje.Name = "buttonMnozenje";
            this.buttonMnozenje.Size = new System.Drawing.Size(75, 23);
            this.buttonMnozenje.TabIndex = 7;
            this.buttonMnozenje.Text = "Mnozenje";
            this.buttonMnozenje.UseVisualStyleBackColor = true;
            this.buttonMnozenje.Click += new System.EventHandler(this.buttonMnozenje_Click);
            // 
            // buttonOduzimanje
            // 
            this.buttonOduzimanje.Location = new System.Drawing.Point(219, 142);
            this.buttonOduzimanje.Name = "buttonOduzimanje";
            this.buttonOduzimanje.Size = new System.Drawing.Size(75, 23);
            this.buttonOduzimanje.TabIndex = 8;
            this.buttonOduzimanje.Text = "Oduzimanje";
            this.buttonOduzimanje.UseVisualStyleBackColor = true;
            this.buttonOduzimanje.Click += new System.EventHandler(this.buttonOduzimanje_Click);
            // 
            // buttonDijeljenje
            // 
            this.buttonDijeljenje.Location = new System.Drawing.Point(219, 171);
            this.buttonDijeljenje.Name = "buttonDijeljenje";
            this.buttonDijeljenje.Size = new System.Drawing.Size(75, 23);
            this.buttonDijeljenje.TabIndex = 9;
            this.buttonDijeljenje.Text = "Dijeljenje";
            this.buttonDijeljenje.UseVisualStyleBackColor = true;
            this.buttonDijeljenje.Click += new System.EventHandler(this.buttonDijeljenje_Click);
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(91, 21);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(72, 13);
            this.labelNaslov.TabIndex = 10;
            this.labelNaslov.Text = "Unesi 2 broja:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 213);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.buttonDijeljenje);
            this.Controls.Add(this.buttonOduzimanje);
            this.Controls.Add(this.buttonMnozenje);
            this.Controls.Add(this.textDrugiBroj);
            this.Controls.Add(this.drugiBrojLabel);
            this.Controls.Add(this.textRezultat);
            this.Controls.Add(this.rezultatLabel);
            this.Controls.Add(this.textPrviBroj);
            this.Controls.Add(this.prviBrojLabel);
            this.Controls.Add(this.buttonZbrajanje);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZbrajanje;
        private System.Windows.Forms.Label prviBrojLabel;
        private System.Windows.Forms.TextBox textPrviBroj;
        private System.Windows.Forms.TextBox textRezultat;
        private System.Windows.Forms.Label rezultatLabel;
        private System.Windows.Forms.TextBox textDrugiBroj;
        private System.Windows.Forms.Label drugiBrojLabel;
        private System.Windows.Forms.Button buttonMnozenje;
        private System.Windows.Forms.Button buttonOduzimanje;
        private System.Windows.Forms.Button buttonDijeljenje;
        private System.Windows.Forms.Label labelNaslov;
    }
}

