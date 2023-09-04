using System;
using System.Collections.Generic;
using System.Linq;  
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Escola_POO_BASE.Classes
{
    public class Aluno : Usuario
    {
        #region Propriedades
        public DateTime DataMatricula { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {

        }

        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dataMatricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            DataMatricula = dataMatricula;
        }
        #endregion

        #region Método
        public void Cadastrar(List<Aluno>aluno)    
        {
            string query = string.Format($"INSERT INTO Aluno VALUES ('{Nome}','{DtNascimento}','{DataMatricula}','{Email}','a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1); select scope_identity()");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                this.Id = Convert.ToInt32(cn.comando.ExecuteScalar());
                aluno.Add(this);
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            { 
                cn.FecharConexao();
            }
        }
        public void Alterar() 
        {
            string query = string.Format($"UPDATE Aluno SET Nome = '{Nome}', DtNascimento = '{DtNascimento}', DtMatricula = '{DataMatricula}', Email = '{Email}' WHERE Id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void Excluir()
        {
            string query = string.Format($"UPDATE Aluno SET Ativo = 0 WHERE Id = {Id}");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.FecharConexao();
            }

        }
        public static List<Aluno> Buscar(List<Aluno> alunos, int indexCbbBuscar, string texto) 
        {
            switch (indexCbbBuscar) 
            {
                case 0:
                    //Busca por nome

                    return alunos.Where(a => a.Nome.ToUpper().Contains(texto.ToUpper())).ToList();     
                    //break; //quando não for return é obrigatório o uso do break 

                case 1:
                    //Busca Email
                    return alunos.Where(a => a.Email.ToUpper().Contains(texto.ToUpper())).ToList();
                    //break; 
                case 2:
                    //Busca Matricula
                    return alunos.Where(a => a.Id == Convert.ToInt32(texto)).ToList();
                    //break;
                default:
                    //Retornar a lista sem filtros
                    return alunos;
                    //break;
            }
        }
        #endregion

    }
}
