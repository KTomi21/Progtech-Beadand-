using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.Class
{
    public class VisszahozottKonyvek
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public string KonyvCime { get; set; }
        public string Szerzo { get; set; }
        public string Statusz { get; set; }

        public VisszahozottKonyvek(int id, string nev, string konyCime, string szerzo, string statusz)
        {
            ID = id;
            Nev = nev;
            KonyvCime = konyCime;
            Szerzo = szerzo;
            Statusz = statusz;
        }
    }
}
