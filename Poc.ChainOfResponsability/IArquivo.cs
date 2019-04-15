using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.ChainOfResponsability
{
  public interface IArquivo
    {
        void SetProximo(IArquivo documento);
        string MontarDocumento(Documento documento);
    }
}
