namespace Escola_POO_BASE.Telas
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.RbdAluno = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmailA = new System.Windows.Forms.TextBox();
            this.labl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login.Controls.Add(this.checkBox1);
            this.Login.Controls.Add(this.radioButton2);
            this.Login.Controls.Add(this.RbdAluno);
            this.Login.Controls.Add(this.pictureBox1);
            this.Login.Controls.Add(this.BtnEntrar);
            this.Login.Controls.Add(this.TxtSenha);
            this.Login.Controls.Add(this.TxtEmailA);
            this.Login.Controls.Add(this.labl2);
            this.Login.Controls.Add(this.label1);
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(12, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(346, 297);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(249, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 23);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "mostrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sou professor(a)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // RbdAluno
            // 
            this.RbdAluno.AutoSize = true;
            this.RbdAluno.Checked = true;
            this.RbdAluno.Location = new System.Drawing.Point(26, 235);
            this.RbdAluno.Name = "RbdAluno";
            this.RbdAluno.Size = new System.Drawing.Size(118, 24);
            this.RbdAluno.TabIndex = 6;
            this.RbdAluno.TabStop = true;
            this.RbdAluno.Text = "Sou aluno(a)";
            this.RbdAluno.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Escola_POO_BASE.Properties.Resources.Logo_Objetivo_PDF;
            this.pictureBox1.Location = new System.Drawing.Point(3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntrar.Location = new System.Drawing.Point(196, 235);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.Size = new System.Drawing.Size(100, 47);
            this.BtnEntrar.TabIndex = 4;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = false;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtSenha.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TxtSenha.Location = new System.Drawing.Point(26, 193);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(217, 26);
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.UseSystemPasswordChar = true;
            // 
            // TxtEmailA
            // 
            this.TxtEmailA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtEmailA.Location = new System.Drawing.Point(25, 129);
            this.TxtEmailA.Name = "TxtEmailA";
            this.TxtEmailA.Size = new System.Drawing.Size(217, 26);
            this.TxtEmailA.TabIndex = 2;
            // 
            // labl2
            // 
            this.labl2.AutoSize = true;
            this.labl2.Location = new System.Drawing.Point(21, 166);
            this.labl2.Name = "labl2";
            this.labl2.Size = new System.Drawing.Size(60, 20);
            this.labl2.TabIndex = 1;
            this.labl2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail:";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(370, 321);
            this.Controls.Add(this.Login);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaLogin";
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmailA;
        private System.Windows.Forms.Label labl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton RbdAluno;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

