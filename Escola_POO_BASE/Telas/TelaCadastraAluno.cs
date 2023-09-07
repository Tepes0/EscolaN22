using System;
using Escola_POO_BASE.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Telas
{
    public partial class TelaCadastraAluno : Form
    {
       // private List<Usuario> _usuarios;
        private List<Aluno> _alunos;
        private Aluno _alunoSelecionado; /*declarando objeto do tipo aluno*/
        private Professor _userLogado;

        public TelaCadastraAluno(List<Aluno> alunos, Usuario usuarioLogado, Aluno alunoSelecionado)

        {
            InitializeComponent();
            _alunoSelecionado = alunoSelecionado;   
            _alunos = alunos;
            _userLogado = (Professor)usuarioLogado; //downcast - referenciar explicitamente qual classe está sendo usada

            try
            {
                _alunos = Usuario.BuscarUsuarios().ConvertAll(u => (Aluno)u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        //método de formulário que irá configurar o DgvUsuarios
        private void ConfiguraDgvUsuarios() 
        {
            //Criação das colunas no DgvUsuarios
            DgvUsuarios.Columns.Add("Id", "Matrícula");
            DgvUsuarios.Columns.Add("Nome", "Nome");
            DgvUsuarios.Columns.Add("DtNascimento", "Data Nascimento");
            DgvUsuarios.Columns.Add("DataMatricula", "Data Matrícula");
            DgvUsuarios.Columns.Add("Email", "E-mail");
            DgvUsuarios.Columns.Add("Ativo", "Ativo");

            //Configuração dos alinhamentos de cada coluna no DgvUsuarios
            DgvUsuarios.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DtNascimento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["DataMatricula"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvUsuarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Configuração dos tamanhos de cada coluna do DgvUsuarios
            DgvUsuarios.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["DtNascimento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvUsuarios.Columns["DataMatricula"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvUsuarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvUsuarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            
            //Configurar tamanho em altura de colunas e linhas
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.ColumnHeadersHeight = 35;
            DgvUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //Configurar cor para intercalar linhas 
            DgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }

        //método que limpa os campos da tela 
        private void LimpaCampos()
        {
            TxtId.Text = "";
            TxtCadastraNome.Clear();
            TxtCadastraEmail.Clear();
            DtCadastraNasc.Value = new DateTime(1990, 1, 1);
            DtCadastraMatric.Value = DateTime.Now;
            TxtStatus.Checked = true;
            DgvUsuarios.ClearSelection();
            BtnConfirmar.Enabled = true;
            BtnAlterar.Enabled = false;
            CbbBuscar.SelectedIndex = 0;  
            TxtBuscar.Focus();

        }

        //método para carregar o DgvUsuarios com os dados da Lista
        private void CarregaDgvUsuarios(List<Aluno> alunos = null) //deixando parametro opcional 
        { 
            DgvUsuarios.Rows.Clear();

            foreach (Aluno aluno in alunos == null ? _alunos : alunos)
            {
                DgvUsuarios.Rows.Add(aluno.Id, aluno.Nome, aluno.DtNascimento.ToString("dd/MM/yyyy"), aluno.DataMatricula, aluno.Email, aluno.Ativo);
                if (!aluno.Ativo)
                    DgvUsuarios.Rows[DgvUsuarios.Rows.Count-1].DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (_userLogado.NivelAcesso == 1)
            {
                try
                {
                    Aluno aluno = new Aluno(0,
                                                      TxtCadastraNome.Text,
                                                      DtCadastraNasc.Value,
                                                      DtCadastraMatric.Value,
                                                      TxtCadastraEmail.Text,
                                                      "123",
                                                      true);
                    aluno.Cadastrar(_alunos);
                    CarregaDgvUsuarios();
                    //MessageBox.Show($"Aluno(a) {aluno.Nome} foi cadastrado com sucesso!",
                    //                 "Cadastro",
                    //                 MessageBoxButtons.OK,
                    //                 MessageBoxIcon.Information);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, 
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else 
            { 
                    MessageBox.Show("Erro! Você não possui autoridade o suficiente.",
                                    "Erro de Permissão",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                Close();
                //return; - isto mata o método                
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //método que altera dados de alunos
        private void BtnAlterar_Click(object sender, EventArgs e) 
        {
                try
                {
                    _alunoSelecionado.Nome = TxtCadastraNome.Text;
                    _alunoSelecionado.DtNascimento = DtCadastraNasc.Value;
                    _alunoSelecionado.DataMatricula = DtCadastraMatric.Value;
                    _alunoSelecionado.Email = TxtCadastraEmail.Text;

                    _alunoSelecionado.Alterar();       
                    CarregaDgvUsuarios();
                    MessageBox.Show($"Aluno(a) {_alunoSelecionado.Nome} foi alterado com sucesso!",
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

        private void TelaCadastroAluno_Load(object sender, EventArgs e)
        {
            try
            { 
                ConfiguraDgvUsuarios();
                CarregaDgvUsuarios();
                LimpaCampos();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                 "Erro",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }    
        }

        private void DgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {

            if (DgvUsuarios.Rows.Count < 1 || DgvUsuarios.SelectedRows.Count < 1)
                return; 

            try
            {                         // procurar na lista de aluno valor na primeira celula em que esteja igual a linha selecionada
                _alunoSelecionado  = _alunos.Find(a => a.Id == (int)DgvUsuarios.SelectedRows[0].Cells[0].Value); 
                TxtId.Text = _alunoSelecionado.Id.ToString();
                TxtCadastraNome.Text = _alunoSelecionado.Nome;
                TxtCadastraEmail.Text = _alunoSelecionado.Email;
                DtCadastraNasc.Value = _alunoSelecionado.DtNascimento;
                DtCadastraMatric.Value = _alunoSelecionado.DataMatricula;
                TxtStatus.Checked = _alunoSelecionado.Ativo;

                BtnConfirmar.Enabled = false;
                BtnAlterar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               DialogResult dr = MessageBox.Show($"Você realmente deseja remover {_alunoSelecionado.Nome}?"
                                ,"Remover Aluno"
                                ,MessageBoxButtons.YesNo
                                ,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    _alunoSelecionado.Ativo = false;
                    _alunoSelecionado.Excluir();                   
                    CarregaDgvUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Aluno> listaAlunosFiltrada = Aluno.Buscar(_alunos, CbbBuscar.SelectedIndex, TxtBuscar.Text);
            CarregaDgvUsuarios(listaAlunosFiltrada);    

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();   
        }
    }
}
