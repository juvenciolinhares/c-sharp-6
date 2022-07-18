
using System;
using exemploInterfaces.Entities;

//processa um aluguel e gera a nota de pagamento(invoice)

namespace exemploInterfaces.Entities.Services
{
    internal class RentalService
    {
        //só posso pegar os valores, não posso altera-los
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //espera um serviço genérico de imposto
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;//inversão de controle por meio de injeção de dependencia
        }

        public void ProcessInvoice(CarRental carRental)
        {
            //diferenca entre aluguel e entrega do carro:
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            //calcular pagamento básico:
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);//Math.Ceiling ARREDONDA PRA CIMA
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            //calculo do valor do imposto:
            double tax = _taxService.Tax(basicPayment);//calcula o imposto baseado no pagemtno gerado acima

            //instanciar o invoice e associar ao carRental:
            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
