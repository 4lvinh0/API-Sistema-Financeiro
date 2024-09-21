using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.interfaces;
using Gerenciamento_Financeiro.core.entities;
using Gerenciamento_Financeiro.infrastructure.data;
using Gerenciamento_Financeiro.core.enums;


namespace Gerenciamento_Financeiro.infrastructure.repositories
{
    public class transacaoRepository : ItransacaoRepository
    {
        private readonly AppDbContext _context;
        public transacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<transacao> BuscarPorData(DateOnly DataBusca)
        {
            try
            {
                var result = _context.transacao
                    .Where(t => t.dataOperacao == DataBusca)
                    .ToList();

                if (result == null)
                {
                    throw new Exception("Transação não encontrada");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar a transação: {ex.Message}");
            }
        }

        public List<transacao> BuscarPorTipoDeOperacao(tipoOperacao tipoOperacao)
        {
            try
            {
                var result = _context.transacao
                    .Where(t => t.tipoOperacao == tipoOperacao)
                    .ToList();

                if (result == null || !result.Any()) // Verificar se a lista está vazia ou nula
                {
                    throw new Exception("Transação não encontrada");
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar a transação: {ex.Message}");
            }
        }

        public transacao BuscarPorID(int Id)
        {

            try
            {
                var result = _context.transacao.Find(Id);

                if (result == null)
                {
                    throw new Exception("Transação não encontrada");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar a transação: {ex.Message}");
            }
        }

        public void AdicionarTransacao(transacao transacao)
        {
            try
            {
                _context.transacao.Add(transacao);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar a transação: {ex.Message}");

            }
        }

        public void ModificarTransacao(transacao transacao)
        {
            try
            {
                _context.transacao.Update(transacao);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar a transação: {ex.Message}");

            }
        }

        public void ExcluirTransacaoPorID(int Id)
        {
            try
            {
                var result = _context.transacao.Find(Id);

                if (result != null)
                {

                    _context.transacao.Remove(result);
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao buscar a transação: {ex.Message}");

            }
        }

        public List<transacao> BuscarPorTipoDeOperacao(bool tipoOperacao)
        {
            throw new NotImplementedException();
        }
    }
}