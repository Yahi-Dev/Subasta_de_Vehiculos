using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Examen
{
    public class GuardarCarro
    {
        public static string JsonPath = @"Descargas\InfoCarros.json";
        public static string TxtLog = @"Descargas\InfoCompra.txt";
        public static void SerializeJsonFile(List<ModeloCarro> carros)
        {
            string informacionJson = JsonConvert.SerializeObject(carros.ToArray(), Formatting.Indented);
            File.WriteAllText(JsonPath, informacionJson);
        }

        public static List<ModeloCarro> GetCarrosInformacion(string tipo, string marca, string modelo, string año, int precio)
        {
            List<ModeloCarro> carros = new List<ModeloCarro>
            {
                new ModeloCarro
                {
                    Tipo = tipo,
                    Marca = marca,
                    Modelo = modelo,
                    Año = año,
                    Precio = precio
                }
            };
            SerializeJsonFile(carros);
            return carros;
        }

        public static string GetInformacion()
        {
            string informacionRegistro;
            using (var reader = new StreamReader(JsonPath))
            {
                informacionRegistro = reader.ReadLine();
            }
            return informacionRegistro;
        }

        public static List<ModeloCarro> DeserializeJsonFile()
        {
            try
            {
                string jstonText = File.ReadAllText(JsonPath);
                List<ModeloCarro> carros = JsonConvert.DeserializeObject<List<ModeloCarro>>(jstonText);
                return carros;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los usuarios registrados: " + ex.Message);
                return new List<ModeloCarro>();
            }
        }
    }
}
