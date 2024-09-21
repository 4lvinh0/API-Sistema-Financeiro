using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.entities;
using Gerenciamento_Financeiro.core.enums;


namespace Gerenciamento_Financeiro.core.interfaces
{
    public interface ItransacaoServices
    {
        public List<Transacao> BuscarPorDataService(DateOnly DataBusca);

        public List<Transacao> BuscarPorTipoDeOperacaoService(tipoOperacao tipoOperacao);

        public Transacao BuscarPorIDService(int Id);

        public void AdicionarTransacaoService(Transacao transacao);

        public void ModificarTransacaoService(Transacao transacao);

        public void ExcluirTransacaoPorIDService(int Id);
    }
}