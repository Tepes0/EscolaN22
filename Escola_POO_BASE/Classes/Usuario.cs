using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Classes
{
    public class Usuario
    {
        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        #endregion

        #region Construtores
        public Usuario() { }

        public Usuario(int id, string nome, DateTime dtNascimento, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            DtNascimento = dtNascimento;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }
        #endregion

        #region Métodos 

        #region Antigo RealizarLogin sem BANCO
        //public static Usuario RealizarLogin(string email, string senha, List<Usuario> usuarios)
        //{

        //    Usuario usuario = usuarios.Find(a => a.Email == email);


        //    //Bloco - try...catch:
        //    try
        //    {
        //        if (usuario == null)
        //        {
        //            //erro lançado e-mail incorreto
        //            throw new Exception("O e-mail é inexistente.");
        //        }
        //        else
        //        {
        //            if (usuario.Senha == senha)
        //            {
        //                //email bateu. Testar se a senha também vai bater

        //                if (usuario.Ativo)
        //                {
        //                    //ok
        //                    return usuario;
        //                }
        //                else
        //                {
        //                    //block
        //                    throw new Exception("Usuário bloqueado.");
        //                }
        //            }
        //            else
        //            {
        //                //senha incorreta
        //                throw new Exception("A senha está incorreta.");
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion

        public static Usuario RealizarLogin(string email, string senha, bool tipoLogin)
        {
            if (tipoLogin)
            {
                string query = string.Format($"SELECT * FROM Aluno WHERE Email = '{email}'");
                Conexao cn = new Conexao(query);

                Aluno usuario = new Aluno();

                //Bloco - try...catch:
                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader(); //ExecuteReader(); é usado para dar selects 

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o e-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.DataMatricula = Convert.ToDateTime(cn.dr[3]);
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.Ativo = Convert.ToBoolean(cn.dr[6]);
                        }


                        if (usuario.Senha == Crypto.Sha256(senha))
                        {
                            //email bateu. Testar se a senha também vai bater

                            if (usuario.Ativo)
                            {
                                //ok
                                return usuario;
                            }
                            else
                            {
                                //block
                                throw new Exception("Usuário bloqueado.");
                            }
                        }
                        else
                        {
                            //senha incorreta
                            throw new Exception("A senha está incorreta.");
                        }
                    }
                    else
                    {
                        throw new Exception("Email inexistente!");
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }

            else
            {
                string query = string.Format($"SELECT * FROM Professor WHERE Email = '{email}'");
                Conexao cn = new Conexao(query);

                Professor usuario = new Professor();

                //Bloco - try...catch:
                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader(); //ExecuteReader(); é usado para dar selects 

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o e-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.CPF = cn.dr[3].ToString();
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.NivelAcesso = Convert.ToInt32(cn.dr[6]);
                            usuario.Ativo = Convert.ToBoolean(cn.dr[7]);
                        }


                        if (usuario.Senha == Crypto.Sha256(senha))
                        {
                            //email bateu. Testar se a senha também vai bater

                            if (usuario.Ativo)
                            {
                                //ok
                                return usuario;
                            }
                            else
                            {
                                //block
                                throw new Exception("Usuário bloqueado.");
                            }
                        }
                        else
                        {
                            //senha incorreta
                            throw new Exception("A senha está incorreta.");
                        }
                    }
                    else
                    {
                        throw new Exception("Email inexistente!");
                    }

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        //public static List<Usuario> GerarUsuarios()
        //{
        //    List<Usuario> usuarios = new List<Usuario>(); //objetos no singular e listas sempre no plural 

        //    Usuario aluno1 = new Aluno(1, "João Pereira", Convert.ToDateTime("12/02/1995"), Convert.ToDateTime("10/02/2006"), "joao@gmail", "123", true);
        //    Usuario aluno2 = new Aluno(2, "Ana Julia", Convert.ToDateTime("28/06/1993"), Convert.ToDateTime("01/02/2000"), "ana@gmail", "123", true);
        //    Usuario aluno3 = new Aluno(3, "Kayena Almeida", Convert.ToDateTime("20/08/1997"), Convert.ToDateTime("15/02/2008"), "kayena@gmail", "123", true);


        //    Usuario professor1 = new Professor(1, "Alexandre Padilla", Convert.ToDateTime("01/08/1970"), "170.606.458-70", "alexandre@yahoo", "123", 3, true);
        //    Usuario professor2 = new Professor(2, "António Duarte", Convert.ToDateTime("20/02/1988"), "364.069.784-45", "antonio@yahoo", "123", 1, true);
        //    Usuario professor3 = new Professor(3, "Marlon Marques", Convert.ToDateTime("26/05/1970"), "255.874.577-00", "marlon@yahoo", "123", 2, true);

        //    usuarios.Add(professor1);
        //    usuarios.Add(professor2);
        //    usuarios.Add(professor3);

        //    usuarios.Add(aluno1);
        //    usuarios.Add(aluno2);
        //    usuarios.Add(aluno3);
        //    return usuarios;

        //}
        public void AlterarSenha(string senhaAtual, string novaSenha, string confNovaSenha)
        {
            string tabela;
            if (this is Aluno)
            {
                tabela = "Aluno";
            }
            else
            {
                tabela = "Professor";
            }

            string query = string.Format($"UPDATE {tabela} SET Senha = '{Crypto.Sha256(novaSenha)}' WHERE Id = {Id}");
            Conexao cn = new Conexao(query);

            try
            {
                if (Senha == Crypto.Sha256(senhaAtual))
                {
                    if (novaSenha == confNovaSenha)
                    {
                        cn.AbrirConexao();
                        cn.comando.ExecuteNonQuery();
                        Senha = Crypto.Sha256(novaSenha);
                    }
                    else
                    {
                        throw new Exception("Nova senha não confere!");
                    }
                }
                else
                {
                    throw new Exception("Senha atual não confere!");
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
        public static List<Usuario> BuscarUsuarios()
        {
            string query = string.Format("SELECT * FROM Aluno");
            Conexao cn = new Conexao(query);
            
            List<Usuario> usuarios = new List<Usuario>();   //lista de usuarios vazia

            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read()) 
                {
                    usuarios.Add(new Aluno()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        DtNascimento = Convert.ToDateTime(cn.dr[2]),
                        DataMatricula = Convert.ToDateTime(cn.dr[3]),
                        Email = cn.dr[4].ToString(),
                        Senha = cn.dr[5].ToString(),
                        Ativo = Convert.ToBoolean(cn.dr[6])
                    }); 
                }
                return usuarios;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
 