using Examen.Factory;

namespace Examen
{
    internal class Program
    {
        public static string JsonPath = @"Descargas\InfoCarros.json";
        public static string TxtLog = @"Descargas\InfoCompra.txt";
        public static string JsonPath2 = @"Descargas\Infousuarios.json";
        static void Main(string[] args)
        {
            if (!Directory.Exists("Descargas"))
            {
                Directory.CreateDirectory("Descargas");
            }

            if (!File.Exists(JsonPath))
                File.CreateText(JsonPath);

            if (!File.Exists(TxtLog))
                File.CreateText(TxtLog);

            if (!File.Exists(JsonPath2))
                File.CreateText(JsonPath2);


            InsertarCarros insertarCarros = new InsertarCarros();
            insertarCarros.RegistrarCarros();

            InsertarUsuario insertarUsuario = new InsertarUsuario();
            insertarUsuario.RegistrarUsuario();

            Factory.Factory factory = new Factory.Factory();
            factory.Fabrica("Sedan");
        }
    }
}