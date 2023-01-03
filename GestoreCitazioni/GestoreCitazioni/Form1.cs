namespace GestoreCitazioni
{
    public partial class Gestore : Form
    {
        List<Citazione> list = new List<Citazione>();
        public Gestore()
        {
            InitializeComponent();
        }
        /// <summary>
        /// TODO:
        /// 1 - Make the list look better
        /// 2 - finish the insert form
        /// </summary>

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void BtnInserisci_Click(object sender, EventArgs e)
        {
            FormInserimento f = new FormInserimento();
            f.ShowDialog();
            refresh();
        }

        private void refresh()
        {
            list = WRfile.readfile();
            dgvCit.DataSource = list;
            for (int i = 0; i < dgvCit.ColumnCount; i++)
            {
                if(i != 2) dgvCit.AutoResizeColumn(i);
            }
        }

        private void dgvCit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Open another Form form to see and modify the cit.
            // Coming better soon
            if(e.RowIndex > 0 && e.RowIndex < list.Count)
            {
                Modify_Detail mod = new Modify_Detail(list[e.RowIndex]);
                mod.ShowDialog();
            }

        }
    }
}