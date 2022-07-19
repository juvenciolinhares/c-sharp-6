using System;
using System.Globalization;


namespace ExcPropINterfaces.Entities
{
    internal class installment
    {
        public DateTime DueDate { get; set; }//data de vencimento
        public double Amount { get; set; }//quantia

        public installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
