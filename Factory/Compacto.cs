using Examen.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Factory
{
    public class Compacto
    {
        public void CarroCompacto()
        {
            Subasta Subasta = new Subasta();

            ICliente2 cliente2 = new ICliente2();
            ICliente3 cliente3 = new ICliente3();

            Subasta.AgregarSub(cliente2);
            Subasta.AgregarSub(cliente3);

            var usuario = InsertarCarros.Carros.Find(u => u.Tipo == "Compacto");

            Subasta.Operaciones(usuario.Tipo, usuario.Marca, usuario.Modelo, usuario.Año, usuario.Precio);

            Console.ReadKey();

         //   Subasta.QuitarSub(cliente3);

            Subasta.Operaciones(usuario.Tipo, usuario.Marca, usuario.Modelo, usuario.Año, usuario.Precio);
        }
    }
}
