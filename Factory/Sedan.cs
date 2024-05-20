using Examen.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Factory
{
    public class Sedan
    {
        public void CarroSedan()
        {
            Subasta Subasta = new Subasta();

            ICliente1 cliente1 = new ICliente1();
            ICliente6 cliente6 = new ICliente6();

            Subasta.AgregarSub(cliente1);
            Subasta.AgregarSub(cliente6);

            var usuario = InsertarCarros.Carros.Find(u => u.Tipo == "Sedan");

            Subasta.Operaciones("Sedan", usuario.Marca, usuario.Modelo, usuario.Año, usuario.Precio);

            Console.ReadKey();

            //Subasta.QuitarSub(cliente1);

            Subasta.Operaciones(usuario.Tipo, usuario.Marca, usuario.Modelo, usuario.Año, usuario.Precio);
        }
    }
}