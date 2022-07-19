using System;
using System.Collections.Generic;


namespace ExcPropINterfaces.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<installment>();
        }

        public void AddInstallment(installment installment)
        {
            Installments.Add(installment);
        }
    }
}
