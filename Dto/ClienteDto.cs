using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCompa.Dto
{
    internal class ClienteDto
    {
        //Atributos
        string nombre;
        string dni;
        int numeroTelefono;

       

        //Constructores
        public ClienteDto(string nombre, string dni, int numeroTelefono)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.numeroTelefono = numeroTelefono;
        }

        public ClienteDto()
        {
        }

        //Getters y setters
        public string Nombre { get => nombre; set => nombre = value; }
        public string Dni { get => dni; set => dni = value; }
        public int NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }

        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "\nDatos:\nNombre: " + this.nombre +
                "\nDNI: " + this.dni +
                "\nNumero Telefono: " + this.numeroTelefono;

            return mensaje;
        }

    }
}
