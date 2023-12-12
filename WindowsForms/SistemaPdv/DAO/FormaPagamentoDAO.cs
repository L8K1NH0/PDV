using MySql.Data.MySqlClient;
using SistemaPdv.Conexao;
using SistemaPdv.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPdv.DAO
{
    internal class FormaPagamentoDAO
    {
        private MySqlConnection conexao;

        public FormaPagamentoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public void FormaPagamento(FormaPagamentoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = "INSERT INTO formapagamentopedido (IdPedido,Pix,Dinheiro,Debito,credito) " +
                    "VALUES (@IdPedido,@Pix,@Dinheiro,@Debito,@credito)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql,conexao);

                exCmd.Parameters.AddWithValue("@IdPedido", obj.IdPedido);
                exCmd.Parameters.AddWithValue("@Pix", obj.Pix);
                exCmd.Parameters.AddWithValue("@Dinheiro", obj.Dinheiro);
                exCmd.Parameters.AddWithValue("@Debito", obj.Debito);
                exCmd.Parameters.AddWithValue("@credito", obj.Credito);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception)
            {
                conexao.Close();
                throw;
            }        
        }
    }
}
