using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using SistemaPdv.Conexao;
using SistemaPdv.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPdv.DAO
{
    internal class CaixaDAO : ProdutoDAO
    {
        private MySqlConnection conexao;

        public CaixaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region EXEMPLO
        public void EXEMPLO(ClienteModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"UPDATE cliente SET 
                    Nome=@Nome,Logradouro=@Logradouro,Bairro=@Bairro,Cidade=@Cidade,
                    NumeroCasa=@NumeroCasa,Email=@Email,Contato=@Contato,Cpf=@Cpf 
                    WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("@Nome", obj.Nome);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Cliente {obj.Nome}, alterado com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }

        }
        #endregion

        public DataTable ListarProduto()
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaProduto = new DataTable();
                //COMANDO SQL
                string strSql = "SELECT NomeProduto, ValorUnitario, Id FROM produto";
                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaProduto);// Prencher o Dt
                //FECHAR CONEXAO
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public DataTable PesquisaProduto(string nome)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaProduto = new DataTable();

                //COMANDO SQL
                string strSql = $"SELECT * FROM produto WHERE NomeProduto LIKE '%{nome}%'"; 

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaProduto);

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception erro)
            {

                throw;
            }            
        }

        public void AdicionarProduto(ItemPedidoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"INSERT INTO itempedido (IdProduto,IdPedido,Quantidade,SubTotal) VALUES (@IdProduto,@IdPedido,@Quantidade,@SubTotal)";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("@IdPedido", obj.IdPedido);
                exCmd.Parameters.AddWithValue("@IdProduto", obj.IdProduto);
                exCmd.Parameters.AddWithValue("@Quantidade", obj.Quantidade);
                exCmd.Parameters.AddWithValue("@SubTotal", obj.SubTotal);


                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Produto Add.");

                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception erro )
            {
                MessageBox.Show($"{erro}");
                throw;
            }
        }

        public void RemoverProduto(ItemPedidoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"DELETE FROM itempedido WHERE IdProduto=@IdProduto AND IdPedido=@IdPedido";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql,conexao);

                exCmd.Parameters.AddWithValue("@IdProduto", obj.IdProduto);
                exCmd.Parameters.AddWithValue("@IdPedido", obj.IdPedido);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show("Produto retirado");

                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"{erro}");
                throw;
            }
        }

        public void RemoverTodosProdutos(ItemPedidoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"DELETE FROM itempedido WHERE IdPedido=@IdPedido";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("@IdPedido", obj.IdPedido);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show("Produtos retirados");

                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"{erro}");
                throw;
            }
        }

        public int UltimoIdPedido()
        {
            try
            {
                int id;

                //COMANDO SQL
                string strSql = "SELECT Id FROM pedido ORDER BY Id DESC LIMIT 1";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                if(exCmd.ExecuteScalar() == null)
                {
                    id = 1;
                }
                else
                {
                   id  = int.Parse(exCmd.ExecuteScalar().ToString())+1;                    
                }

                //FECHAR CONEXAO
                conexao.Close();
                return id;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return 0;
            }
        }

        public void FinalizarVenda(PedidoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = "INSERT INTO pedido (NomeCliente,EntregaRetirada,Endereco,Contato,TotalVenda,DataVenda) " +
                    "VALUES (@NomeCliente,@EntregaRetirada,@Endereco,@Contato,@TotalVenda,@DataVenda)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("@NomeCliente", obj.NomeCliente);
                exCmd.Parameters.AddWithValue("@EntregaRetirada", obj.EntregaRetirada);
                exCmd.Parameters.AddWithValue("@Endereco", obj.Endereco);
                 exCmd.Parameters.AddWithValue("@Contato", obj.Contato);
                exCmd.Parameters.AddWithValue("@TotalVenda", obj.TotalVenda);
                exCmd.Parameters.AddWithValue("@DataVenda", obj.DataVenda);

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
