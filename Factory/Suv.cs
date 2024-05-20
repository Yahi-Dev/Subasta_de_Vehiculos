using Examen.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Factory
{
    public class Suv
    {
        public void CarroSuv()
        {
            Subasta Subasta = new Subasta();

            ICliente4 cliente4 = new ICliente4();
            ICliente5 cliente5 = new ICliente5();

            Subasta.AgregarSub(cliente4);
            Subasta.AgregarSub(cliente5);

            var usuario = InsertarCarros.Carros.Find(u => u.Tipo == "Suv");

            Subasta.Operaciones(usuario.Tipo, usuario.Marca, usuario.Modelo, usuario.Año, usuario.Precio);

            Console.ReadKey();

           // Subasta.QuitarSub(cliente4);

            Subasta.Operaciones(usuario.Tipo, usuario.Marca, usuario.Modelo, usuario.Año, usuario.Precio);
        }
    }
}
