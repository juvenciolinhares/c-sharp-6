

namespace ExcPropINterfaces.Servicos
{
    //paypalservice é um tipo de pagamento online(IOnlinePaymentService)
    internal class PaypalService : IOnlinePaymentService
    {
        //juros constantes
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        //metodo p atualizar o valor da quota de cada mês
        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        //metodo p calcular os juros referentes ao servico de pagamento online PaypalService
        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
