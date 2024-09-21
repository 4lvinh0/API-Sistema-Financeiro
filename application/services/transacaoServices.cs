using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.entities;
using Gerenciamento_Financeiro.core.enums;
using Gerenciamento_Financeiro.core.interfaces;
using Gerenciamento_Financeiro.infrastructure.repositories;

namespace Gerenciamento_Financeiro.application.services
{
    public class transacaoServices : ItransacaoServices
    {
        private readonly transacaoRepository _transacaoRepository;
        public transacaoServices(transacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        public void AdicionarTransacaoService(Transacao transacao)
        {
            _transacaoRepository.AdicionarTransacao(transacao);
        }

        public List<Transacao> BuscarPorDataService(DateOnly DataBusca)
        {
            return _transacaoRepository.BuscarPorData(DataBusca);
        }

        public Transacao BuscarPorIDService(int Id)
        {
            return _transacaoRepository.BuscarPorID(Id);
        }

        public List<Transacao> BuscarPorTipoDeOperacaoService(tipoOperacao tipoOperacao)
        {
            return _transacaoRepository.BuscarPorTipoDeOperacao(tipoOperacao);
        }

        public void ExcluirTransacaoPorIDService(int Id)
        {
            _transacaoRepository.ExcluirTransacaoPorID(Id);
        }

        public void ModificarTransacaoService(Transacao transacao)
        {
            _transacaoRepository.ModificarTransacao(transacao);
        }
    }
}