using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPdv.Model
{
    internal class ItemCompraModel
    {
        public int Id { get; set; }
        public int idProduto { get; set; }
        public int IdFornecedor { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public DateTime DataCompra { get; set; }
    }
}
