using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{
    public class ProcesadorDeOrdenes
    {
        /*Refactorizar el código dividiéndolo en módulos más pequeños y
autónomos.*/

        public void ProcesarOrden()
            {

            Console.WriteLine("Procesando orden...");
            CalcularImpuestos();
            ProcesarPago();
        }
       
        public void CalcularImpuestos()
        {
            Console.WriteLine("Calculando impuestos...");
        }

        public void ProcesarPago()
        {
            Console.WriteLine("Procesando pago...");
        }

    }
}
