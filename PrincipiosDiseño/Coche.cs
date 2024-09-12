using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{ /*Refactorizar el código para aplicar el principio de abstracción, de manera
que el usuario de la clase Coche no tenga que preocuparse por los detalles
de implementación.
*/
    public class Coche
    {
        public void Encender()
        {
            if (PuedeEncender())
            {
                Console.WriteLine("Coche encendido.");
            }
            else
            {
                Console.WriteLine("No hay suficiente combustible.");
            }
        }

        private bool PuedeEncender()
        {
            // Lógica para verificar si se puede encender
            return HayCombustible(); // Supongamos que siempre hay combustible
        }
        private bool HayCombustible()
        {
            // Lógica para verificar el combustible
            return true; // Supongamos que siempre hay combustible
        }
    }

}
