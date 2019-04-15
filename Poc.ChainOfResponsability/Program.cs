using System;

namespace Poc.ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            IArquivo arquivoA = new ArquivoA();
            IArquivo arquivoB = new ArquivoB();
            IArquivo arquivoC = new ArquivoC();

            arquivoA.SetProximo(arquivoB);
            arquivoB.SetProximo(arquivoC);

            Documento doc = new Documento
            {
                TipoDocumento = "docA"
            }; 

            arquivoA.MontarDocumento(doc);

            Console.Write(doc.DocumentoTXT);
            Console.ReadKey();
        }
    }
}
