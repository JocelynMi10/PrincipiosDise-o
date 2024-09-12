using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{

    /*Refactorizar el código para que Coche dependa de una interfaz en lugar de
    una implementación concreta, permitiendo el uso de diferentes tipos de
    motor.*/

    public interface IMotor
    {
        void Encender();
    }

    public class Motor1 : IMotor
    {
        public void Encender()
        {
            Console.WriteLine("Motor encendido.");
        }
    }

    public class MotorElectrico : IMotor
    {
        public void Encender()
        {
            Console.WriteLine("Motor eléctrico encendido.");
        }
    }
    public class Coche1
    {
        private IMotor motor;

        public Coche1(IMotor motor)
        {
            this.motor = motor;
        }

        public void Encender()
        {
            motor.Encender();
        }
    }
   
}
