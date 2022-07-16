using System;
using System.IO;// importar File, FileInfo,Ioexception

namespace FileFileFoundIoException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar um arquivo no sistema

            //caminho do arquivo (o @ antes da string é pra substituir a barra dupla: \\):
            
            string soucerpath = @"C:\testeFileFileinfoIOexception\file1.txt"; 
           
            //caminho do arquivo de destino:
            string targetpath = @"C:\testeFileFileinfoIOexception\file2.txt";

            //tudo que eu mexer com arquivo tem que ser em um bloco try:
            try
            {
                //instanciar um fileinfo:
                FileInfo fileinfo = new FileInfo(soucerpath);//instaciar um objeto associado ao caminho do parametro
               
                //operação que copia o arquivo da origem para um destino dentro dos parametros:
                fileinfo.CopyTo(targetpath);//cria um outro arquivo no diretório

                //se eu rodar de novo o programa vai dar erro por que o arquivo ja foi criado

                /*usar classe file(não preciso instanciar um objeto):
                *ler todas as linhas do arquivo e guarda como elemento do vetor lines[,]
                *como estou usando a classe file, n tem arquivo instanciado, 
                *entao tenho que passar o arquivo como argumento da função
                */


                string[] lines = File.ReadAllLines(soucerpath);//ler o conteúdo de sourcepath

                //pra percorrer o verto, faz um foreach:
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }


            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine( e.Message);
            }
        }   
    }
}
