using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Observer
{
    public interface IObserver
    {
        void subastar(string tipo, string marca, string modelo, string año, int precio);
    }
}
