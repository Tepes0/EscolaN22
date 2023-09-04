using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola_POO_BASE.Classes
{
    internal class Conexao
    {
        #region Variáveis

        //string de conexão                                Informações CHUMBADAS - HARDCODE
        private static string _strConexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EscolaN22;Integrated Security=True";


        //Variáveis de uso (podem ou não serem usadas ao decorrer do projeto)
        public SqlConnection conexao = new SqlConnection(_strConexao);
        public SqlCommand comando; //armazenar a query(insert, select, date) - recebe o comando a ser executado 
        public SqlDataAdapter da; //adaptador para alguns componentes 
        public SqlDataReader dr; //recebe os selects 
        public DataSet ds;  //trabalha com tabelas múltiplas 
        #endregion

        #region Construtores
        public Conexao(string query)
        {
            comando = new SqlCommand(query, conexao); //comando montado 
            da = new SqlDataAdapter(query, conexao); //comando necessário (já vem pronto)
            ds = new DataSet();
        }

        #endregion

        #region Métodos
        //um método para abrir a conexão com o banco
        public void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Open)
            { 
                conexao.Close();
            }
            conexao.Open(); 
        }
        //E um outro método para fechar a conexão 
        public void FecharConexao() 
        {
            if (conexao.State == ConnectionState.Open) 
            {
                conexao.Close();
            }
        }
        #endregion
    }
}
