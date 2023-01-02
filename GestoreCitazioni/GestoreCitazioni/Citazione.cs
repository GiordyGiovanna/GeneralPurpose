using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreCitazioni
{
    internal class Citazione
    {
        public int Id { get => id; set => id = value; }
        public string Titolo { get => titolo; set => titolo = value; }
        public string Cit { get => cit; set => cit = value; }
        public string Author { get => author; set => author = value; }
        public DateTime Data { get => data; set => data = value; }

        private int id;
        private string titolo;
        private string cit;
        private string author;
        public long dataTicks;
        private DateTime data;

        public const String FILENAME = "Citazioni.txt";

        public Citazione(string tit, string cit) 
        {
            Id = generaId();
            Titolo = tit;
            Cit = cit;
            dataTicks = DateTime.Now.Ticks;
            Data = new DateTime(dataTicks);
        }

        public Citazione(int id, string tit, string cit, long dt)
        {
            Id = id;
            Titolo = tit;
            Cit = cit;
            Data = new DateTime(dt);
        }

        private int generaId(string filename = FILENAME)
        {
            int ret = new int();
            StreamReader sr = new StreamReader(filename);
            ret = sr.ReadLine() == null ? -1 : int.Parse(sr.ReadLine()[0].ToString());
            sr.Close();
            return ++ret;
        }

    }
}
