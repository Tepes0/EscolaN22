﻿namespace Escola_POO_BASE.Telas
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SspRodape = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tsl = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslNomeUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslEmailUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslStatusPerfilUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.adiconarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.PlResumoAlunos = new System.Windows.Forms.Panel();
            this.LblAlunosRemovidos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblAlunosAtivos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblQtdAlunos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SspRodape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PlResumoAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // SspRodape
            // 
            this.SspRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Tsl,
            this.TslNomeUserLogado,
            this.toolStripStatusLabel2,
            this.TslEmailUserLogado,
            this.TslStatusPerfilUsuario,
            this.toolStripStatusLabel3,
            this.TslDataHora});
            this.SspRodape.Location = new System.Drawing.Point(0, 481);
            this.SspRodape.Name = "SspRodape";
            this.SspRodape.Size = new System.Drawing.Size(842, 22);
            this.SspRodape.TabIndex = 1;
            this.SspRodape.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "Usuário Logado: ";
            // 
            // Tsl
            // 
            this.Tsl.Name = "Tsl";
            this.Tsl.Size = new System.Drawing.Size(0, 17);
            // 
            // TslNomeUserLogado
            // 
            this.TslNomeUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslNomeUserLogado.ForeColor = System.Drawing.Color.Green;
            this.TslNomeUserLogado.Name = "TslNomeUserLogado";
            this.TslNomeUserLogado.Size = new System.Drawing.Size(53, 17);
            this.TslNomeUserLogado.Text = "Joaquim";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Email: ";
            // 
            // TslEmailUserLogado
            // 
            this.TslEmailUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslEmailUserLogado.ForeColor = System.Drawing.Color.Green;
            this.TslEmailUserLogado.Name = "TslEmailUserLogado";
            this.TslEmailUserLogado.Size = new System.Drawing.Size(131, 17);
            this.TslEmailUserLogado.Text = "joaquim@hotmail.com";
            // 
            // TslStatusPerfilUsuario
            // 
            this.TslStatusPerfilUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslStatusPerfilUsuario.Name = "TslStatusPerfilUsuario";
            this.TslStatusPerfilUsuario.Size = new System.Drawing.Size(40, 17);
            this.TslStatusPerfilUsuario.Text = "Perfil:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel3.Text = "Aluno";
            // 
            // TslDataHora
            // 
            this.TslDataHora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TslDataHora.Name = "TslDataHora";
            this.TslDataHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TslDataHora.Size = new System.Drawing.Size(424, 17);
            this.TslDataHora.Spring = true;
            this.TslDataHora.Text = "15/08/2023    21:45";
            this.TslDataHora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.adiconarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiAlterarSenha});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // TsiAlterarSenha
            // 
            this.TsiAlterarSenha.Name = "TsiAlterarSenha";
            this.TsiAlterarSenha.Size = new System.Drawing.Size(154, 22);
            this.TsiAlterarSenha.Text = "Alterar Senha";
            this.TsiAlterarSenha.Click += new System.EventHandler(this.TsiAlterarSenha_Click);
            // 
            // adiconarToolStripMenuItem
            // 
            this.adiconarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeAlunosToolStripMenuItem});
            this.adiconarToolStripMenuItem.Name = "adiconarToolStripMenuItem";
            this.adiconarToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.adiconarToolStripMenuItem.Text = "Adicionar";
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            this.cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            this.cadastroDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de Alunos";
            this.cadastroDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeAlunosToolStripMenuItem_Click);
            // 
            // TmrRelogio
            // 
            this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogio_Tick);
            // 
            // PlResumoAlunos
            // 
            this.PlResumoAlunos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlResumoAlunos.Controls.Add(this.LblAlunosRemovidos);
            this.PlResumoAlunos.Controls.Add(this.label5);
            this.PlResumoAlunos.Controls.Add(this.LblAlunosAtivos);
            this.PlResumoAlunos.Controls.Add(this.label3);
            this.PlResumoAlunos.Controls.Add(this.LblQtdAlunos);
            this.PlResumoAlunos.Controls.Add(this.label1);
            this.PlResumoAlunos.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlResumoAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlResumoAlunos.Location = new System.Drawing.Point(0, 25);
            this.PlResumoAlunos.Name = "PlResumoAlunos";
            this.PlResumoAlunos.Size = new System.Drawing.Size(174, 456);
            this.PlResumoAlunos.TabIndex = 4;
            // 
            // LblAlunosRemovidos
            // 
            this.LblAlunosRemovidos.AutoSize = true;
            this.LblAlunosRemovidos.ForeColor = System.Drawing.Color.Red;
            this.LblAlunosRemovidos.Location = new System.Drawing.Point(48, 311);
            this.LblAlunosRemovidos.Name = "LblAlunosRemovidos";
            this.LblAlunosRemovidos.Size = new System.Drawing.Size(51, 20);
            this.LblAlunosRemovidos.TabIndex = 10;
            this.LblAlunosRemovidos.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alunos removidos:\r\n\r\n";
            // 
            // LblAlunosAtivos
            // 
            this.LblAlunosAtivos.AutoSize = true;
            this.LblAlunosAtivos.ForeColor = System.Drawing.Color.Red;
            this.LblAlunosAtivos.Location = new System.Drawing.Point(48, 203);
            this.LblAlunosAtivos.Name = "LblAlunosAtivos";
            this.LblAlunosAtivos.Size = new System.Drawing.Size(51, 20);
            this.LblAlunosAtivos.TabIndex = 8;
            this.LblAlunosAtivos.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alunos ativos:\r\n\r\n";
            // 
            // LblQtdAlunos
            // 
            this.LblQtdAlunos.AutoSize = true;
            this.LblQtdAlunos.ForeColor = System.Drawing.Color.Red;
            this.LblQtdAlunos.Location = new System.Drawing.Point(48, 90);
            this.LblQtdAlunos.Name = "LblQtdAlunos";
            this.LblQtdAlunos.Size = new System.Drawing.Size(51, 20);
            this.LblQtdAlunos.TabIndex = 6;
            this.LblQtdAlunos.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantidade de alunos:\r\n";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 503);
            this.Controls.Add(this.PlResumoAlunos);
            this.Controls.Add(this.SspRodape);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.SspRodape.ResumeLayout(false);
            this.SspRodape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PlResumoAlunos.ResumeLayout(false);
            this.PlResumoAlunos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip SspRodape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Tsl;
        private System.Windows.Forms.ToolStripStatusLabel TslNomeUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel TslEmailUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel TslDataHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsiAlterarSenha;
        private System.Windows.Forms.ToolStripMenuItem adiconarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TslStatusPerfilUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer TmrRelogio;
        private System.Windows.Forms.Panel PlResumoAlunos;
        private System.Windows.Forms.Label LblAlunosRemovidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblAlunosAtivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblQtdAlunos;
        private System.Windows.Forms.Label label1;
    }
}