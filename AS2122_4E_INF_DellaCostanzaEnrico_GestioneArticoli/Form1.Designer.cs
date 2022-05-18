namespace AS2122_4E_INF_DellaCostanzaEnrico_GestioneArticoli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodice = new System.Windows.Forms.Label();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblUnitaDiMisura = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lstVisualizza = new System.Windows.Forms.ListBox();
            this.cmbUnitaDiMisura = new System.Windows.Forms.ComboBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArticoli = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodice
            // 
            this.lblCodice.AutoSize = true;
            this.lblCodice.Location = new System.Drawing.Point(18, 33);
            this.lblCodice.Name = "lblCodice";
            this.lblCodice.Size = new System.Drawing.Size(44, 15);
            this.lblCodice.TabIndex = 0;
            this.lblCodice.Text = "Codice";
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(20, 80);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(67, 15);
            this.lblDescrizione.TabIndex = 1;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblUnitaDiMisura
            // 
            this.lblUnitaDiMisura.AutoSize = true;
            this.lblUnitaDiMisura.Location = new System.Drawing.Point(18, 125);
            this.lblUnitaDiMisura.Name = "lblUnitaDiMisura";
            this.lblUnitaDiMisura.Size = new System.Drawing.Size(88, 15);
            this.lblUnitaDiMisura.TabIndex = 2;
            this.lblUnitaDiMisura.Text = "Unita Di Misura";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(18, 157);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(41, 15);
            this.lblPrezzo.TabIndex = 3;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lstVisualizza
            // 
            this.lstVisualizza.FormattingEnabled = true;
            this.lstVisualizza.ItemHeight = 15;
            this.lstVisualizza.Location = new System.Drawing.Point(417, 73);
            this.lstVisualizza.Name = "lstVisualizza";
            this.lstVisualizza.Size = new System.Drawing.Size(284, 169);
            this.lstVisualizza.TabIndex = 4;
            // 
            // cmbUnitaDiMisura
            // 
            this.cmbUnitaDiMisura.FormattingEnabled = true;
            this.cmbUnitaDiMisura.Location = new System.Drawing.Point(133, 117);
            this.cmbUnitaDiMisura.Name = "cmbUnitaDiMisura";
            this.cmbUnitaDiMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitaDiMisura.TabIndex = 6;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(18, 200);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(183, 23);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "Aggiungi/Modifica Articolo";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(133, 25);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 8;
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(133, 72);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 9;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(133, 154);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 10;
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Items.AddRange(new object[] {
            "Visualizza Articoli"});
            this.cmbVisualizza.Location = new System.Drawing.Point(428, 44);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(121, 23);
            this.cmbVisualizza.TabIndex = 11;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(555, 44);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 12;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAggiungi);
            this.groupBox1.Controls.Add(this.lblPrezzo);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.lblCodice);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.cmbUnitaDiMisura);
            this.groupBox1.Controls.Add(this.lblUnitaDiMisura);
            this.groupBox1.Controls.Add(this.lblDescrizione);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 306);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblArticoli
            // 
            this.lblArticoli.AutoSize = true;
            this.lblArticoli.Location = new System.Drawing.Point(23, 351);
            this.lblArticoli.Name = "lblArticoli";
            this.lblArticoli.Size = new System.Drawing.Size(59, 15);
            this.lblArticoli.TabIndex = 14;
            this.lblArticoli.Text = "Articoli(0)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArticoli);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.cmbVisualizza);
            this.Controls.Add(this.lstVisualizza);
            this.Name = "Form1";
            this.Text = " Prova singola 4E 18/05/2022 su form e dizionari, classi e utilizzo di GIT Della " +
    "Costanza Enrico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCodice;
        private Label lblDescrizione;
        private Label lblUnitaDiMisura;
        private Label lblPrezzo;
        private ListBox lstVisualizza;
        private ComboBox cmbUnitaDiMisura;
        private Button btnAggiungi;
        private TextBox txtCodice;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private ComboBox cmbVisualizza;
        private Button btnVisualizza;
        private GroupBox groupBox1;
        private Label lblArticoli;
    }
}