using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosDiseño
{
    public class SistemaDeVentas

    {       // Inyección de dependencias
        
        private IEmailService _emailService;

        // La clase SistemaDeVentas depende de IEmailService para enviar correos electrónicos
        public SistemaDeVentas(IEmailService emailService)
        {
            _emailService = emailService;
        }

        // Método Facturar
        public void Facturar()
 {
        Console.WriteLine("Facturando...");
 
            _emailService.EnviarEmail("Factura enviada.");
 }
}

    // Interfaz IEmailService para enviar correos electrónicos
    public interface IEmailService
    {
        void EnviarEmail(string mensaje);
    }

    
    public class EmailService
{
    public void EnviarEmail(string mensaje)
 {
    Console.WriteLine($"Enviando email: {mensaje}");
 }
}
}
