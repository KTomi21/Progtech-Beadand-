using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Konyvtar_Rendszer_Kezeles;

namespace UnitTests
{
    public class KonyvtarRendszerTests1
    {
        [Fact]
        public void HozzaadObserver_ObserverHozzaadva()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var observer = new Mock<IObserver>().Object;

            konyvtarRendszer.HozzaadObserver(observer);
            Assert.Contains(observer, konyvtarRendszer.GetObservers());
        }

        [Fact]
        public void TorolObserver_ObserverEltavolitva()
        {

            var konyvtarRendszer = new KonyvtarRendszer();
            var observer = new Mock<IObserver>().Object;
            konyvtarRendszer.HozzaadObserver(observer);

            konyvtarRendszer.TorolObserver(observer);

            Assert.DoesNotContain(observer, konyvtarRendszer.GetObservers());
        }

        [Fact]
        public void AddKonyv_KonyvHozzaadvaEsErtesitve()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new KonyvekHozzaadasa { ID = 1, KonyvCime = "Harry Potter" };
            var observerMock = new Mock<IObserver>();
            konyvtarRendszer.HozzaadObserver(observerMock.Object);

            konyvtarRendszer.AddKonyv(konyv);

            Assert.Contains(konyv, konyvtarRendszer.GetKonyvek());
            observerMock.Verify(o => o.Update("Új könyv hozzáadva: Harry Potter"), Times.Once);
        }

        [Fact]
        public void RemoveKonyv_KonyvEltavolitvaEsErtesitve()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var konyv = new KonyvekHozzaadasa { ID = 1, KonyvCime = "Harry Potter" };
            var observerMock = new Mock<IObserver>();
            konyvtarRendszer.HozzaadObserver(observerMock.Object);
            konyvtarRendszer.AddKonyv(konyv);

            konyvtarRendszer.RemoveKonyv(1);

            Assert.DoesNotContain(konyv, konyvtarRendszer.GetKonyvek());
            observerMock.Verify(o => o.Update("Könyv eltávolítva ID: 1"), Times.Once);
        }

        [Fact]
        public void ValtozasKonyvStatusz_Ertesitve()
        {
            var konyvtarRendszer = new KonyvtarRendszer();
            var observerMock = new Mock<IObserver>();
            konyvtarRendszer.HozzaadObserver(observerMock.Object);

            konyvtarRendszer.ValtozasKonyvStatusz("Elérhető");

            observerMock.Verify(o => o.Update("A könyv státusza megváltozott: Elérhető"), Times.Once);
        }
    }
}
