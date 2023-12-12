using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnection = MySql.Data.MySqlClient.MySqlConnection;

namespace SistemaPdv.Conexao
{
    public class ConnectionFactory
    {
        //METODO DE CONECXAO AO BANCO DE DADOS

        public MySqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["dbpdv"].ConnectionString;
            return new MySqlConnection(conexao);
        }
    }
}
