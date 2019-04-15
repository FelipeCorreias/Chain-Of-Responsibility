using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.ChainOfResponsability
{
    public class ArquivoC : IArquivo
    {
        private IArquivo proximo;

        public void SetProximo(IArquivo proximo)
        {
            this.proximo = proximo;
        }

        public string MontarDocumento(Documento documento)
        {

            if (documento.TipoDocumento == "docA")
            {
                documento.DocumentoTXT += " ArquivoC";
            }

            return "";
        }
    }
}
