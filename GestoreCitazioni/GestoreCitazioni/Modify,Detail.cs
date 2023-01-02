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
    public partial class Modify_Detail : Form
    {
        public Modify_Detail()
        {
            InitializeComponent();
        }

        public Modify_Detail(Citazione c) : this() 
        {
            rtbCit.Text = c.Cit;
        }

        private void Modify_Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
