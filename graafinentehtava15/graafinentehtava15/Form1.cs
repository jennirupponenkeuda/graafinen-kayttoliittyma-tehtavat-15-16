using System.Diagnostics; //Tarvitaan t‰ss‰ teht‰v‰ss‰ Stopwatch-funtiota varten
using System.Drawing.Text;

namespace graafinentehtava15
{
    public partial class SekkariForm : Form
    {
        private Stopwatch sekkari = new Stopwatch(); //K‰yttˆˆn tarvitaan System.Diagnostics

        public SekkariForm()
        {
            InitializeComponent();
        }

        private void SekkariForm_Load(object sender, EventArgs e)
        {
            sekkari = new Stopwatch(); //Kun ladataan tulee ns. uusi sekunttikello
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed); //Huom. kaksi kenoviivaa, jotta saadaan kaksoispisteet, t‰ss‰ m‰‰ritell‰‰n desimaalien m‰‰r‰‰ sekunttikellossa
        }

        private void c_Click(object sender, EventArgs e)
        {
            sekkari.Start(); //K‰ynnistet‰‰n sekunttikello
        }

        private void LopetaBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();//Pys‰ytet‰‰n sekunttikello
        }

        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset(); //Nollataan sekunttikello
        }

        private void AikaLB_Click(object sender, EventArgs e)
        {
            
        }
    }
}
