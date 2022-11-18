using System.Diagnostics;
using System.Windows.Forms.Design;

namespace PasswordAndRecordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 123456789";
        private string critStr(string str)
        {
            double a = 0;
            double b = 1;
            double c = 1;
            string s = string.Empty;
            
            for (int i = 0; i < str.Length; i++)
            {
                c = a + b;
                a = b;
                b = c;
                s += this.s[calculateIndex(ch : str[i], fibn : c)];
            }

            return s;
        }

        private int calculateIndex(char ch, double fibn)
        {
            int first;
            int ret;
            first = this.s.IndexOf(ch.ToString().ToUpper());
            ret = Convert.ToInt32((fibn + first) % this.s.Length);
            return ret;
        }
        private void showForm()
        {
            this.WindowState = FormWindowState.Normal;
        }

        private List<string> takeProcesses(string fileName)
        {
            List<string> lst = new List<string>();
            lst.Add("chrome");
            return lst;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(critStr(str : "pippo"));

            List<string> lstProcesses = new List<string>();
            lstProcesses = takeProcesses(fileName : "");

            while (true)
                foreach (var item in Process.GetProcesses())
                    if (lstProcesses.Contains(item.ProcessName))
                    {
                        showForm();
                        return;

                    }

        }
    }
}