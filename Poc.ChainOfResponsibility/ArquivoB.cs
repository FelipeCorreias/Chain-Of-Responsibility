using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.ChainOfResponsability
{
    public class ArquivoB : IArquivo
    {
        private IArquivo proximo;

        public void SetProximo(IArquivo proximo)
        {
            this.proximo = proximo;
        }

        public string MontarDocumento(Documento documento)
        {

            if (documento.TipoDocumento == "docB")
            {
                documento.DocumentoTXT += " ArquivoB";
            }

            return proximo.MontarDocumento(documento);
        }
    }
}
