using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class InsertarCarros
    {
        public static List<ModeloCarro> Carros = new List<ModeloCarro>();

        public void RegistrarCarros()
        {
            ModeloCarro carros1 = new ModeloCarro
            {
                Tipo = "Compacto",
                Marca = "Volskwagen",
                Modelo = "Jetta",
                Año = "2007",
                Precio = 500
            };
            Carros.Add(carros1);
            GuardarCarro.SerializeJsonFile(Carros);

            ModeloCarro carros2 = new ModeloCarro
            {
                Tipo = "Compacto",
                Marca = "Mercedes Benz",
                Modelo = "C class",
                Año = "2017",
                Precio = 1000
            };
            Carros.Add(carros2);
            GuardarCarro.SerializeJsonFile(Carros);

            ModeloCarro carros3 = new ModeloCarro
            {
                Tipo = "Suv",
                Marca = "Volskwagen",
                Modelo = "Tiguan",
                Año = "2022",
                Precio = 1200
            };
            Carros.Add(carros3);
            GuardarCarro.SerializeJsonFile(Carros);

            ModeloCarro carros4 = new ModeloCarro
            {
                Tipo = "Suv",
                Marca = "Mercedes Benz",
                Modelo = "G Wagon",
                Año = "2022",
                Precio = 1800
            };
            Carros.Add(carros4);
            GuardarCarro.SerializeJsonFile(Carros);

            ModeloCarro carros5 = new ModeloCarro
            {
                Tipo = "Sedan",
                Marca = "Kia",
                Modelo = "K5",
                Año = "2023",
                Precio = 1900
            };
            Carros.Add(carros5);
            GuardarCarro.SerializeJsonFile(Carros);
        }
    }
}
