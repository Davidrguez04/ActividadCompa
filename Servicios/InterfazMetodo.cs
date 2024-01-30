using ActividadCompa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCompa.Servicios
{
    internal interface InterfazMetodo
    {
        public void pedirNumero(List<ClienteDto> listaClientes);

        public void pedirNombre(List<ClienteDto> listaClientes);
    }
}
