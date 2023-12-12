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
    internal class FornecedorDAO
    {
        private MySqlConnection conexao;

        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CADASTRO DE CLIENTE [POST]
        public void CadastrarFornecedor(FornecedorModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"INSERT INTO Fornecedor 
                    (Nome,Logradouro,Bairro,Cidade,Numero,Email,Contato,Cnpj) 
                    VALUES (@Nome,@Logradouro,@Bairro,@Cidade,@Numero,@Email,@Contato,@Cnpj)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("Nome", obj.Nome);
                exCmd.Parameters.AddWithValue("Logradouro", obj.Logradouro);
                exCmd.Parameters.AddWithValue("Bairro", obj.Bairro);
                exCmd.Parameters.AddWithValue("Cidade", obj.Cidade);
                exCmd.Parameters.AddWithValue("Numero", obj.Numero);
                exCmd.Parameters.AddWithValue("Email", obj.Email);
                exCmd.Parameters.AddWithValue("Contato", obj.Contato);
                exCmd.Parameters.AddWithValue("Cnpj", obj.CNPJ);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //FECHAR CONEXAO
                conexao.Close();
                //Informar resultado 
                MessageBox.Show($"Fornecedor {obj.Nome}, cadastrado(a) com Sucesso!");

            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Há dados informados que ja foram utilizados. ERRO:{e.Message}");
                conexao.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                conexao.Close();

            }
        }
        #endregion

        #region ALTERAR CLIENTE [PUT]
        public void AlterarFornecedor(FornecedorModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"UPDATE fornecedor SET 
                    Nome=@Nome,Logradouro=@Logradouro,Bairro=@Bairro,Cidade=@Cidade,
                    Numero=@Numero,Email=@Email,Contato=@Contato,Cnpj=@Cnpj
                    WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("@Nome", obj.Nome);
                exCmd.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
                exCmd.Parameters.AddWithValue("@Bairro", obj.Bairro);
                exCmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
                exCmd.Parameters.AddWithValue("@Numero", obj.Numero);
                exCmd.Parameters.AddWithValue("@Email", obj.Email);
                exCmd.Parameters.AddWithValue("@Contato", obj.Contato);
                exCmd.Parameters.AddWithValue("@Cnpj", obj.CNPJ);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Fornecedor {obj.Nome}, alterado com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }

        }
        #endregion 

        #region EXCLUIR CLIENTE [DELETE]
        public void ExcluirFornecedor(FornecedorModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"DELETE FROM Fornecedor WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Fornecedor excluido com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                conexao.Close();

            }

        }

        #endregion

        #region LISTAR CLIENTE [GET]
        public DataTable ListarFornecedor()
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaFornecedor = new DataTable();
                //COMANDO SQL
                string strSql = "SELECT * FROM Fornecedor";
                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaFornecedor);// Prencher o Dt
                //FECHAR CONEXAO
                conexao.Close();

                return tabelaFornecedor;
            }
            catch(InvalidOperationException e)
            {
                MessageBox.Show("Erro de consulta no banco");
                conexao.Close();
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                conexao.Close();
                return null;
            }

        }

        #endregion

        #region BUSCAR CLIENTE POR NOME [GET]
        public DataTable ListarFornecedorNome(string nome)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaFornecedor = new DataTable();
                //COMANDO SQL
                string strSql = $"SELECT * FROM fornecedor WHERE Nome LIKE '%{nome}%'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaFornecedor);

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaFornecedor;
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
