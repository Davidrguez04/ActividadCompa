/*Concepto principal: Uso del Date time con sus valores y uso de objetos conlistas para guardar datos
 * e imprimirlos con contadores.
 * 
 * Enunciado:
 Haz un programa donde pidas por consola un numero de alumnos y con ese numero
crea una lista de ese tamaño donde preguntes el nombre, el dni y el numero de telefono
y guardalos en un objeto cliente.
Y pregunta segun el nombre para enseñar solo sus datos
Crea las clases necesarias para hacer los metodos y objeto cliente
Por ultimo al preguntar el nombre para ver los datos cuenta si falla al poner el nombre
y si falla mas de 2 veces haz que termine el programa
Cada vez que pregunte el nombre imprima por consola el numero de intento en orden
Cada vez que se haga un registro poner la Hora del registro con el datetime sin el dia y
que cambie correspondiente mente en cada registro segun acabe de hacerlo.

Criterio:
-Objeto cliente bien creado 2
-Hora registro 0,5
-Contador intentos 0,5
-Comentarios 0,5
-Metodo pedir cliente y registrar 3,5
-Metodo pedir nombre y mostrar 3

Total:10
*/

using ActividadCompa.Dto;
using ActividadCompa.Servicios;

namespace ActividadCompa.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazMetodo im=new ImplMetodo();
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            im.pedirNumero(listaClientes);

            im.pedirNombre(listaClientes);
        }
    }
}
