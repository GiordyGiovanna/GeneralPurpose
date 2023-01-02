using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreCitazioni
{
    internal static class WRfile
    {
        public const string FILENAME = "Citazioni.txt";
        public static List<Citazione> readfile(string filename = FILENAME)
        {
            List<Citazione> citazioni = new List<Citazione>();
            StreamReader sr = new StreamReader(filename);
            String strLine;
            while((strLine = sr.ReadLine()) != null)
            {
                if(strLine != "") // Skip the first line
                {
                    citazioni.Add(new Citazione(
                        int.Parse(strLine.Split('~')[0]),
                        strLine.Split('~')[1],
                        strLine.Split('~')[2].Replace('σ', '\n'),
                        ((long.Parse(strLine.Split('~')[3]))))
                    );
                }
            }
            sr.Close();
            citazioni.Reverse();
            return citazioni;
        }

        public static void saveNewCit(Citazione c, string filename = FILENAME)
        {
            StreamReader sr = new StreamReader(filename);
            String s = "\n" + c.Id + "~" + c.Titolo + "~" + c.Cit.Replace('\n', 'σ') + "~" + c.dataTicks + sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter(filename, false);
            sw.WriteLine(s);
            sw.Close();
        }

    }
}
