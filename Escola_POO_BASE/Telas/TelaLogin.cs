using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaLogin : Form
    {
        const string senhaPadrao = "123";

        //Declarar objetos na classe o torna acessível por todos os métodos da classe
        private List<Usuario> _usuarios; //começar o objeto privado com _ é uma regra
        


        public TelaLogin()
        {
            InitializeComponent();
            _usuarios = Usuario.GerarUsuarios(); //funcionando através da classe e não do método/objeto
             
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario userLogado = Usuario.RealizarLogin(TxtEmailA.Text, TxtSenha.Text);

                if (userLogado.Senha == senhaPadrao)
                {
                    TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha(userLogado);
                    telaAlterarSenha.ShowDialog();
                    TxtSenha.Clear();
                    TxtSenha.Focus(); //Deixar selecionado o campo da senha
                }
                else 
                {
                    TelaPrincipal telaPrincipal = new TelaPrincipal(userLogado, _usuarios);
                    this.Hide();
                    telaPrincipal.ShowDialog(); //trava uma tela pra ficar em exibição até ser fechada
                    this.Show();
                    TxtSenha.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                              , "Colégio Objetivo"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Error);
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
          
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
        
        }
    }
}

