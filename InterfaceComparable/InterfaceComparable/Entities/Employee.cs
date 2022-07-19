using System;
using System.Globalization;

namespace InterfaceComparable.Entities
{
    internal class Employee : IComparable//implemento IComparable para que o método  list.Sort(); possa comparar e ordenar.
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployye)//arquivo que vai ser recebido do dodumento .txt
        {
            string[] vect = csvEmployye.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        //metodo de IComparable que  compara um objeto passado no parametro
        public int CompareTo(object obj)//compara 2 obj e retorna um inteiro: -1: menor, 0 :igual, 1: maior;
        {
            //comparar um funcionario com outro

            //escolho comparar por nome
            if (!(obj is Employee))//comparo se o obj do arguemento é do tipo employye
            {
                throw new ArgumentException("Comparer error: argument is not an Employee");
            }

            Employee other = obj as Employee;// downcast(o employee other recebe o obj do argumento)

            return Name.CompareTo(other.Name);//o tipo string ja implementa comparable

        }
    }
}
