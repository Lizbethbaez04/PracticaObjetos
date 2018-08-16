using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaObjetos
{
    class Contacto
    {
        //Autoproperties
        public string Nombre { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoCelular { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }

        //Constructor
        public Contacto()
        {
            Nombre = "Nuevo contacto";
            TelefonoCasa = "(000) 000-000";
        }

        //Sobre carga para costructor
        public Contacto( string nombre)
        {
            Nombre = nombre;
        }
        //se diferencia por el tipo de datos, no se puede repetir el mismo tipo de dato
        public Contacto(string nombre, string telefonoCasa,string telefonoCelular, string direccion,string correoElectronico)
        {
            //los mayuscula es la propertie de la clase y los minuscula son los parametros del contructor
            Nombre = nombre;
            TelefonoCelular = telefonoCelular;
            TelefonoCasa = telefonoCasa;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
    }
}
