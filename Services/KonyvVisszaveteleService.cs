using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konyvtar_Rendszer_Kezeles.Builder_Minta;
using Konyvtar_Rendszer_Kezeles.Class;
using Konyvtar_Rendszer_Kezeles.Observer;

namespace Konyvtar_Rendszer_Kezeles.Services
{
    public class KonyvVisszaveteleService
    {
        private readonly KonyvtarRendszer konyvtarRendszer;

        public KonyvVisszaveteleService(KonyvtarRendszer konyvtarRendszer)
        {
            this.konyvtarRendszer = konyvtarRendszer;
        }

        public void ReturnKonyv(KonyvTulajdonsagok konyv)
        {
            if (string.IsNullOrWhiteSpace(konyv.Nev) || string.IsNullOrWhiteSpace(konyv.Cim) || string.IsNullOrWhiteSpace(konyv.Szerzo) || string.IsNullOrWhiteSpace(konyv.Statusz))
            {
                throw new ArgumentException("Minden mezőt töltsön ki!");
            }

            KonyvekHozzaadasa UjKonyv = new KonyvekHozzaadasa(konyv.ID, konyv.Nev, konyv.Cim, konyv.Szerzo, konyv.Statusz);
            konyvtarRendszer.AddKonyv(UjKonyv);
        }
    }
}
