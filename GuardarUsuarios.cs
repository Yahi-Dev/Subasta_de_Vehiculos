using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class GuardarUsuarios
    {
        public static string JsonPath2 = @"Descargas\Infousuarios.json";
        public static void SerializeJsonFile(List<ModeloUsuario> usuarios)
        {
            string informacionJson = JsonConvert.SerializeObject(usuarios.ToArray(), Formatting.Indented);
            File.WriteAllText(JsonPath2, informacionJson);
        }

        public static List<ModeloUsuario> GetCarrosInformacion(string nombre, string edad, int dinero)
        {
            List<ModeloUsuario> usuarios = new List<ModeloUsuario>
            {
                new ModeloUsuario
                {
                    Nombre = nombre,
                    Edad = edad,
                    DineroBC = dinero
                }
            };
            SerializeJsonFile(usuarios);
            return usuarios;
        }

        public static string GetInformacion()
        {
            string informacionRegistro;
            using (var reader = new StreamReader(JsonPath2))
            {
                informacionRegistro = reader.ReadLine();
            }
            return informacionRegistro;
        }

        public static List<ModeloUsuario> DeserializeJsonFile()
        {
            try
            {
                string jstonText = File.ReadAllText(JsonPath2);
                List<ModeloUsuario> usuarios = JsonConvert.DeserializeObject<List<ModeloUsuario>>(jstonText);
                return usuarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los usuarios registrados: " + ex.Message);
                return new List<ModeloUsuario>();
            }
        }
    }
}
