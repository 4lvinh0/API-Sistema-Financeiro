using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.enums;

namespace Gerenciamento_Financeiro.core.entities
{
    public class Transacao
    {
        public int transacaoId { get; set; }

        public decimal valor  { get; set; }

        public tipoOperacao tipoOperacao  { get; set; }

        public DateOnly dataOperacao  { get; set; }

        public decimal valorPosOperacao  { get; set; }
    }
}