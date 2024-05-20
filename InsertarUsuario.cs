using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class InsertarUsuario
    {
        public static List<ModeloUsuario> usuarios = new List<ModeloUsuario>();

        public void RegistrarUsuario()
        {
            ModeloUsuario usuario1 = new ModeloUsuario
            {
                Nombre = "Yahinniel Vasquez",
                Edad = "27",
                DineroBC = 2000
            };
            usuarios.Add(usuario1);
            GuardarUsuarios.SerializeJsonFile(usuarios);

            ModeloUsuario usuario2 = new ModeloUsuario
            {
                Nombre = "Yajaira Vasquez",
                Edad = "47",
                DineroBC = 7000
            };
            usuarios.Add(usuario2);
            GuardarUsuarios.SerializeJsonFile(usuarios);

            ModeloUsuario usuario3 = new ModeloUsuario
            {
                Nombre = "Angelo Vasquez",
                Edad = "17",
                DineroBC = 3000
            };
            usuarios.Add(usuario3);
            GuardarUsuarios.SerializeJsonFile(usuarios);

            ModeloUsuario usuario4 = new ModeloUsuario
            {
                Nombre = "Juan Rosario",
                Edad = "37",
                DineroBC = 2500
            };
            usuarios.Add(usuario4);
            GuardarUsuarios.SerializeJsonFile(usuarios);

            ModeloUsuario usuario5 = new ModeloUsuario
            {
                Nombre = "Ronald Vasquez",
                Edad = "29",
                DineroBC = 1800
            };
            usuarios.Add(usuario5);
            GuardarUsuarios.SerializeJsonFile(usuarios);

            ModeloUsuario usuario6 = new ModeloUsuario
            {
                Nombre = "Ashley Classe",
                Edad = "22",
                DineroBC = 2100
            };
            usuarios.Add(usuario6);
            GuardarUsuarios.SerializeJsonFile(usuarios);

            ModeloUsuario usuario7 = new ModeloUsuario
            {
                Nombre = "Orison Soto",
                Edad = "46",
                DineroBC = 1750
            };
            usuarios.Add(usuario7);
            GuardarUsuarios.SerializeJsonFile(usuarios);
        }
    }
}
