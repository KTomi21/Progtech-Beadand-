using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.OCP
{
    public static class KeresesiStrategiaFactory
    {
        public static IKeresesiStrategia GetStrategia(string keresesiTipus)
        {
            switch (keresesiTipus)
            {
                case "Cím alapján":
                    return new CimAlapjanKereses();
                case "Szerző alapján":
                    return new SzerzoAlapjanKereses();
                case "Kiadás dátuma szerint":
                    return new KiadasDatumaAlapjanKereses();
                default:
                    throw new ArgumentException("Érvénytelen keresési típus");
            }
        }
    }
}
