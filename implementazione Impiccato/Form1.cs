namespace implementazione_Impiccato
{
    public partial class bo : Form
    {
        string parolaScelta;
        int indiceCasuale;
        int tent;
        public bo()
        {
            InitializeComponent();
        }

        private void titolo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void facile_Click(object sender, EventArgs e)
        {
            tent = 10;
            tentativi.Text = tent.ToString();
        }

        private void tentativi_TextChanged(object sender, EventArgs e)
        {

        }

        private void medio_Click_1(object sender, EventArgs e)
        {
            tent = 7;
            tentativi.Text = tent.ToString();
        }

        private void difficile_Click_1(object sender, EventArgs e)
        {
            tent = 5;
            tentativi.Text = tent.ToString();
        }

        private void parolacasuale_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void bottonepcasuale_Click(object sender, EventArgs e)
        {
            string percorsoFile = "parole.txt";
            // Legge tutte le parole dal file in un array
            if (File.Exists(percorsoFile))
            {

            }

            string[] parole = File.ReadAllLines(percorsoFile);

            // Genera un numero casuale per scegliere una parola
            Random rnd = new Random();
            indiceCasuale = rnd.Next(0, parole.Length);

            // Parola selezionata
            parolaScelta = parole[indiceCasuale];

            parolacasuale.Text = parolaScelta.ToString();
        }
    }
}
