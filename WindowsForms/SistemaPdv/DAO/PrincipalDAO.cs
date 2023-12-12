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
    internal class PrincipalDAO
    {
        private MySqlConnection conexao;

        public PrincipalDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        public DataTable ListarPedidos()
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaPedido = new DataTable();

                //COMANDO SQL
                string strSql = $"select Id, NomeCliente, TotalVenda, Contato, Endereco from pedido Where DataVenda = '{DateTime.Now.ToString("yyyy-MM-dd")}'";
                
                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                
                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaPedido);// Prencher o Dt
                
                //FECHAR CONEXAO
                conexao.Close();

                return tabelaPedido;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public DataTable PedidoEspecifico(int Id)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaPedido = new DataTable();

                //COMANDO SQL
                string strSql = $"select  IdProduto, Pr.NomeProduto, SUM(quantidade) as quant, Pr.ValorUnitario , SUM((quantidade * Pr.ValorUnitario)) as ValorTotal from itempedido \r\ninner join produto Pr ON Pr.Id = IdProduto\r\ninner join pedido Pe ON Pe.Id = IdPedido\r\nwhere IdPedido = {Id}\r\ngroup by  IdProduto, Pr.NomeProduto";

                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaPedido);// Prencher o Dt

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaPedido;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public DataTable PedidoPagamento(int Id)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable PedidoPagamento = new DataTable();

                //COMANDO SQL
                string strSql = $"select SUM(Pix) as valorPix, SUM(Dinheiro) as valorDin, SUM(Debito) as valorDeb, SUM(credito) as valorCred from formapagamentopedido \r\nwhere IdPedido = {Id}";

                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(PedidoPagamento);// Prencher o Dt

                //FECHAR CONEXAO
                conexao.Close();

                return PedidoPagamento;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public void ExcluirCliente(int Id)
        {
            try
            {
                //COMANDO SQL
                string strSql = $"delete ip, fgp, pe from itempedido ip\r\ninner join pedido pe ON pe.Id = ip.IdPedido\r\ninner join formapagamentopedido fgp ON fgp.IdPedido = ip.IdPedido\r\nwhere ip.IdPedido = {Id}";
                
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Pedido excluido com Sucesso!");
                
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }

        }
    }
}
