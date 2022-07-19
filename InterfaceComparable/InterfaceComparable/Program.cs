using System;
using System.IO;
using System.Collections.Generic;
using InterfaceComparable.Entities;

namespace InterfaceComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\testeInterfaceIComparable\in.txt";
            try
            {
                //ler e guardar na lista:
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));//novo funcionario lendo uma linha do arquivo .txt
                    }

                    //ordenar a lista:
                    list.Sort();//faz o uso da interface IComparable, ou seja, pra ordenar tem que comparar
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
