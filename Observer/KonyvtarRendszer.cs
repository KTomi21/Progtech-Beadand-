using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konyvtar_Rendszer_Kezeles.Class;

namespace Konyvtar_Rendszer_Kezeles.Observer
{
    static class testClass
    {
        private static List<IKonyv> Ikonyvek = new List<IKonyv>();

        public static void AddIKonyvek(KonyvekHozzaadasa konyv)
        {
            IKonyvImplementation temp_newInterfaceItem = new IKonyvImplementation(IDx: konyv.ID, _konyvcime: konyv.KonyvCime, _szerzo: konyv.Szerzo,
                _kiadasDatuma: konyv.KiadasDatuma, _statusz: konyv.Statusz);
            Ikonyvek.Add(temp_newInterfaceItem);
        }

        public static List<IKonyv> GetIKonyvek()
        {
            return Ikonyvek;
        }
    }

    public class KonyvtarRendszer : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<KonyvekHozzaadasa> konyvek = new List<KonyvekHozzaadasa>();
        private List<KonyvekKiadasa> kiadottKonyvek = new List<KonyvekKiadasa>();
        private List<VisszahozottKonyvek> visszahozottKonyvek = new List<VisszahozottKonyvek>();

        public void ErtesitObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        public int GetNextId()
        {
            return konyvek.Count + 1;
        }

        public void HozzaadObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void TorolObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void AddKonyv(KonyvekHozzaadasa konyv)
        {
            konyvek.Add(konyv);
            ErtesitObservers("Új könyv hozzáadva: " + konyv.KonyvCime);
            testClass.AddIKonyvek(konyv);
        }

        public void RemoveKonyv(int id)
        {
            var konyv = konyvek.FirstOrDefault(k => k.ID == id);
            if (konyv != null)
            {
                konyvek.Remove(konyv);
                ErtesitObservers("Könyv eltávolítva ID: " + id);
            }
        }

        public void ValtozasKonyvStatusz(string newStatusz)
        {
            ErtesitObservers("A könyv státusza megváltozott: " + newStatusz);
        }

        public void KiadKonyv(KonyvekKiadasa konyv)
        {
            kiadottKonyvek.Add(konyv);
        }

        public void VisszaKonyv(VisszahozottKonyvek konyv)
        {
            visszahozottKonyvek.Add(konyv);
            ErtesitObservers("Könyv visszavéve: " + konyv.KonyvCime);
        }

        public void RemoveVisszahozottKonyv(int id)
        {
            var visszahozottKonyv = visszahozottKonyvek.FirstOrDefault(k => k.ID == id);
            if (visszahozottKonyv != null)
            {
                visszahozottKonyvek.Remove(visszahozottKonyv);
                ErtesitObservers("Visszahozott könyv eltávolítva ID: " + id);
            }
        }

        public List<KonyvekHozzaadasa> GetKonyvek()
        {
            return konyvek;
        }

        public List<KonyvekHozzaadasa> GetElerhetoKonyvek()
        {
            return konyvek.Where(k => k.Statusz.Equals("Elérhető", StringComparison.OrdinalIgnoreCase)).Cast<KonyvekHozzaadasa>().ToList();
        }
    }
}
