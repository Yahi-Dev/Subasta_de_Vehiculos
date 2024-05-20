using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Observer
{
    public class Subasta
    {
        public static string TipoCarro { get; set; }
        public static string MarcaCarro { get; set; }
        public static string ModeloCarro { get; set; }
        public static string AñoCarro { get; set; }
        public static int PrecioCarro { get; set; }

        public List<IObserver> Observers = new List<IObserver>();

        public void AgregarSub(IObserver observer)
        {
            Observers.Add(observer);
        }
        public void QuitarSub(IObserver observador)
        {
            Observers.Remove(observador);
        }

        public void Notificar(string tipo, string marca, string modelo, string año, int precio)
        {

            foreach (var elemento in Observers)
            {
                elemento.subastar(tipo, marca, modelo, año, precio);
            }
        }

        public void Operaciones(string tipo, string marca, string modelo, string año, int precio)
        {
            TipoCarro = tipo;
            MarcaCarro = marca;
            ModeloCarro = modelo;
            AñoCarro = año;
            PrecioCarro = precio;

            Notificar(TipoCarro, MarcaCarro, ModeloCarro, AñoCarro, PrecioCarro);
        }


    }
}
