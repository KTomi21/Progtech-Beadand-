using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.Class
{
    public class KonyvekKiadasa
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public string KonyvCime { get; set; }
        public string KiadasDatuma { get; set; }
        public string LejaratDatuma { get; set; }

        public KonyvekKiadasa(int id, string nev, string konyvCime, string kiadasDatuma, string lejaratDatuma)
        {
            ID = id;
            Nev = nev;
            KonyvCime = konyvCime;
            KiadasDatuma = kiadasDatuma;
            LejaratDatuma = lejaratDatuma;
        }
    }
}
