using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestoreCitazioni
{
    public partial class FormInserimento : Form
    {
        public FormInserimento()
        {
            InitializeComponent();
        }
        public const String FILENAME = "Citazioni.txt";

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            if (checkInserimento())
            {
                Citazione newCitazione = new Citazione(txtTit.Text, rtbCit.Text, txtAutore.Text);
                WRfile.saveNewCit(newCitazione, FILENAME);
                this.Close();
            }
            else
            {
                MessageBox.Show("Parametro mancante", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkInserimento()
        {
            bool ret = true;
            ret = rtbCit.Text != "" || txtTit.Text != "" || txtAutore.Text != "";
            return ret;
        }
    }
}
