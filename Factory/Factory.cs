using System;
using System.Collections.Generic;
using System.Linq;
using Examen;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Factory
{
    public class Factory
    {
        public void Fabrica(string tipoCarro)
        {
            switch (tipoCarro)
            {
                case "Sedan":
                    Sedan sedan = new Sedan();
                    sedan.CarroSedan();
                    break;

                case "Suv":
                    Suv suv = new Suv();
                    suv.CarroSuv();
                    break;

                case "Compacto":
                    Compacto compacto = new Compacto();
                    compacto.CarroCompacto();
                    break;
            }
        }
    }
}
