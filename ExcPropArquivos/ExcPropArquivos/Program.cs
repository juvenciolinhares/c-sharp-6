using System;
using System.IO;
using ExcPropArquivos.Entities;
using System.Globalization;


namespace ExcPropArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                //ler conteúdo do arquivo:
                string[] lines = File.ReadAllLines(sourceFilePath);

                //criar pasta de destino a partir(dentro) da past de origem:
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summay.csv";

                Directory.CreateDirectory(targetFolderPath);

                //escrever informações no arquivo de saída(summary):

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        //instanciar o produto:

                        Product prod = new Product(name, price, quantity);

                        //escrever as informações:
                        sw.WriteLine(prod.Name + "," + prod.valorTotal().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch(IOException e){
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
/*
 *ler o caminho de um arquivo .csv contendo dados de itens vendidos
 *itens tem: nome, preço unitario, quantidade, separados por virgula
 *gerar novo arquivo chamado "summary.csv" 
 *localizado numa supasta chamada out a partir da pasta original do arq. de origem
 *contendo apenas nome e valor total para aquele item(preço * qtd) 
 *
 *
 */