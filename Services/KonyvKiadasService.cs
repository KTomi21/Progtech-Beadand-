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
    public class KonyvKiadasService
    {
        private readonly KonyvtarRendszer konyvtarRendszer;

        public KonyvKiadasService(KonyvtarRendszer konyvtarRendszer)
        {
            this.konyvtarRendszer = konyvtarRendszer;
        }

        public void IssueKonyv(KonyvTulajdonsagok konyv)
        {
            if (string.IsNullOrWhiteSpace(konyv.Nev) || string.IsNullOrWhiteSpace(konyv.Cim))
            {
                throw new ArgumentException("Minden mezőt töltsön ki!");
            }

            KonyvekHozzaadasa UjKonyv = new KonyvekHozzaadasa(konyv.ID, konyv.Nev, konyv.Cim, konyv.KiadasDatuma, konyv.LejaratDatuma);
            konyvtarRendszer.AddKonyv(UjKonyv);
        }
    }
}
