namespace prjbase
{
    partial class frmCadEditLivro_Caixa
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldoFinal = new System.Windows.Forms.TextBox();
            this.lblFilial = new System.Windows.Forms.Label();
            this.cbFilial = new System.Windows.Forms.ComboBox();
            this.txtUsuarioInc = new System.Windows.Forms.TextBox();
            this.txtDtInc = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.pnlJanela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, -3919);
            this.btnFechar.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.TabIndex = 2;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(115, 84);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Size = new System.Drawing.Size(615, 84);
            // 
            // pnlJanela
            // 
            this.pnlJanela.Controls.Add(this.txtStatus);
            this.pnlJanela.Controls.Add(this.txtDtInc);
            this.pnlJanela.Controls.Add(this.txtUsuarioInc);
            this.pnlJanela.Controls.Add(this.lblFilial);
            this.pnlJanela.Controls.Add(this.cbFilial);
            this.pnlJanela.Controls.Add(this.label3);
            this.pnlJanela.Controls.Add(this.txtSaldoFinal);
            this.pnlJanela.Controls.Add(this.label5);
            this.pnlJanela.Controls.Add(this.txtSaldoInicial);
            this.pnlJanela.Controls.Add(this.txtData);
            this.pnlJanela.Controls.Add(this.label2);
            this.pnlJanela.Controls.Add(this.txtId);
            this.pnlJanela.Controls.Add(this.label1);
            this.pnlJanela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJanela.Location = new System.Drawing.Point(0, 0);
            this.pnlJanela.Size = new System.Drawing.Size(613, 82);
            this.pnlJanela.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlJanela_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data";
            // 
            // txtId
            // 
            this.epValidaDados.SetFraseErro(this.txtId, "");
            this.txtId.Location = new System.Drawing.Point(56, 9);
            this.txtId.Name = "txtId";
            this.epValidaDados.SetObrigatorio(this.txtId, false);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(84, 23);
            this.txtId.TabIndex = 0;
            this.txtId.TabStop = false;
            this.txtId.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtData, "Data de movimentação obrigatória");
            this.txtData.Location = new System.Drawing.Point(56, 36);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.epValidaDados.SetObrigatorio(this.txtData, true);
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(84, 23);
            this.txtData.TabIndex = 8;
            this.txtData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.epValidaDados.SetTipoValidacao(this.txtData, libComponente.TipoValidacao.Vazio);
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Saldo Abertura";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtSaldoInicial, "Saldo de abertura obrigatório");
            this.txtSaldoInicial.Location = new System.Drawing.Point(253, 36);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.epValidaDados.SetObrigatorio(this.txtSaldoInicial, true);
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(104, 23);
            this.txtSaldoInicial.TabIndex = 77;
            this.txtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            this.txtSaldoInicial.Validating += new System.ComponentModel.CancelEventHandler(this.OnlyNumber_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Saldo Encerramento";
            // 
            // txtSaldoFinal
            // 
            this.txtSaldoFinal.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtSaldoFinal, "Saldo de encerramento obrigatório");
            this.txtSaldoFinal.Location = new System.Drawing.Point(500, 36);
            this.txtSaldoFinal.Name = "txtSaldoFinal";
            this.epValidaDados.SetObrigatorio(this.txtSaldoFinal, true);
            this.txtSaldoFinal.ReadOnly = true;
            this.txtSaldoFinal.Size = new System.Drawing.Size(104, 23);
            this.txtSaldoFinal.TabIndex = 79;
            this.txtSaldoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            this.txtSaldoFinal.Validating += new System.ComponentModel.CancelEventHandler(this.OnlyNumber_Validating);
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Location = new System.Drawing.Point(143, 12);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(34, 16);
            this.lblFilial.TabIndex = 82;
            this.lblFilial.Text = "Filial";
            this.lblFilial.Visible = false;
            // 
            // cbFilial
            // 
            this.cbFilial.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilial.Enabled = false;
            this.cbFilial.FormattingEnabled = true;
            this.epValidaDados.SetFraseErro(this.cbFilial, "");
            this.epValidaDados.SetIndiceCombo(this.cbFilial, -1);
            this.cbFilial.Location = new System.Drawing.Point(180, 9);
            this.cbFilial.Name = "cbFilial";
            this.epValidaDados.SetObrigatorio(this.cbFilial, false);
            this.cbFilial.Size = new System.Drawing.Size(177, 24);
            this.cbFilial.TabIndex = 81;
            this.cbFilial.Visible = false;
            // 
            // txtUsuarioInc
            // 
            this.txtUsuarioInc.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtUsuarioInc, "Valor Unitário do produto Obrigatório");
            this.txtUsuarioInc.Location = new System.Drawing.Point(373, 8);
            this.txtUsuarioInc.Name = "txtUsuarioInc";
            this.epValidaDados.SetObrigatorio(this.txtUsuarioInc, false);
            this.txtUsuarioInc.ReadOnly = true;
            this.txtUsuarioInc.Size = new System.Drawing.Size(10, 23);
            this.txtUsuarioInc.TabIndex = 83;
            this.txtUsuarioInc.TabStop = false;
            this.txtUsuarioInc.Visible = false;
            // 
            // txtDtInc
            // 
            this.txtDtInc.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtDtInc, "Valor Unitário do produto Obrigatório");
            this.txtDtInc.Location = new System.Drawing.Point(389, 8);
            this.txtDtInc.Name = "txtDtInc";
            this.epValidaDados.SetObrigatorio(this.txtDtInc, false);
            this.txtDtInc.ReadOnly = true;
            this.txtDtInc.Size = new System.Drawing.Size(10, 23);
            this.txtDtInc.TabIndex = 84;
            this.txtDtInc.TabStop = false;
            this.txtDtInc.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtStatus, "Valor Unitário do produto Obrigatório");
            this.txtStatus.Location = new System.Drawing.Point(405, 8);
            this.txtStatus.Name = "txtStatus";
            this.epValidaDados.SetObrigatorio(this.txtStatus, false);
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(10, 23);
            this.txtStatus.TabIndex = 85;
            this.txtStatus.TabStop = false;
            this.txtStatus.Visible = false;
            // 
            // frmCadEditLivro_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(730, 84);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCadEditLivro_Caixa";
            this.Text = "Livro Caixa";
            this.Activated += new System.EventHandler(this.frmCadEditLivro_Caixa_Activated);
            this.Resize += new System.EventHandler(this.frmCadEditLivro_Caixa_Resize);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlJanela.ResumeLayout(false);
            this.pnlJanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldoFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.ComboBox cbFilial;
        private System.Windows.Forms.TextBox txtDtInc;
        private System.Windows.Forms.TextBox txtUsuarioInc;
        private System.Windows.Forms.TextBox txtStatus;
    }
}
