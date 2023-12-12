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
    internal class CategoriaDAO
    {
        private MySqlConnection conexao;

        public CategoriaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region CADASTRO DE CATEGORIA [POST]
        public void CadastrarCategoria(CategoriaModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"INSERT INTO categoria (Nome,Descricao) VALUES (@Nome,@Descricao)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("Nome", obj.Nome);
                exCmd.Parameters.AddWithValue("Descricao", obj.Descricao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //FECHAR CONEXAO
                conexao.Close();
                //Informar resultado 
                MessageBox.Show($"Categoria {obj.Nome}, cadastrada com Sucesso!");

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                conexao.Close();
            }
        }
        #endregion

        #region ALTERAR CATEGORIA [PUT]
        public void AlterarCategoria(CategoriaModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"UPDATE categoria SET Nome=@Nome, Descricao=@Descricao WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("@Nome", obj.Nome);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);
                exCmd.Parameters.AddWithValue("@Descricao", obj.Descricao);



                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Categoria {obj.Nome}, alterada com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }

        }
        #endregion 

        #region EXCLUIR CATEGORIA [DELETE]
        public void ExcluirCategoria(CategoriaModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"DELETE FROM categoria WHERE Id=@Id";
                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);
                exCmd.Parameters.AddWithValue("@Id", obj.Id);
                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                MessageBox.Show($"Categoria excluido com Sucesso!");
                //FECHAR CONEXAO
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
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

        #region LISTAR CATEGORIA POR NOME [GET]
        public DataTable ListarCategoriaNome(string nome)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaCategoria = new DataTable();

                //COMANDO SQL
                string strSql = $"SELECT * FROM categoria WHERE Nome LIKE '%{nome}%'";

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


        #region LISTAR CATEGORIA POR ID [GET]
        public string ListarCategoriaID(string Id)
        {
            string categoria;
            try
            {
                //COMANDO SQL
                string strSql = $"SELECT Nome FROM categoria WHERE Id = {Id}";

                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                categoria = exCmd.ExecuteScalar().ToString();


                //FECHAR CONEXAO
                conexao.Close();

                return categoria;
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
