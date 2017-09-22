namespace prjbase
{
    partial class frmCadEditItem_Livro_Caixa
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId_Livro_Caixa = new System.Windows.Forms.TextBox();
            this.txtUsuario_Inclusao = new System.Windows.Forms.TextBox();
            this.txtInclusao = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlJanela.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(3, -194);
            this.btnFechar.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.TabIndex = 2;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(115, 321);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Size = new System.Drawing.Size(846, 321);
            // 
            // pnlJanela
            // 
            this.pnlJanela.Controls.Add(this.txtInclusao);
            this.pnlJanela.Controls.Add(this.txtUsuario_Inclusao);
            this.pnlJanela.Controls.Add(this.txtId_Livro_Caixa);
            this.pnlJanela.Controls.Add(this.txtValor);
            this.pnlJanela.Controls.Add(this.label4);
            this.pnlJanela.Controls.Add(this.label11);
            this.pnlJanela.Controls.Add(this.cbTipo);
            this.pnlJanela.Controls.Add(this.txtDocumento);
            this.pnlJanela.Controls.Add(this.label3);
            this.pnlJanela.Controls.Add(this.txtDescricao);
            this.pnlJanela.Controls.Add(this.label2);
            this.pnlJanela.Controls.Add(this.txtId);
            this.pnlJanela.Controls.Add(this.label1);
            this.pnlJanela.Location = new System.Drawing.Point(120, 119);
            this.pnlJanela.Size = new System.Drawing.Size(622, 123);
            // 
            // txtDescricao
            // 
            this.epValidaDados.SetFraseErro(this.txtDescricao, "Nome do Item_Livro_Caixa obrigatório.");
            this.txtDescricao.Location = new System.Drawing.Point(87, 61);
            this.txtDescricao.Name = "txtDescricao";
            this.epValidaDados.SetObrigatorio(this.txtDescricao, true);
            this.txtDescricao.Size = new System.Drawing.Size(525, 23);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.Validated += new System.EventHandler(this.Ctrls_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição";
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
            // txtDocumento
            // 
            this.epValidaDados.SetFraseErro(this.txtDocumento, "Nome do Item_Livro_Caixa obrigatório.");
            this.txtDocumento.Location = new System.Drawing.Point(87, 35);
            this.txtDocumento.Name = "txtDocumento";
            this.epValidaDados.SetObrigatorio(this.txtDocumento, true);
            this.txtDocumento.Size = new System.Drawing.Size(146, 23);
            this.txtDocumento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Documento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.epValidaDados.SetFraseErro(this.cbTipo, "");
            this.epValidaDados.SetIndiceCombo(this.cbTipo, -1);
            this.cbTipo.Location = new System.Drawing.Point(270, 34);
            this.cbTipo.Name = "cbTipo";
            this.epValidaDados.SetObrigatorio(this.cbTipo, false);
            this.cbTipo.Size = new System.Drawing.Size(105, 24);
            this.cbTipo.TabIndex = 2;
            // 
            // txtValor
            // 
            this.epValidaDados.SetFraseErro(this.txtValor, "Nome do Item_Livro_Caixa obrigatório.");
            this.txtValor.Location = new System.Drawing.Point(87, 87);
            this.txtValor.Name = "txtValor";
            this.epValidaDados.SetObrigatorio(this.txtValor, true);
            this.txtValor.Size = new System.Drawing.Size(146, 23);
            this.txtValor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Valor";
            // 
            // txtId_Livro_Caixa
            // 
            this.txtId_Livro_Caixa.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtId_Livro_Caixa, "");
            this.txtId_Livro_Caixa.Location = new System.Drawing.Point(270, 9);
            this.txtId_Livro_Caixa.Name = "txtId_Livro_Caixa";
            this.epValidaDados.SetObrigatorio(this.txtId_Livro_Caixa, false);
            this.txtId_Livro_Caixa.ReadOnly = true;
            this.txtId_Livro_Caixa.Size = new System.Drawing.Size(11, 23);
            this.txtId_Livro_Caixa.TabIndex = 14;
            this.txtId_Livro_Caixa.TabStop = false;
            this.txtId_Livro_Caixa.Visible = false;
            // 
            // txtUsuario_Inclusao
            // 
            this.txtUsuario_Inclusao.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtUsuario_Inclusao, "");
            this.txtUsuario_Inclusao.Location = new System.Drawing.Point(287, 9);
            this.txtUsuario_Inclusao.Name = "txtUsuario_Inclusao";
            this.epValidaDados.SetObrigatorio(this.txtUsuario_Inclusao, false);
            this.txtUsuario_Inclusao.ReadOnly = true;
            this.txtUsuario_Inclusao.Size = new System.Drawing.Size(11, 23);
            this.txtUsuario_Inclusao.TabIndex = 15;
            this.txtUsuario_Inclusao.TabStop = false;
            this.txtUsuario_Inclusao.Visible = false;
            // 
            // txtInclusao
            // 
            this.txtInclusao.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtInclusao, "");
            this.txtInclusao.Location = new System.Drawing.Point(304, 9);
            this.txtInclusao.Name = "txtInclusao";
            this.epValidaDados.SetObrigatorio(this.txtInclusao, false);
            this.txtInclusao.ReadOnly = true;
            this.txtInclusao.Size = new System.Drawing.Size(11, 23);
            this.txtInclusao.TabIndex = 16;
            this.txtInclusao.TabStop = false;
            this.txtInclusao.Visible = false;
            // 
            // frmCadEditItem_Livro_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(961, 321);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCadEditItem_Livro_Caixa";
            this.Text = "Item_Livro_Caixa";
            this.Activated += new System.EventHandler(this.frmCadEditItem_Livro_Caixa_Activated);
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlJanela.ResumeLayout(false);
            this.pnlJanela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtUsuario_Inclusao;
        private System.Windows.Forms.TextBox txtId_Livro_Caixa;
        private System.Windows.Forms.TextBox txtInclusao;
    }
}
