using System;
using System.IO;

namespace PathLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\testedirectory\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);//caracter utilizado para separação : \
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);// o ; separa as pastas no windows
            Console.WriteLine("GetDirectoryName: " +Path.GetDirectoryName(path));//pega só o nome da pasta sem o arquivo
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));//pega o nome do arquivo
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));//arquivo sem a extensao
            Console.WriteLine("GetExtension: " +Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));// imprime o caminho todo
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());//pasta temporaria do sistema


        }
    }
}
/*
 * PATH:
 * classe que realiza operações com strings que contém arquivos ou pastas 
 */
