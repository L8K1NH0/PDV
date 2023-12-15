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
    internal class RelatorioDAO
    {
        private MySqlConnection conexao;

        public RelatorioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }


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

        public DataTable ListarProdutos(string dataAntiga, string dataRecente)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaProdutos = new DataTable();

                //COMANDO SQL
                string strSql = $"select  IdProduto, Pr.NomeProduto, SUM(quantidade) as quantidade, Pr.ValorUnitario , ROUND(SUM((quantidade * Pr.ValorUnitario)),2) as ValorTotal from itempedido \r\ninner join produto Pr ON Pr.Id = IdProduto\r\ninner join pedido Pe ON Pe.Id = IdPedido\r\nwhere Pe.DataVenda between '{dataRecente}' and  '{dataAntiga}'\r\ngroup by  IdProduto, Pr.NomeProduto ";

                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaProdutos);// Prencher o Dt

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaProdutos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public DataTable ListarValores(string dataAntiga, string dataRecente)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaValores = new DataTable();

                //COMANDO SQL
                string strSql = $"select SUM(Pix) as valorPix, SUM(Dinheiro) as valorDin, SUM(Debito) as valorDeb, SUM(credito) as valorCred, Pe.DataVenda from formapagamentopedido \r\ninner join pedido Pe ON Pe.Id = IdPedido\r\nwhere Pe.DataVenda between '{dataRecente}' and  '{dataAntiga}'\r\ngroup by Pe.DataVenda";

                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaValores);// Prencher o Dt

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaValores;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public DataTable ListarFluxo(string dataAntiga, string dataRecente)
        {
            try
            {
                //CRIAR DATATABLE
                DataTable tabelaFluxo = new DataTable();

                //COMANDO SQL
                string strSql = $"SELECT *\r\nFROM fluxo\r\nWHERE DATE(DataOpen) >= '{dataAntiga}' and DATE(DataOpen) <= '{dataRecente}'";

                //ORGANIZAR CMD
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();

                //Criar MySqlDataApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(exCmd);
                da.Fill(tabelaFluxo);// Prencher o Dt

                //FECHAR CONEXAO
                conexao.Close();

                return tabelaFluxo;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
                return null;
            }

        }

        public void  AbrirCaixa(FluxoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"INSERT INTO Fluxo (SaldoInicial,DataOpen) VALUES (@SaldoInicial, @DataOpen)";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("SaldoInicial", obj.SaldoInicial);
                exCmd.Parameters.AddWithValue("DataOpen", obj.DataOpen);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //FECHAR CONEXAO
                conexao.Close();
                //Informar resultado 
                MessageBox.Show($"Caixa Aberto.");

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }
        }

        public int UltimoIdFluxo()
        {
            try
            {
                int id;

                //COMANDO SQL
                string strSql = "SELECT Id FROM fluxo ORDER BY Id DESC LIMIT 1";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                if (exCmd.ExecuteScalar() == null)
                {
                    id = 1;
                }
                else
                {
                    id = int.Parse(exCmd.ExecuteScalar().ToString());
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

        public void FecharCaixa(FluxoModel obj)
        {
            try
            {
                //COMANDO SQL
                string strSql = @"update Fluxo SET SaldoFinal=@SaldoFinal, DataClose=@DataClose where Id=@Id";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                exCmd.Parameters.AddWithValue("SaldoFinal", obj.SaldoFinal);
                exCmd.Parameters.AddWithValue("DataClose", obj.DataClose);
                exCmd.Parameters.AddWithValue("Id", obj.Id);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();
                exCmd.ExecuteNonQuery();
                //FECHAR CONEXAO
                conexao.Close();
                //Informar resultado 
                MessageBox.Show($"Caixa Fechado.");

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar o comando Sql: " + e);
            }
        }

        public bool VerificarCaixaOpen()
        {
            bool OpenClose;
            try
            {
                //COMANDO SQL
                string strSql = $"SELECT DataClose FROM Fluxo WHERE DATE(DataOpen) =  '{DateTime.Now.ToString("yyyy-MM-dd")}'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                if (exCmd.ExecuteScalar() == null)
                {
                    OpenClose = false;
                }
                else
                {
                    OpenClose = true;
                }

                //FECHAR CONEXAO
                conexao.Close();

                return OpenClose;

            }catch (Exception e)
            {
                return true;
            }
        }

        public bool VerificarCaixaClose()
        {
            bool OpenClose;
            try
            {
                //COMANDO SQL
                string strSql = $"SELECT DataClose FROM Fluxo WHERE DATE(DataOpen) = '{DateTime.Now.ToString("yyyy-MM-dd")}'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                if (exCmd.ExecuteScalar() == null)
                {
                    OpenClose = true;//trocar
                }
                else
                {
                    OpenClose = false;
                }

                //FECHAR CONEXAO
                conexao.Close();

                return OpenClose;

            }
            catch (Exception e)
            {
                return true;
            }
        }

        public float ValorInicial()
        {
            float valor = 0.0f;

            try
            {
                //COMANDO SQL
                string strSql = $"SELECT SaldoInicial FROM Fluxo WHERE DATE(DataOpen) = '{DateTime.Now.ToString("yyyy-MM-dd")}'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                if (exCmd.ExecuteScalar() == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = float.Parse(exCmd.ExecuteScalar().ToString());
                }

                //FECHAR CONEXAO
                conexao.Close();

                return valor;

            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public float ValorFinal()
        {
            float valor = 0.0f;

            try
            {
                //COMANDO SQL
                string strSql = $"SELECT SaldoFinal FROM Fluxo WHERE DATE(DataClose) = '{DateTime.Now.ToString("yyyy-MM-dd")}'";

                //ORGANIZAR CMD 
                MySqlCommand exCmd = new MySqlCommand(strSql, conexao);

                //ABRIR CONEXAO / EXECUTAR
                conexao.Open();

                if (exCmd.ExecuteScalar() == null)
                {
                    valor = 0;
                }
                else
                {
                    valor = float.Parse(exCmd.ExecuteScalar().ToString());
                }

                //FECHAR CONEXAO
                conexao.Close();

                return valor;

            }
            catch (Exception e)
            {
                return 0;
            }
        }

    }
}