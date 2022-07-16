using System;
using System.IO;

namespace BlocoUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\testeFileFileinfoIOexception\file1.txt";

            //abrir o bloco using
            try
            {

                using (StreamReader sr = File.OpenText(path)) 
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*
    * garante o fechamento de objetos IDisposable
    *objeto idisposable são aqueles que nao sao gerenciados pelo clr 
    *exemplo: font, filestream,streamreader,streamwriter
    *tudo que for criado dentro do usgin vai ser fechado junto com o escopo do bloco
    *posso fazer bloco using dentro de bloco using

 */
