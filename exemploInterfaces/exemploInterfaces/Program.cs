using System;
using System.Globalization;
using exemploInterfaces.Entities;
using exemploInterfaces.Entities.Services;

namespace exemploInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instanciar aluguel associado à classe vehicle:
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            //instanciar o rental ser4vice para processar o aluguel:
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            //gerar o invoice associado ao aluguel
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("INVOICE");
            Console.WriteLine(carRental.Invoice);



        }
    }
}
