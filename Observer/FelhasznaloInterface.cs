using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyvtar_Rendszer_Kezeles.Observer
{
    public class FelhasznaloInterface : IObserver
    {
        public void Update(string message)
        {
            MessageBox.Show(message);
        }
    }
}