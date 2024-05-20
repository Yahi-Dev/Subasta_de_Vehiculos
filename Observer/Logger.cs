using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Observer
{
    public sealed class Logger
    {
        public static string TxtLog = @"Descargas\InfoCompra.txt";
        private static Logger instance;
        private readonly string logFilePath;

        private Logger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    string logFilePath = TxtLog;
                    instance = new Logger(logFilePath);
                }
                return instance;
            }
        }

        public void Log(string nombre, string edad, string tipo, string marca, string modelo, string año, int precio)
        {
            string logEntry = $@"
< - > < - > < - > < - > < - > < - > < - > < - > 
|   Name: {nombre}
|   Edad: {edad}
|-----------------VEHICULO------------------------
|   Tipo: {tipo}                        
|   Marca: {marca}
|   Modelo: {modelo}
|   Áño: {año}
|   Precio: {precio}
|   Fecha: {DateTime.Now}
< - > < - > < - > < - > < - > < - > < - > < - > ";
            try
            {
                using (StreamWriter sw = File.AppendText(logFilePath))
                {
                    sw.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de log: {ex.Message}");
            }
        }
    }
}
