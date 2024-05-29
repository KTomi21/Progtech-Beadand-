using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Konyvtar_Rendszer_Kezeles.Builder_Minta
{
    internal class Builder
    {
        private KonyvTulajdonsagok konyv;

        public Builder()
        {
            konyv = new KonyvTulajdonsagok();
        }

        public Builder ID(int id)
        {
            konyv.ID = id;
            return this;
        }

        public Builder Cim(string cim)
        {
            konyv.Cim = cim;
            return this;
        }

        public Builder Szerzo(string szerzo)
        {
            konyv.Szerzo = szerzo;
            return this;
        }

        public Builder KiadasDatuma(string kiadasDatuma)
        {
            DateTime kiadasDatum;
            if (DateTime.TryParse(kiadasDatuma, out kiadasDatum))
            {
                konyv.KiadasDatuma = kiadasDatum.ToString();
            }
            else
            {
                throw new ArgumentException("Hibás dátum formátum");
            }

            return this;
        }

        public Builder LejaratDatuma(string lejaratDatuma)
        {
            DateTime lejaratDatum;
            if (DateTime.TryParse(lejaratDatuma, out lejaratDatum))
            {
                konyv.KiadasDatuma = lejaratDatum.ToString();
            }
            else
            {
                throw new ArgumentException("Hibás dátum formátum");
            }

            return this;
        }

        public Builder Statusz(string statusz)
        {
            konyv.Statusz = statusz;
            return this;
        }

        public Builder Nev(string nev)
        {
            konyv.Nev = nev;
            return this;
        }

        public KonyvTulajdonsagok Build()
        {
            return konyv;
        }
    }
}
