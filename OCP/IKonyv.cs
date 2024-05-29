using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles
{
    public interface IKonyv
    {
        int ID { get; set; }
        string Cim { get; set; }
        string Szerzo { get; set; }
        string KiadasDatuma { get; set; }
        string Statusz { get; set; }
        string Nev { get; set; }
    }

    public class IKonyvImplementation : IKonyv
    {
        public int ID { get; set; }
        public string KonyvCime { get; set; }
        public string Szerzo { get; set; }
        public string KiadasDatuma { get; set; }
        public string Statusz { get; set; }
        public string? Nev { get; set; }
        public string Cim { get; set; }

        public IKonyvImplementation(int IDx, string _konyvcime, string _szerzo, string _kiadasDatuma, string _statusz)
        {
            ID = IDx;
            KonyvCime = _konyvcime;
            Szerzo = _szerzo;
            KiadasDatuma = _kiadasDatuma;
            Statusz = _statusz;
            Cim = _konyvcime;
        }
    }
}
