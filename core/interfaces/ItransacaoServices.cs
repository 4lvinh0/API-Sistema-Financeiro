using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.entities;


namespace Gerenciamento_Financeiro.core.interfaces
{
    public interface ItransacaoServices
    {
        public List<transacao> BuscarPorData(DateOnly DataBusca);

        public List<transacao> BuscarPorTipoDeOperacao(bool tipoOperacao);

        public transacao BuscarPorID(int Id);

        public void AdicionarTransacao(transacao transacao);

        public void ModificarTransacao(transacao transacao);

        public void ExcluirTransacaoPorID(int Id);
    }
}