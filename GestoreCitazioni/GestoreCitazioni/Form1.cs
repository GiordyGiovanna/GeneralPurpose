namespace GestoreCitazioni
{
    public partial class Gestore : Form
    {
        public Gestore()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Citazione> list = new List<Citazione>();
            list = WRfile.readfile();
            dgvCit.DataSource = list;
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            FormInserimento f = new FormInserimento();
            f.ShowDialog();
        }

        private void dgvCit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}