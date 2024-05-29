using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Konyvtar_Kezeles_Rendszer;

namespace UnitTests
{
    public class KonyvtarRendszerTests2
    {
        [Fact]
        public void KiadKonyv()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new KonyvekKiadasa { ID = 1, KonyvCime = "Harry Potter" };
            konyvtarRendszer.KiadKonyv(konyv);

            Assert.Contains(konyv, konyvtarRendszer.GetKiadottKonyvek(), k => k.KonyvCime == konyv.KonyvCime);
        }

        [Fact]
        public void VisszaKonyv()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new VisszahozottKonyvek { ID = 1, KonyvCime = "Harry Potter" };
            var observerMock = new Mock<IObserver>();
            konyvtarRendszer.HozzaadObserver(observerMock.Object);
            konyvtarRendszer.VisszaKonyv(konyv);

            Assert.Contains(konyv, konyvtarRendszer.GetVisszahozottKonyvek());
            observerMock.Verify(o => o.Update("Könyv visszavétele:" + KonyvCime = "Harry Potter"), Times.Once);
        }

        [Fact]
        public void RemoveVisszahozottKonyv()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new VisszahozottKonyvek { ID = 1, KonyvCime = "Harry Potter" };
            var observerMock = new Mock<IObserver>();
            konyvtarRendszer.HozzaadObserver(observerMock.Object);
            konyvtarRendszer.VisszaKonyv(konyv);
            konyvtarRendszer.VisszahozottKonyvTorlese(konyv);

            Assert.DoesNotContain(konyv, konyvtarRendszer.GetVisszahozottKonyvek());
            observerMock.Verify(o => o.Update("Visszahozott könyv eltávolítva ID: 1"), Times.Once);
        }

        [Fact]
        public void GetKonyvek()
        {
            ar konyvtarRendszer = new KonyvtarRendszer();
            var konyv1 = new KonyvekHozzaadasa { ID = 1, KonyvCime = "Harry Potter" };
            var konyv2 = new KonyvekHozzaadasa { ID = 2, KonyvCime = "A kis herceg" };

            konyvtarRendszer.AddKonyv(konyv1);
            konyvtarRendszer.AddKonyv(konyv2);
            var konyvek = konyvtarRendszer.GetKonyvek();

            Assert.Contains(konyvek, k => k.ID == konyv1.ID);
            Assert.Contains(konyvek, k => k.ID == konyv2.ID);
        }

        [Fact]
        public void GetElerhetoKonyvek()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new KonyvekHozzaadasa { ID = 1, KonyvCime = "Harry Potter", Statusz = "Elérhető" };
            konyvtarRendszer.AddKonyv(konyv);
            var elerhetoKonyvek = konyvtarRendszer.GetElerhetoKonyvek();

            Assert.Contains(elerhetoKonyvek, k => k.KonyvCime == konyv.KonyvCime && k.Statusz == konyv.Statusz);
        }
    }
}
