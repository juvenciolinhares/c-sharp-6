using System;
using System.Globalization;
using ExcPropINterfaces.Entities;
using ExcPropINterfaces.Servicos;

namespace ExcPropINterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //dados do contrato
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            //instacia do contrato
            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            //instancio meu contrato de serviço de pagamento online PaypalService
            ContractService contractService = new ContractService(new PaypalService());

            //calculo das parcelas referentes a cada mês:
            contractService.ProcessContract(myContract, months);

            //lista de parcelas com o valor de cada uma delas 
            Console.WriteLine("Installments:");
            foreach (installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
/*
 * 1 parcel é uma mes depois da data do contrato
 * entender calculo da parcela: 1% de juros simples + 2% de taxa de pagamento
 * valor basico de cada parcela é 200 * tx de juro mensal(1%) * 1(mes 1), juro = 2 pq é 1% de 200
 * 202 + uma taxa de 2% = 206.04
 * 
 * calculo p mes 2:
 * 200 * 1% * 2= 204
 * 204 * 2% = 208.08
 * 
 * calculo p mes 3:
 * 200*1%*3 = 206
 * 206+ 2% = 210.12
 * 
 * 
 * 
 */