using System;

namespace exemploInterfaces.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }//associação com a classe vehicle
        public Invoice Invoice { get; set; }//associação com a classe Invoice

       public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;// só vai ser gerado quando for processado o aluguel
        }
    }
}
