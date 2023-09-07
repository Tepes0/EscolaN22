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

namespace Escola_POO_BASE.Telas
{
    /* TODO III. Desenhar uma tela para alterar senha.
     * Esta tela deverá contar um campo para colocar a senha atual
     * a nova senha e confirmar a nova senha 
     * Também deverá contar um botão para confirmar e outro para fechar
     */
    public partial class TelaPrincipal : Form
    {
        private Aluno _alunoSelecionado;
        private Usuario _userLogado;
        private List<Usuario> _aluno;
        public TelaPrincipal(Usuario usuarioLogado, List<Usuario> aluno)
        {
            InitializeComponent();
            _userLogado = usuarioLogado;
            _aluno = aluno;
        }
         
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            /*TODO I.Identificar quem está logado, se é aluno ou professor. 
            *if for o aluno, mostrar o nome do aluno no ToolStrip, assim como o seu E-mail. 
            *O mesmo deve acontecer caso seja o professor. 
            *TODO II.Descobrir como mostrar a data e a hora completa no ToolStrip.
            */
            if (_userLogado is Aluno)
            {
                cadastroDeAlunosToolStripMenuItem.Visible = false;
                toolStripStatusLabel3.Text = "Aluno";
            }
            else 
            { 
                cadastroDeAlunosToolStripMenuItem.Visible= true;
                toolStripStatusLabel3.Text = "Professor";
            }

            TslDataHora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            TmrRelogio.Interval = 1000;
            TmrRelogio.Enabled = true;
            var qtdAlunos = _aluno.Count;
            LblQtdAlunos.Text = $"{qtdAlunos}";
            //LblAlunosAtivos.Text = 
            //LblAlunosRemovidos.Text = 

            TslNomeUserLogado.Text = _userLogado.Nome;
            TslEmailUserLogado.Text = _userLogado.Email;
        }

        private void TsiAlterarSenha_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha(_userLogado);
            telaAlterarSenha.ShowDialog();  
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            TelaCadastraAluno tlCadastraAluno = new TelaCadastraAluno(_alunos, _userLogado, _alunoSelecionado);
            tlCadastraAluno.MdiParent = this;
            tlCadastraAluno.Show(); 
        }
        private void TmrRelogio_Tick(object sender, EventArgs e)
        {
            TslDataHora.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }
    }
}
