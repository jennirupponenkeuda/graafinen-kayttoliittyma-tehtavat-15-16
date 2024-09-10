namespace graafinentehtava16
{
    public partial class LaskuriF : Form
    {
        private int kokonaisaika; //T‰m‰ muuttuja tarvitaan
        public LaskuriF()
        {
            InitializeComponent();
        }

        private void LaskuriF_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false; //Alussa Stop-painike ei ole k‰ytˆss‰
            for (int i = 0; i < 60; i++) 
            {
                MinuutitCB.Items.Add(i.ToString()); // m‰‰ritell‰‰n numerot, eli lis‰t‰‰n numerot 1-15
                SekunnitCB.Items.Add(i.ToString());
            
            }
            MinuutitCB.SelectedIndex = 0; //M‰‰ritell‰‰n oletukset
            SekunnitCB.SelectedIndex = 0;
        } 

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false; // K‰ynniss‰ olessaan start-painike ei ole k‰ytˆss‰
            StopBT.Enabled = true; // K‰ynniss‰ olessaan stop-painike on k‰ytˆss‰

            int minuutit = int.Parse(MinuutitCB.SelectedItem.ToString()); // haetaan aika minuuttien kohdalta, Parsella tehdess‰ saa int
            int sekunnit = int.Parse(SekunnitCB.SelectedItem.ToString()); // haetaan aika sekunttien kohdalta
            kokonaisaika = (minuutit * 60) + sekunnit; // lasketaan kokonaisaika
            AjastinTimer.Enabled = true; //Ajastimen p‰‰lle kytkeminen

        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true; //Pys‰hdyksiss‰ olessaan start-painike on k‰ytˆss‰
            StopBT.Enabled = false; // Pys‰hdyksiss‰ olessaan stop-painike ei ole k‰ytˆss‰
            kokonaisaika = 0; 
            AjastinTimer.Enabled= false; //ajastin on poissa p‰‰lt‰, kun ollaan pys‰hdyksiss‰
            AikaLB.Text = "00:00"; // T‰m‰ teksti n‰kyy, kun ajastin pys‰ytet‰‰n stop-painikkeella

        }

        private void AjastinTimer_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--; //V‰hennet‰‰n yhdell‰
                int minuutit = kokonaisaika/60; //lasketaan minuutit uudelleen, desimaalit l‰htee intill‰ pois
                int sekunnit = kokonaisaika - (minuutit * 60); //lasketaan uudelleen sekunnit
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString(); //N‰ytet‰‰n
            }
            else // kun kokonaisaika on nolla
            {
                AjastinTimer.Stop(); // Ajastin pys‰ytet‰‰n
                MessageBox.Show("Aikasi loppui"); //N‰ytet‰‰n viesti
            }
        }
    }
}
