

namespace ExcPropINterfaces.Servicos
{
    interface IOnlinePaymentService
    {
        //interface de pagamento online genérica

        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
