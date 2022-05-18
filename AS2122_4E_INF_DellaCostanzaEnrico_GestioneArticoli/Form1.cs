namespace AS2122_4E_INF_DellaCostanzaEnrico_GestioneArticoli
{
    public partial class Form1 : Form
    {
        Dictionary<string, Articoli> articoli;
        public Form1()
        {
            InitializeComponent();
            articoli = new Dictionary<string, Articoli>();
        
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (articoli.ContainsKey (txtCodice.Text))
            {
                articoli[txtCodice.Text] = new Articoli(txtCodice.Text, cmbUnitaDiMisura.Text, txtDescrizione.Text, Convert.ToDouble(txtPrezzo.Text));

            }
            else
            {
                articoli.Add(txtCodice.Text, new Articoli(txtCodice.Text, cmbUnitaDiMisura.Text, txtDescrizione.Text, Convert.ToDouble(txtPrezzo.Text)));
            }
            lblArticoli.Text = "articolo(" + articoli.Count.ToString() + ")";
        
        
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            switch (cmbVisualizza.Text)
            {
                case "Visualizza articoli":
                    lstVisualizza.Items.Clear();    
                    foreach(KeyValuePair<string Articoli> Articolo)

            }
        }
    }
}