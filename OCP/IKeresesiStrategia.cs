using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.OCP
{
    public interface IKeresesiStrategia
    {
        List<IKonyv> Kereses(List<IKonyv> konyvek, string keresesiKriterium);
    }
}
