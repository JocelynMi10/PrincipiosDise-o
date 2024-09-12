using PrincipiosDiseño;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{
   
public class Motor
    {
        public void EncenderMotor()
        {
            Console.WriteLine("Motor encendido.");
        }
    }

}
public class Bicicleta
{
    private Motor motor; // Composición

    public Bicicleta()
    {
        motor = new Motor(); // Inicialización  de la composición en el constructor


    }


        public void Pedalear()
    {
        Console.WriteLine("Pedaleando...");
    }

    public void EncenderMotor()
    {
        motor.EncenderMotor(); //Uso de la composición
    }
}