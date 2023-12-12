using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPdv.Model
{
    internal class FormaPagamentoModel
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public decimal Pix { get; set; }
        public decimal Dinheiro { get; set; }
        public decimal Debito { get; set; }
        public decimal Credito { get; set; }

    }
}
