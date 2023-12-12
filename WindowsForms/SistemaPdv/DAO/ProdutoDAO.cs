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
    internal class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CADASTRO DE PRODUTO [POST]
        public void CadastrarProduto(ProdutoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"INSERT INTO produto (NomeProduto,ValorUnitario,IdCategoria) VALUES (@Nome,@ValorUnitario,@IdCategoria)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("Nome", obj.Nome);
                exCmd.Parameters.AddWithValue("ValorUnitario", obj.ValorUnitario);
                exCmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //FECHAR CONEXAO
                conexao.Close();
                //Informar resultado 
                MessageBox.Show($"Produto {obj.Nome}, cadastrado com Sucesso!");

            }
            catch(MySqlException e)
            {
                MessageBox.Show($"Esse Produto ja é cadastrado. ERRO: {e}");
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao executar o comando Sql: {e}");
                conexao.Close();
            }
        }
        #endregion

        #region ALTERAR PRODUTO [PUT]
        public void AlterarProduto(ProdutoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"UPDATE produto SET IdCategoria=@IdCategoria,NomeProduto=@NomeProduto,ValorUnitario=@ValorUnitario
                    WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("NomeProduto", obj.Nome);
                exCmd.Parameters.AddWithValue("ValorUnitario", obj.ValorUnitario);
                exCmd.Parameters.AddWithValue("IdCategoria", obj.IdCategoria);
                exCmd.Parameters.AddWithValue("Id", obj.Id);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Produto {obj.Nome}, alterado com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }

        }
        #endregion 

        #region EXCLUIR PRODUTO [DELETE]
        public void ExcluirProduto(ProdutoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"DELETE FROM produto WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Produto excluido com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }

        }

        #endregion

        #region LISTAR PRODUTO [GET]
        public DataTable ListarProduto()
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaProduto = new DataTable();
                //COMANDO SQL
                string strSql = "SELECT * FROM produto";
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

        #endregion

        #region LISTAR CATEGORIA [GET]
        public DataTable ListarCategoria()
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaCategoria = new DataTable();
                //COMANDO SQL
                string strSql = "SELECT * FROM categoria";
                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaCategoria);// Prencher o Dt
                //FECHAR CONEXAO
                conexao.Close();

                return tabelaCategoria;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        #endregion

        #region BUSCAR CATEGORIA POR NOME [GET]
        public DataTable ListarCategoriaoNome(string nome)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaCategoria = new DataTable();
                //COMANDO SQL
                string strSql = $"SELECT * FROM categoria WHERE nome LIKE '%{nome}%'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaCategoria);

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaCategoria;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        #endregion

        #region BUSCAR PRODUTO POR NOME [GET]
        public DataTable ListarProdutoNome(string nome)
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
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        #endregion
    }
}
