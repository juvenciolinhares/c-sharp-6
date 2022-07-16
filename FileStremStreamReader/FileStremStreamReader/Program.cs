using System;
using System.IO;//importar o system io

namespace FileStremStreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar uma string path contendo o caminho do arquivo
            string path = @"C:\testeFileFileinfoIOexception\file1.txt";

            /*declarar um objeto filestream:
            FileStream fs = null;//stream de código binário
            StreamReader sr = null;// interpretador

            //instanciar os objetos:
            
            try
            {
                //1- file stream associado ao arquivo
                fs = new FileStream(path, FileMode.Open);//instanciei associado a um arquivo com a finalidade de abrir o arquivo para acesso

                //2 - streamreader associado ao filestream
                sr = new StreamReader(fs);//streamreader recebendo o filestream como argumento

                //fazer leitura do arquivo:
                string line = sr.ReadLine();//ler uma linha do arquivo e armazenar na variavel line
                Console.WriteLine(line);
            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally// preciso fechar as stream tendo dado certo ou não
            {
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
            */

            /***maneira mais resumida de instanciar o streamreader:***/

            StreamReader sr = null;
            try
            {
                //utilizando classe File como aux
                sr = File.OpenText(path);//o OpenText implicitamente instancia o FileStream e instancia o Streamreader em cima dele


                //pra ler todas as linhas do arquivo
                while (!sr.EndOfStream)//enquanto não cjhegar no final da stream
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }
    }
}
/*
 * ESSES OBJETOS INSTANCIADOS SÃO RECURSOS EXTERNOS, conversas com o sistema operacional
 * não é gerenciado pelo clr do .net
 * como não é gerenciado pelo clr eu tenho que fechar esse recurso manuamente
 */
