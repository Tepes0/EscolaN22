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
    public partial class TelaCadastraAluno : Form
    {
        private List<Usuario> _usuarios;
        private Professor _userLogado;
        public TelaCadastraAluno(List<Usuario> usuarios, Usuario userLogado)
        {
            InitializeComponent();
            _usuarios = usuarios;
            _userLogado = (Professor)userLogado;
        }

        //Método de formulário que irá configurar o DgvUsuarios
        private void ConfiguraDgvUsuarios()
        {
            //Criações das colunas no DgvUsuarios
            DgvUsuarios.Columns.Add("Id", "Matrícula");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("DtNascimento", "Data Nascimento");
            DgvUsuarios.Columns.Add("DtMatricula", "Data Matrícula");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");
            //---------
            //Configuração dos alinhamentos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DgvUsuarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DtMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //---------
            //Configuração dos tamanhos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["DtMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (_userLogado.NivelAcesso != 1)
            {
                MessageBox.Show("Você não possui permissão para cadastrar.",
                                "Erro de Permissão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; //Mata o método (encerra)
            }

            try
            {
                Aluno aluno = new Aluno(0,
                                        TxtNome.Text,
                                        DtpDtNascimento.Value,
                                        DtpDtMatricula.Value,
                                        TxtEmail.Text,
                                        "123",
                                        true);

                aluno.Cadastrar(_usuarios);
                MessageBox.Show($"Aluno(a) {aluno.Nome} cadastrado com sucesso!",
                                "Cadastro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaCadastraAluno_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraDgvUsuarios();

                List<Usuario> usuarios = Usuario.BuscarUsuarios();
                List<Aluno> alunos = usuarios.ConvertAll(u => (Aluno)u);

                DgvUsuarios.DataSource = alunos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
