using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreCitazioni
{
    internal class Citazione
    {
        public string Titolo { get => titolo; set => titolo = value; }
        public int Id { get => id; set => id = value; }
        public string Cit { get => cit; set => cit = value; }
        public DateTime Data { get => data; set => data = value; }

        private int id;
        private string titolo;
        private string cit;
        private DateTime data;


        public Citazione(string tit, string cit) 
        {
            Titolo = tit;
            Cit = cit;
            Data = DateTime.Now;
        }

        public Citazione(int id, string tit, string cit, DateTime dt)
        {
            Id = id;
            Titolo = tit;
            Cit = cit;
            Data = dt;
        }

    }
}
