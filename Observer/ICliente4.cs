using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Observer
{
    public class ICliente4 : IObserver
    {
        public void subastar(string tipo, string marca, string modelo, string año, int precio)
        {
            InsertarUsuario.usuarios = GuardarUsuarios.DeserializeJsonFile();
            var usuario = InsertarUsuario.usuarios.Find(u => u.Nombre == "Juan Rosario");

            string name, edad;
            int dinero;

            name = usuario.Nombre;
            edad = usuario.Nombre;
            dinero = usuario.DineroBC;

            if (tipo == "suv")
            {
                if (precio >= 1000)
                {

                    Console.WriteLine($"Se ha vendido {marca} {modelo} a {name} en {precio}");
                    Logger.Instance.Log(name, edad, tipo, marca, modelo, año, precio);
                }
                else
                {
                    Console.WriteLine($"{name} no tiene dinero suficiente. \n \n");
                }
            }
        }
    }
}
