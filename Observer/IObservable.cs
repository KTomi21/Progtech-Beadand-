using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.Observer
{
    public interface IObservable
    {
        void HozzaadObserver(IObserver observer);
        void TorolObserver(IObserver observer);
        void ErtesitObservers(string message);
    }
}