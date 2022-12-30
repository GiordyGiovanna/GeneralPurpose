using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreCitazioni
{
    internal static class WRfile
    {
        public static List<Citazione> readfile(string filename)
        {
            List<Citazione> citazioni = new List<Citazione>();
            StreamReader sr = new StreamReader(filename);
            String strLine;
            while((strLine = sr.ReadLine()) != null)
            {
                Console.WriteLine(strLine);
                citazioni.Add(new Citazione(
                    int.Parse(strLine.Split('~')[0]),
                    strLine.Split('~')[1],
                    strLine.Split('~')[2],
                    new DateTime())
                );
            }
            return citazioni;
        }
    }
}
