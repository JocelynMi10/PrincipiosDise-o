using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{
    public class Empresa
    {
        /*Refactorizar el código para separar las responsabilidades de contratación y
procesamiento de pagos.*/
        // Realizar la separación de responsabilidades en la clase Empresa
        private RRHH rrhh;
        private Contabilidad contabilidad;

        public Empresa(RRHH rrhh, Contabilidad contabilidad)
        {
            this.rrhh = rrhh;
            this.contabilidad = contabilidad;
        }

        public void ContratarEmpleado(string nombre)
        {
            rrhh.ContratarEmpleado(nombre);
        }

        public void ProcesarPago(string nombre, double salario)
        {
            contabilidad.ProcesarPago(nombre, salario);
        }


    }


    public class RRHH
    {
        public void ContratarEmpleado(string nombre)
        {
            Console.WriteLine($"Empleado {nombre} contratado.");
        }
    }

    public class Contabilidad
    {
        public void ProcesarPago(string nombre, double salario)
        {
            Console.WriteLine($"Procesando pago de {salario} a {nombre}.");
        }
    }
}
