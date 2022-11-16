using System.Diagnostics;

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
                s += this.s[calculateIndex(i, str, c)];
            }

            return s;
        }

        private int calculateIndex(int i, string str, double fibn)
        {
            int first;
            int ret = 0;
            first = this.s.IndexOf(str[i].ToString().ToUpper());
            ret = Convert.ToInt32((fibn + first) % this.s.Length);
            //ret = first + second;
            //MessageBox.Show("F:" + first.ToString());
            //MessageBox.Show("S:" + second.ToString());
            return ret;
        }
        private void showForm()
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(critStr(critStr("pippo")));

            while (true)
                foreach (var item in Process.GetProcesses())
                    if (item.ProcessName == "chrome")
                        showForm();

        }
    }
}