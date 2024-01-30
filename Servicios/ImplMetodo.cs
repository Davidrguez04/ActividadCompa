using ActividadCompa.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCompa.Servicios
{
    internal class ImplMetodo:InterfazMetodo
    {
        public void pedirNumero(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente= new ClienteDto();

            Console.Write("Introduzca el numero de registros: ");
            int numero=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            

                for(int i=0;i<numero;i++)
                {
                DateTime hora = DateTime.Now;
                string horaAhora = hora.Hour + ":" + hora.Minute + ":" + hora.Second;

                Console.WriteLine("Introduzca el nombre: ");
                    cliente.Nombre = Console.ReadLine();

                    Console.WriteLine("Introduzca el dni: ");
                    cliente.Dni = Console.ReadLine();

                    Console.WriteLine("Introduzca el telefono: ");
                    cliente.NumeroTelefono = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hora del registro: "+horaAhora);

                Console.WriteLine();

                }
            
            listaClientes.Add(cliente);
        }

        public void pedirNombre(List<ClienteDto>listaClientes)
        {
            ClienteDto cliente=new ClienteDto();
            int cont = 0;
           

            bool salir = false;
            do
            {
                Console.WriteLine("Introduce el nombre del registro: ");
                cliente.Nombre = Console.ReadLine();
                cont++;
                if (cont > 3)
                {
                    
                    Console.WriteLine("\nHas fallado 3 veces, saliendo del programa...");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("\nIntento numero: " + cont);
                    foreach (ClienteDto clienteDto in listaClientes)
                    {
                        if (clienteDto.Nombre.Equals(cliente.Nombre))
                        {

                            cliente = clienteDto;
                            Console.WriteLine(cliente.ToString());
                            salir = true;
                        }
                        else
                        {
                            Console.Write("\n¡¡Nombre no registrado!!\n");
                            salir = false;
                        }
                    }
                }
            } while (!salir);
        }
    }
}
