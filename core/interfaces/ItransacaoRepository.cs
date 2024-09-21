using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.entities;

namespace Gerenciamento_Financeiro.core.interfaces
{
    public interface ItransacaoRepository
    {
        public List<Transacao> BuscarPorData(DateOnly DataBusca);

        public List<Transacao> BuscarPorTipoDeOperacao(bool tipoOperacao);

        public Transacao BuscarPorID(int Id);

        public void AdicionarTransacao(Transacao transacao);

        public void ModificarTransacao(Transacao transacao);

        public void ExcluirTransacaoPorID(int Id);
    }
}
