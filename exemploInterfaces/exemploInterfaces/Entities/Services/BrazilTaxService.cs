
/*serviço que retorna a quantidade de imposto dada uma quantia de dinheiro
 vai ser um SUBTIPO DE TAXSERVICE*/

namespace exemploInterfaces.Entities.Services


{
    internal class BrazilTaxService : ITaxService //BrazilTaxService é um ITaxService(lembra herança, mas não é)
    {
        /*a assinatura desse método está compativel com a da interface, então ja esta pronto
         * mas se o metodo, por exemplo, tivesse outro nome, o compilador iria reclamar
         * */
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
