using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.Class
{
    public class KonyvekHozzaadasa
    {
        public int ID { get; set; }
        public string KonyvCime { get; set; }
        public string Szerzo { get; set; }
        public string KiadasDatuma { get; set; }
        public string Statusz { get; set; }

        public KonyvekHozzaadasa(int id, string konyvCime, string szerzo, string kiadasDatuma, string statusz)
        {
            ID = id;
            KonyvCime = konyvCime;
            Szerzo = szerzo;
            KiadasDatuma = kiadasDatuma;
            Statusz = statusz;
        }
    }
}
