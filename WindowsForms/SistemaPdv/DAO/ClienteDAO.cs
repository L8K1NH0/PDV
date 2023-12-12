using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using SistemaPdv.Model;
using SistemaPdv.Conexao;

namespace SistemaPdv.DAO
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CADASTRO DE CLIENTE [POST]
        public void CadastrarCliente(ClienteModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"INSERT INTO Cliente 
                    (Nome,Logradouro,Bairro,Cidade,NumeroCasa,Email,Contato,Cpf) 
                    VALUES (@Nome,@Logradouro,@Bairro,@Cidade,@NumeroCasa,@Email,@Contato,@Cpf)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("Nome", obj.Nome);
                exCmd.Parameters.AddWithValue("Logradouro", obj.Logradouro);
                exCmd.Parameters.AddWithValue("Bairro", obj.Bairro);
                exCmd.Parameters.AddWithValue("Cidade", obj.Cidade);
                exCmd.Parameters.AddWithValue("NumeroCasa", obj.NumeroCasa);
                exCmd.Parameters.AddWithValue("Email", obj.Email);
                exCmd.Parameters.AddWithValue("Contato", obj.Contato);
                exCmd.Parameters.AddWithValue("Cpf", obj.CPF);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //FECHAR CONEXAO
                conexao.Close();
                //Informar resultado 
                MessageBox.Show($"Cliente {obj.Nome}, cadastrado(a) com Sucesso!");

            }
            catch(MySqlException e)
            {
                MessageBox.Show($"O número de contato ja foi utilizado. ERRO:{e.Message}");
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
        public void AlterarCliente(ClienteModel obj)
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
                exCmd.Parameters.AddWithValue("@Logradouro", obj.Logradouro);
                exCmd.Parameters.AddWithValue("@Bairro", obj.Bairro);
                exCmd.Parameters.AddWithValue("@Cidade", obj.Cidade);
                exCmd.Parameters.AddWithValue("@NumeroCasa", obj.NumeroCasa);
                exCmd.Parameters.AddWithValue("@Email", obj.Email);
                exCmd.Parameters.AddWithValue("@Contato", obj.Contato);
                exCmd.Parameters.AddWithValue("@Cpf", obj.CPF);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);

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

        #region EXCLUIR CLIENTE [DELETE]
        public void ExcluirCliente(ClienteModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"DELETE FROM Cliente WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Cliente excluido com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }
            
        }

        #endregion

        #region LISTAR CLIENTE [GET]
        public DataTable ListarCliente()
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaCliente = new DataTable();
                //COMANDO SQL
                string strSql = "SELECT * FROM Cliente";
                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaCliente);// Prencher o Dt
                //FECHAR CONEXAO
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }
            
        }

        #endregion

        #region BUSCAR CLIENTE POR NOME [GET]
        public DataTable ListarClienteNome(string nome)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaCliente = new DataTable();
                //COMANDO SQL
                string strSql = $"SELECT * FROM cliente WHERE Nome LIKE '%{nome}%'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaCliente);

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaCliente;
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