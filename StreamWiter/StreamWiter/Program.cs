using System;
using System.IO;

namespace StreamWiter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\testeFileFileinfoIOexception\file1.txt";
            string targetPath = @"C:\testeFileFileinfoIOexception\file2.txt";

            try
            {
                //ler todo conteudo do sourcePath e guardar no vetor de strings:
              string [] lines = File.ReadAllLines(sourcePath);

                //instanciar o streamWriter p escrever no arquivo de saída:
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                       
                    }
                }


            }catch(IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*
 * escreve caracteres a partir de uma stream binaria
 * mesma coisa do stream writer, só que agora para escrever em vez de ler
 * instancia o file stream, depois o stream writer a partir do filestream
 * tbm tem vários construtores e pode ser instanciado pelo file e fileinfo
 * palavra append: significa contatenação, acrescenta NO FINAL DO ARQUIVO
 * 
 */
