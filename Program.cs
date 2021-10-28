using System;
using System.IO;

namespace Atividade.Arquivos.File__FileInfo_e_IOException
{
    class Program
    {
        static void Main(string[] args)
        {
            //FILE

            string caminhoorigem = @"C:\File.FileInfo.txt";
            string caminhodestinho = @"C:\File.FileInfo1.txt";

            try
            {
                //Copia o arquivo origem para o destino
                File.Copy(caminhoorigem, caminhodestinho);

                //Faz a leitura do dados dentro do arquivo
                string[] linha = File.ReadAllLines(caminhoorigem);
                foreach (string x in linha)
                {
                    Console.WriteLine(x);
                }
            }
            //Exceção do system.IO
            catch (IOException e)
            {
                Console.WriteLine("um erro ocorreu");
                Console.WriteLine(e.Message);

            }

            //---------------------------------------------------------------------------------------------

            //FileInfo

            string caminhoOrigem1 = @"C:\File.FileInfo.txt";
            string caminhoDestinho1 = @"C:\File.FileInfo1.txt";

            try
            {
                // Instancia o metodo FileInfo
                FileInfo fileInfo = new FileInfo(caminhoOrigem1);

                //Copia o arquivo origem para o destino
                fileInfo.CopyTo(caminhoDestinho1);

                //Faz a leitura do dados dentro do arquivo
                string[] linha = File.ReadAllLines(caminhoOrigem1);

                foreach (string x in linha)
                {
                    Console.WriteLine(x);
                }
            }
            //Exceção do system.IO
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);

                


            }
        }
    }
}
