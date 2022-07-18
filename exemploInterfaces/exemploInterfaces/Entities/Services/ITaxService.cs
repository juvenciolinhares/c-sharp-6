
namespace exemploInterfaces.Entities.Services
{
    interface ITaxService
    {
        //define apenas o contrato, espera um serviço de imposto qualquer
        double Tax(double amount);
    }
}
