using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento_Financeiro.core.entities
{
    public class transacao
    {
        public int transacaoId { get; set; }

        public decimal valor  { get; set; }

        public bool tipoOperacao  { get; set; } //True para entrada, False para saída

        public DateOnly dataOperacao  { get; set; }

        public decimal valorPosOperacao  { get; set; }
    }
}