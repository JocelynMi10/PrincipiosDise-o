using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{

    /*Refactorizar el código para proteger el acceso a los datos internos de
CuentaBancaria utilizando el encapsulamiento.*/
    public class CuentaBancaria
    {
        private decimal saldo;
        public void Depositar(decimal cantidad)
        {
            saldo += cantidad;
        }
    }
}
