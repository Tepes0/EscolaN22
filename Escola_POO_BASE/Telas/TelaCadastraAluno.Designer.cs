namespace Escola_POO_BASE.Telas
{
    partial class TelaCadastraAluno
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
            this.GpbCadastraALuno = new System.Windows.Forms.GroupBox();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DtCadastraMatric = new System.Windows.Forms.DateTimePicker();
            this.DtCadastraNasc = new System.Windows.Forms.DateTimePicker();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCadastraEmail = new System.Windows.Forms.TextBox();
            this.TxtCadastraNome = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.CbbBuscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GpbCadastraALuno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbCadastraALuno
            // 
            this.GpbCadastraALuno.Controls.Add(this.BtnAlterar);
            this.GpbCadastraALuno.Controls.Add(this.BtnNovo);
            this.GpbCadastraALuno.Controls.Add(this.DtCadastraMatric);
            this.GpbCadastraALuno.Controls.Add(this.DtCadastraNasc);
            this.GpbCadastraALuno.Controls.Add(this.BtnConfirmar);
            this.GpbCadastraALuno.Controls.Add(this.TxtStatus);
            this.GpbCadastraALuno.Controls.Add(this.BtnCancelar);
            this.GpbCadastraALuno.Controls.Add(this.label5);
            this.GpbCadastraALuno.Controls.Add(this.label4);
            this.GpbCadastraALuno.Controls.Add(this.label3);
            this.GpbCadastraALuno.Controls.Add(this.label2);
            this.GpbCadastraALuno.Controls.Add(this.label1);
            this.GpbCadastraALuno.Controls.Add(this.TxtCadastraEmail);
            this.GpbCadastraALuno.Controls.Add(this.TxtCadastraNome);
            this.GpbCadastraALuno.Controls.Add(this.TxtId);
            this.GpbCadastraALuno.Location = new System.Drawing.Point(18, 12);
            this.GpbCadastraALuno.Name = "GpbCadastraALuno";
            this.GpbCadastraALuno.Size = new System.Drawing.Size(752, 200);
            this.GpbCadastraALuno.TabIndex = 0;
            this.GpbCadastraALuno.TabStop = false;
            this.GpbCadastraALuno.Text = "Tela Cadastra Aluno";
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(612, 53);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(86, 33);
            this.BtnAlterar.TabIndex = 17;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(612, 14);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(86, 33);
            this.BtnNovo.TabIndex = 16;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DtCadastraMatric
            // 
            this.DtCadastraMatric.Location = new System.Drawing.Point(371, 133);
            this.DtCadastraMatric.Name = "DtCadastraMatric";
            this.DtCadastraMatric.Size = new System.Drawing.Size(200, 22);
            this.DtCadastraMatric.TabIndex = 15;
            // 
            // DtCadastraNasc
            // 
            this.DtCadastraNasc.Location = new System.Drawing.Point(371, 54);
            this.DtCadastraNasc.Name = "DtCadastraNasc";
            this.DtCadastraNasc.Size = new System.Drawing.Size(200, 22);
            this.DtCadastraNasc.TabIndex = 14;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(612, 92);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(86, 31);
            this.BtnConfirmar.TabIndex = 12;
            this.BtnConfirmar.Text = "Confirmar ";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.AutoSize = true;
            this.TxtStatus.Checked = true;
            this.TxtStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TxtStatus.Location = new System.Drawing.Point(293, 14);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(56, 20);
            this.TxtStatus.TabIndex = 13;
            this.TxtStatus.Text = "Ativo";
            this.TxtStatus.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(612, 165);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(86, 29);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data de Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // TxtCadastraEmail
            // 
            this.TxtCadastraEmail.Location = new System.Drawing.Point(16, 133);
            this.TxtCadastraEmail.Name = "TxtCadastraEmail";
            this.TxtCadastraEmail.Size = new System.Drawing.Size(333, 22);
            this.TxtCadastraEmail.TabIndex = 4;
            // 
            // TxtCadastraNome
            // 
            this.TxtCadastraNome.Location = new System.Drawing.Point(98, 56);
            this.TxtCadastraNome.Name = "TxtCadastraNome";
            this.TxtCadastraNome.Size = new System.Drawing.Size(251, 22);
            this.TxtCadastraNome.TabIndex = 1;
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(16, 56);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(41, 22);
            this.TxtId.TabIndex = 0;
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(16, 319);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(748, 225);
            this.DgvUsuarios.TabIndex = 1;
            this.DgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellDoubleClick);
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.TxtBuscar);
            this.groupBox1.Controls.Add(this.CbbBuscar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Painel de Busca";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(614, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 36);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(385, 38);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(199, 24);
            this.TxtBuscar.TabIndex = 2;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // CbbBuscar
            // 
            this.CbbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbbBuscar.FormattingEnabled = true;
            this.CbbBuscar.Items.AddRange(new object[] {
            "Nome",
            "E-mail",
            "Matrícula"});
            this.CbbBuscar.Location = new System.Drawing.Point(106, 38);
            this.CbbBuscar.Name = "CbbBuscar";
            this.CbbBuscar.Size = new System.Drawing.Size(245, 26);
            this.CbbBuscar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Buscar por:";
            // 
            // TelaCadastraAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.GpbCadastraALuno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaCadastraAluno";
            this.Text = "TelaCadastroAluno";
            this.Load += new System.EventHandler(this.TelaCadastroAluno_Load);
            this.GpbCadastraALuno.ResumeLayout(false);
            this.GpbCadastraALuno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbCadastraALuno;
        private System.Windows.Forms.TextBox TxtCadastraNome;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtCadastraEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DateTimePicker DtCadastraMatric;
        private System.Windows.Forms.DateTimePicker DtCadastraNasc;
        private System.Windows.Forms.CheckBox TxtStatus;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.ComboBox CbbBuscar;
    }
}