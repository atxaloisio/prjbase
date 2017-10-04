namespace prjbase
{
    partial class frmCadEditContas_Pagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEditContas_Pagar));
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.txtIdEmpresa = new System.Windows.Forms.TextBox();
            this.txtIdFilial = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCliIntegracao = new System.Windows.Forms.TextBox();
            this.txtClienteNome = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDtVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDtInclusao = new System.Windows.Forms.TextBox();
            this.txtDtPrevPagamento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.txtDtPagamento = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.btnFechar.Location = new System.Drawing.Point(3, -351);
            this.btnFechar.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.TabIndex = 2;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnPagamento);
            this.pnlBotoes.Size = new System.Drawing.Size(115, 354);
            this.pnlBotoes.Controls.SetChildIndex(this.btnSalvar, 0);
            this.pnlBotoes.Controls.SetChildIndex(this.btnFechar, 0);
            this.pnlBotoes.Controls.SetChildIndex(this.btnIncluir, 0);
            this.pnlBotoes.Controls.SetChildIndex(this.btnPagamento, 0);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Size = new System.Drawing.Size(903, 354);
            // 
            // pnlJanela
            // 
            this.pnlJanela.Controls.Add(this.txtDtPagamento);
            this.pnlJanela.Controls.Add(this.label8);
            this.pnlJanela.Controls.Add(this.label29);
            this.pnlJanela.Controls.Add(this.txtObs);
            this.pnlJanela.Controls.Add(this.txtIdCliente);
            this.pnlJanela.Controls.Add(this.txtValor);
            this.pnlJanela.Controls.Add(this.label7);
            this.pnlJanela.Controls.Add(this.txtDtPrevPagamento);
            this.pnlJanela.Controls.Add(this.label6);
            this.pnlJanela.Controls.Add(this.txtDtInclusao);
            this.pnlJanela.Controls.Add(this.txtUsuario);
            this.pnlJanela.Controls.Add(this.txtDtVencimento);
            this.pnlJanela.Controls.Add(this.label5);
            this.pnlJanela.Controls.Add(this.cbCategoria);
            this.pnlJanela.Controls.Add(this.label4);
            this.pnlJanela.Controls.Add(this.btnPesquisa);
            this.pnlJanela.Controls.Add(this.label3);
            this.pnlJanela.Controls.Add(this.txtCodCliIntegracao);
            this.pnlJanela.Controls.Add(this.txtClienteNome);
            this.pnlJanela.Controls.Add(this.txtIdFilial);
            this.pnlJanela.Controls.Add(this.txtIdEmpresa);
            this.pnlJanela.Controls.Add(this.chkPago);
            this.pnlJanela.Controls.Add(this.txtDocumento);
            this.pnlJanela.Controls.Add(this.label2);
            this.pnlJanela.Controls.Add(this.txtId);
            this.pnlJanela.Controls.Add(this.label1);
            this.pnlJanela.Location = new System.Drawing.Point(159, 49);
            this.pnlJanela.Size = new System.Drawing.Size(602, 294);
            // 
            // txtDocumento
            // 
            this.epValidaDados.SetFraseErro(this.txtDocumento, "Nome do Contas_Pagar obrigatório.");
            this.txtDocumento.Location = new System.Drawing.Point(87, 88);
            this.txtDocumento.Name = "txtDocumento";
            this.epValidaDados.SetObrigatorio(this.txtDocumento, true);
            this.txtDocumento.Size = new System.Drawing.Size(174, 23);
            this.txtDocumento.TabIndex = 4;
            this.txtDocumento.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDocumento.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Documento";
            // 
            // txtId
            // 
            this.epValidaDados.SetFraseErro(this.txtId, "");
            this.txtId.Location = new System.Drawing.Point(87, 9);
            this.txtId.Name = "txtId";
            this.epValidaDados.SetObrigatorio(this.txtId, false);
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 23);
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
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPago.Location = new System.Drawing.Point(418, 90);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(59, 20);
            this.chkPago.TabIndex = 1;
            this.chkPago.TabStop = false;
            this.chkPago.Text = "Pago";
            this.chkPago.UseVisualStyleBackColor = true;
            this.chkPago.Visible = false;
            // 
            // txtIdEmpresa
            // 
            this.txtIdEmpresa.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtIdEmpresa, "");
            this.txtIdEmpresa.Location = new System.Drawing.Point(322, 9);
            this.txtIdEmpresa.Name = "txtIdEmpresa";
            this.epValidaDados.SetObrigatorio(this.txtIdEmpresa, false);
            this.txtIdEmpresa.ReadOnly = true;
            this.txtIdEmpresa.Size = new System.Drawing.Size(59, 23);
            this.txtIdEmpresa.TabIndex = 8;
            this.txtIdEmpresa.TabStop = false;
            this.txtIdEmpresa.Visible = false;
            // 
            // txtIdFilial
            // 
            this.txtIdFilial.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtIdFilial, "");
            this.txtIdFilial.Location = new System.Drawing.Point(385, 9);
            this.txtIdFilial.Name = "txtIdFilial";
            this.epValidaDados.SetObrigatorio(this.txtIdFilial, false);
            this.txtIdFilial.ReadOnly = true;
            this.txtIdFilial.Size = new System.Drawing.Size(60, 23);
            this.txtIdFilial.TabIndex = 9;
            this.txtIdFilial.TabStop = false;
            this.txtIdFilial.Visible = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(187, 34);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(26, 26);
            this.btnPesquisa.TabIndex = 36;
            this.btnPesquisa.TabStop = false;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fornecedor";
            // 
            // txtCodCliIntegracao
            // 
            this.epValidaDados.SetFraseErro(this.txtCodCliIntegracao, "");
            this.txtCodCliIntegracao.Location = new System.Drawing.Point(87, 35);
            this.txtCodCliIntegracao.Name = "txtCodCliIntegracao";
            this.epValidaDados.SetObrigatorio(this.txtCodCliIntegracao, false);
            this.txtCodCliIntegracao.Size = new System.Drawing.Size(100, 23);
            this.txtCodCliIntegracao.TabIndex = 1;
            this.txtCodCliIntegracao.TextChanged += new System.EventHandler(this.txtCodCliIntegracao_TextChanged);
            this.txtCodCliIntegracao.Validating += new System.ComponentModel.CancelEventHandler(this.txtCodCliIntegracao_Validating);
            this.txtCodCliIntegracao.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // txtClienteNome
            // 
            this.epValidaDados.SetFraseErro(this.txtClienteNome, "Fornecedor obrigatório.");
            this.txtClienteNome.Location = new System.Drawing.Point(213, 35);
            this.txtClienteNome.Name = "txtClienteNome";
            this.epValidaDados.SetObrigatorio(this.txtClienteNome, true);
            this.txtClienteNome.ReadOnly = true;
            this.txtClienteNome.Size = new System.Drawing.Size(359, 23);
            this.txtClienteNome.TabIndex = 2;
            this.txtClienteNome.TabStop = false;
            this.txtClienteNome.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.epValidaDados.SetFraseErro(this.cbCategoria, "Categoria obrigatória.");
            this.epValidaDados.SetIndiceCombo(this.cbCategoria, -1);
            this.cbCategoria.Location = new System.Drawing.Point(87, 61);
            this.cbCategoria.Name = "cbCategoria";
            this.epValidaDados.SetObrigatorio(this.cbCategoria, true);
            this.cbCategoria.Size = new System.Drawing.Size(390, 24);
            this.cbCategoria.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Categoria";
            // 
            // txtDtVencimento
            // 
            this.txtDtVencimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.epValidaDados.SetFraseErro(this.txtDtVencimento, "Data de Vencimento obrigatório");
            this.txtDtVencimento.Location = new System.Drawing.Point(87, 114);
            this.txtDtVencimento.Mask = "00/00/0000";
            this.txtDtVencimento.Name = "txtDtVencimento";
            this.epValidaDados.SetObrigatorio(this.txtDtVencimento, true);
            this.txtDtVencimento.ResetOnPrompt = false;
            this.txtDtVencimento.Size = new System.Drawing.Size(99, 23);
            this.txtDtVencimento.SkipLiterals = false;
            this.txtDtVencimento.TabIndex = 5;
            this.txtDtVencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.epValidaDados.SetTipoValidacao(this.txtDtVencimento, libComponente.TipoValidacao.Vazio);
            this.txtDtVencimento.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDtVencimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            this.txtDtVencimento.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrls_Validating);
            this.txtDtVencimento.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Vencimento";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtUsuario, "");
            this.txtUsuario.Location = new System.Drawing.Point(448, 9);
            this.txtUsuario.Name = "txtUsuario";
            this.epValidaDados.SetObrigatorio(this.txtUsuario, false);
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(60, 23);
            this.txtUsuario.TabIndex = 42;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Visible = false;
            // 
            // txtDtInclusao
            // 
            this.txtDtInclusao.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtDtInclusao, "");
            this.txtDtInclusao.Location = new System.Drawing.Point(511, 9);
            this.txtDtInclusao.Name = "txtDtInclusao";
            this.epValidaDados.SetObrigatorio(this.txtDtInclusao, false);
            this.txtDtInclusao.ReadOnly = true;
            this.txtDtInclusao.Size = new System.Drawing.Size(60, 23);
            this.txtDtInclusao.TabIndex = 43;
            this.txtDtInclusao.TabStop = false;
            this.txtDtInclusao.Visible = false;
            // 
            // txtDtPrevPagamento
            // 
            this.epValidaDados.SetFraseErro(this.txtDtPrevPagamento, "Data de previsão de pagamento obrigatório");
            this.txtDtPrevPagamento.Location = new System.Drawing.Point(378, 114);
            this.txtDtPrevPagamento.Mask = "00/00/0000";
            this.txtDtPrevPagamento.Name = "txtDtPrevPagamento";
            this.epValidaDados.SetObrigatorio(this.txtDtPrevPagamento, true);
            this.txtDtPrevPagamento.Size = new System.Drawing.Size(99, 23);
            this.txtDtPrevPagamento.TabIndex = 6;
            this.txtDtPrevPagamento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.epValidaDados.SetTipoValidacao(this.txtDtPrevPagamento, libComponente.TipoValidacao.Vazio);
            this.txtDtPrevPagamento.ValidatingType = typeof(System.DateTime);
            this.txtDtPrevPagamento.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDtPrevPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            this.txtDtPrevPagamento.Validating += new System.ComponentModel.CancelEventHandler(this.Ctrls_Validating);
            this.txtDtPrevPagamento.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Previsão de Pagamento";
            // 
            // txtValor
            // 
            this.epValidaDados.SetFraseErro(this.txtValor, "Valor do Contas_Pagar obrigatório.");
            this.txtValor.Location = new System.Drawing.Point(87, 140);
            this.txtValor.Name = "txtValor";
            this.epValidaDados.SetObrigatorio(this.txtValor, true);
            this.txtValor.Size = new System.Drawing.Size(174, 23);
            this.txtValor.TabIndex = 7;
            this.txtValor.Enter += new System.EventHandler(this.txt_Enter);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.OnlyNumber_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Valor";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtIdCliente, "");
            this.txtIdCliente.Location = new System.Drawing.Point(258, 8);
            this.txtIdCliente.Name = "txtIdCliente";
            this.epValidaDados.SetObrigatorio(this.txtIdCliente, false);
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(59, 23);
            this.txtIdCliente.TabIndex = 48;
            this.txtIdCliente.TabStop = false;
            this.txtIdCliente.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 169);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 16);
            this.label29.TabIndex = 64;
            this.label29.Text = "Observações";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 187);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(588, 98);
            this.txtObs.TabIndex = 63;
            this.txtObs.Text = "";
            // 
            // btnPagamento
            // 
            this.btnPagamento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPagamento.Image = global::prjbase.Properties.Resources.siflao;
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagamento.Location = new System.Drawing.Point(3, 73);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(109, 33);
            this.btnPagamento.TabIndex = 3;
            this.btnPagamento.TabStop = false;
            this.btnPagamento.Text = "&Pagar";
            this.btnPagamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagamento.UseVisualStyleBackColor = false;
            this.btnPagamento.Visible = false;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // txtDtPagamento
            // 
            this.txtDtPagamento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtDtPagamento.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtDtPagamento, "");
            this.txtDtPagamento.Location = new System.Drawing.Point(378, 140);
            this.txtDtPagamento.Mask = "00/00/0000";
            this.txtDtPagamento.Name = "txtDtPagamento";
            this.epValidaDados.SetObrigatorio(this.txtDtPagamento, false);
            this.txtDtPagamento.ReadOnly = true;
            this.txtDtPagamento.ResetOnPrompt = false;
            this.txtDtPagamento.Size = new System.Drawing.Size(99, 23);
            this.txtDtPagamento.SkipLiterals = false;
            this.txtDtPagamento.TabIndex = 65;
            this.txtDtPagamento.TabStop = false;
            this.txtDtPagamento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.epValidaDados.SetTipoValidacao(this.txtDtPagamento, libComponente.TipoValidacao.Vazio);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Pagamento";
            // 
            // frmCadEditContas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1018, 354);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCadEditContas_Pagar";
            this.Text = "Contas a Pagar";
            this.Activated += new System.EventHandler(this.frmCadEditContas_Pagar_Activated);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlJanela.ResumeLayout(false);
            this.pnlJanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.TextBox txtIdFilial;
        private System.Windows.Forms.TextBox txtIdEmpresa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCliIntegracao;
        private System.Windows.Forms.TextBox txtClienteNome;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDtPrevPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDtInclusao;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtDtVencimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RichTextBox txtObs;
        public System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.MaskedTextBox txtDtPagamento;
        private System.Windows.Forms.Label label8;
    }
}
