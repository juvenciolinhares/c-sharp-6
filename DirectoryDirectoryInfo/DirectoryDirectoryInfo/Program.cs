using System;
using System.IO;
using System.Collections.Generic;//importo p ter acesso às coleções

namespace DirectoryDirectoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\testedirectory\myfolder";
            try
            {
                /****listar todas as subpastas a partir de uma subpasta(nesse caso, myfolder)****/

                //explicação das sobrecargas: path: caminho;  "*.*": mascara de busca(qlq arquivo.qlq extensao); SearchOption.AllDirectories: td os diretorios
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);//IEnumerable<string> folder  lista p armazenar as pastas
                Console.WriteLine("FOLDERS:");
                foreach(string item in folders)
                {
                    Console.WriteLine(item);
                }

                /****listar todos os arquivos****/
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);//IEnumerable<string> folder  lista p armazenar as pastas
                Console.WriteLine("Files:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                /****criar uma pasta****/

                Directory.CreateDirectory(path + @"\newfolder");//opção 1

                Directory.CreateDirectory(@"C:\testedirectory\myfolder\newfolder2");// opção 2

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
 * Fornece operações com pastas(criar pasta, listar, arquivos e pastas, etc.)
 * mesma linha de raciocinio do file e fileinfo:
 * Directory: operações estáticas
 * directory é mais simples, mas faz checagem antes de executar(ou seja, menos performance)
 * 
 * DirectoryInfo: operações de instancia
 * 
 * OUTRA OPÇÃO DE SINTAXE:
 *  var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
 *  o c# entende automaticamento que é um ienumerable
 *  nesse caso posso tirar o using System.Collections.Generic;
 */
