using System;
using ExcPropINterfaces.Servicos;
using ExcPropINterfaces.Entities;

namespace ExcPropINterfaces.Servicos
{
    class ContractService
    {
        //interface de pagamento de serviço onlione
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;//paypalservice
        }

        //calculo mensal:
        public void ProcessContract(Contract contract, int months)
        {

            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);//atualização do mês

                //em cada mês é calculado o valor de basicquota * 1% * mes vigente(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                
                //updatequota + juros do serviço de pagamento online, no caso 2%
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                //adição desse valor total(fullQuota) na lista de parcelas 
                contract.AddInstallment(new installment(date, fullQuota));
            }
        }
    }
}