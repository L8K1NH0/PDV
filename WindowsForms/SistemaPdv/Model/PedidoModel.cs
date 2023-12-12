using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPdv.Model
{
    internal class PedidoModel
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string EntregaRetirada { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public decimal TotalVenda { get; set; }
        public string DataVenda { get; set; }
    }
}
