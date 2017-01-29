namespace prjbase
{
    partial class frmCadEditUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDtCriacao = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(115, 131);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.txtDtAlteracao);
            this.pnlPrincipal.Controls.Add(this.txtDtCriacao);
            this.pnlPrincipal.Controls.Add(this.button1);
            this.pnlPrincipal.Controls.Add(this.txtPassword);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.txtEmail);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.txtNome);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtId);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Size = new System.Drawing.Size(429, 131);
            this.pnlPrincipal.TabIndex = 0;
            this.pnlPrincipal.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(57, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(360, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "e-Mail";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(57, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(322, 23);
            this.txtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtDtCriacao
            // 
            this.txtDtCriacao.Enabled = false;
            this.txtDtCriacao.Location = new System.Drawing.Point(57, 137);
            this.txtDtCriacao.Name = "txtDtCriacao";
            this.txtDtCriacao.ReadOnly = true;
            this.txtDtCriacao.Size = new System.Drawing.Size(132, 23);
            this.txtDtCriacao.TabIndex = 8;
            this.txtDtCriacao.Visible = false;
            // 
            // txtDtAlteracao
            // 
            this.txtDtAlteracao.Enabled = false;
            this.txtDtAlteracao.Location = new System.Drawing.Point(247, 137);
            this.txtDtAlteracao.Name = "txtDtAlteracao";
            this.txtDtAlteracao.ReadOnly = true;
            this.txtDtAlteracao.Size = new System.Drawing.Size(132, 23);
            this.txtDtAlteracao.TabIndex = 9;
            this.txtDtAlteracao.Visible = false;
            // 
            // frmCadEditUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(544, 131);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadEditUsuario";
            this.Text = "Usuário";
            this.Shown += new System.EventHandler(this.frmCadEditUsuario_Shown);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtDtAlteracao;
        private System.Windows.Forms.MaskedTextBox txtDtCriacao;
    }
}
