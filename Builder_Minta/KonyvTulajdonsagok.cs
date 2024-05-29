using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Konyvtar_Rendszer_Kezeles.Builder_Minta
{
    public class KonyvTulajdonsagok
    {
        public int ID { get; set; }
        public string Cim { get; set; }
        public string Szerzo { get; set; }
        public string KiadasDatuma { get; set; }
        public string LejaratDatuma { get; set; }
        public string Statusz { get; set; }

        public string Nev { get; set; }
    }
}
