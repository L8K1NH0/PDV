using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPdv.Model
{
    internal class ItemPedidoModel
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public decimal Quantidade { get; set; }
        public decimal SubTotal { get; set; }
    }
}
