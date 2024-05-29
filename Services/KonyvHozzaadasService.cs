using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konyvtar_Rendszer_Kezeles.Builder_Minta;
using Konyvtar_Rendszer_Kezeles.Class;
using Konyvtar_Rendszer_Kezeles.Observer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Konyvtar_Rendszer_Kezeles.Services
{
    public class KonyvHozzaadasService
    {
        private readonly KonyvtarRendszer konyvtarRendszer;

        public KonyvHozzaadasService(KonyvtarRendszer konyvtarRendszer)
        {
            this.konyvtarRendszer = konyvtarRendszer;
        }

        public void AddKonyv(KonyvTulajdonsagok konyv)
        {
            if (string.IsNullOrWhiteSpace(konyv.Cim) || string.IsNullOrWhiteSpace(konyv.Szerzo) || string.IsNullOrWhiteSpace(konyv.Statusz))
            {
                throw new ArgumentException("Minden mezőt töltsön ki!");
            }

            int id = konyvtarRendszer.GetNextId();
            KonyvekHozzaadasa UjKonyv = new KonyvekHozzaadasa(id, konyv.Cim, konyv.Szerzo, konyv.KiadasDatuma, konyv.Statusz);
            konyvtarRendszer.AddKonyv(UjKonyv);
        }
    }
}
