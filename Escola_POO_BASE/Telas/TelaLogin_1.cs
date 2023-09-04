﻿using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaLogin : Form
    {
        //Declarar objetos na classe o torna acessível
        //por todos os métodos da classe.
        private List<Usuario> _usuarios; //Declaração da lista de usuários

        public TelaLogin() //Assinatura do construtor da TelaLogin
        {
            InitializeComponent();
            //O método GerarUsuarios retorna uma lista POPULADA que é armazenada no obj _usuarios
            //_usuarios = Usuario.GerarUsuarios();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaração  - ATRIBUIÇÃO - Execução do método RealizarLogin()
                Usuario userLogado = Usuario.RealizarLogin(TxtEmail.Text, TxtSenha.Text, RdbAluno.Checked);

                if (userLogado.Senha == Crypto.Sha256("123"))
                {
                    TelaAlterarSenha tlAlterarSenha = new TelaAlterarSenha(userLogado);
                    tlAlterarSenha.ShowDialog();
                    TxtSenha.Clear(); //Limpar
                    TxtSenha.Focus(); //Deixar já selecionado.
                }
                else
                {
                    //Declaração da TELA!    --  Instanciação executando um Construtor
                    TelaPrincipal tlPrincipal = new TelaPrincipal(userLogado, _usuarios);
                    this.Hide();
                    tlPrincipal.ShowDialog();
                    this.Show();
                    TxtSenha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                              , "Escola X"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Error);
            }
        }




    }
}
