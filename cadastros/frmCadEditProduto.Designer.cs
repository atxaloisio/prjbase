namespace prjbase
{
    partial class frmCadEditProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEditProduto));
            this.tcProduto = new System.Windows.Forms.TabControl();
            this.tpEstoque = new System.Windows.Forms.TabPage();
            this.tpTelefoneEmail = new System.Windows.Forms.TabPage();
            this.tpInscrCnae = new System.Windows.Forms.TabPage();
            this.chkProdutorRural = new System.Windows.Forms.CheckBox();
            this.chkoptantesimples = new System.Windows.Forms.CheckBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCodCnae = new System.Windows.Forms.TextBox();
            this.txtDescricaoCnae = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtInscricaoSuframa = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtInscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtInscricaoEstadual = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlBotoes.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).BeginInit();
            this.tcProduto.SuspendLayout();
            this.tpInscrCnae.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Size = new System.Drawing.Size(115, 309);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.label6);
            this.pnlPrincipal.Controls.Add(this.textBox2);
            this.pnlPrincipal.Controls.Add(this.label5);
            this.pnlPrincipal.Controls.Add(this.textBox1);
            this.pnlPrincipal.Controls.Add(this.label4);
            this.pnlPrincipal.Controls.Add(this.comboBox1);
            this.pnlPrincipal.Controls.Add(this.label2);
            this.pnlPrincipal.Controls.Add(this.txtNomeFantasia);
            this.pnlPrincipal.Controls.Add(this.txtCodigo);
            this.pnlPrincipal.Controls.Add(this.txtId);
            this.pnlPrincipal.Controls.Add(this.label1);
            this.pnlPrincipal.Controls.Add(this.txtDescricao);
            this.pnlPrincipal.Controls.Add(this.txtCodInt);
            this.pnlPrincipal.Controls.Add(this.label3);
            this.pnlPrincipal.Controls.Add(this.tcProduto);
            this.pnlPrincipal.Size = new System.Drawing.Size(805, 309);
            // 
            // tcProduto
            // 
            this.tcProduto.Controls.Add(this.tpEstoque);
            this.tcProduto.Controls.Add(this.tpTelefoneEmail);
            this.tcProduto.Controls.Add(this.tpInscrCnae);
            this.tcProduto.Controls.Add(this.tabPage1);
            this.tcProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcProduto.Location = new System.Drawing.Point(0, 98);
            this.tcProduto.Name = "tcProduto";
            this.tcProduto.SelectedIndex = 0;
            this.tcProduto.Size = new System.Drawing.Size(803, 209);
            this.tcProduto.TabIndex = 7;
            // 
            // tpEstoque
            // 
            this.tpEstoque.Location = new System.Drawing.Point(4, 25);
            this.tpEstoque.Name = "tpEstoque";
            this.tpEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstoque.Size = new System.Drawing.Size(795, 180);
            this.tpEstoque.TabIndex = 0;
            this.tpEstoque.Text = "Estoque";
            this.tpEstoque.UseVisualStyleBackColor = true;
            // 
            // tpTelefoneEmail
            // 
            this.tpTelefoneEmail.Location = new System.Drawing.Point(4, 25);
            this.tpTelefoneEmail.Name = "tpTelefoneEmail";
            this.tpTelefoneEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpTelefoneEmail.Size = new System.Drawing.Size(485, 180);
            this.tpTelefoneEmail.TabIndex = 1;
            this.tpTelefoneEmail.Text = "Impostos Aprendidos";
            this.tpTelefoneEmail.UseVisualStyleBackColor = true;
            // 
            // tpInscrCnae
            // 
            this.tpInscrCnae.Controls.Add(this.chkProdutorRural);
            this.tpInscrCnae.Controls.Add(this.chkoptantesimples);
            this.tpInscrCnae.Controls.Add(this.btnPesquisa);
            this.tpInscrCnae.Controls.Add(this.label24);
            this.tpInscrCnae.Controls.Add(this.txtCodCnae);
            this.tpInscrCnae.Controls.Add(this.txtDescricaoCnae);
            this.tpInscrCnae.Controls.Add(this.label23);
            this.tpInscrCnae.Controls.Add(this.txtInscricaoSuframa);
            this.tpInscrCnae.Controls.Add(this.label22);
            this.tpInscrCnae.Controls.Add(this.txtInscricaoMunicipal);
            this.tpInscrCnae.Controls.Add(this.label21);
            this.tpInscrCnae.Controls.Add(this.txtInscricaoEstadual);
            this.tpInscrCnae.Location = new System.Drawing.Point(4, 25);
            this.tpInscrCnae.Name = "tpInscrCnae";
            this.tpInscrCnae.Padding = new System.Windows.Forms.Padding(3);
            this.tpInscrCnae.Size = new System.Drawing.Size(485, 180);
            this.tpInscrCnae.TabIndex = 2;
            this.tpInscrCnae.Text = "Informações Adicionais";
            this.tpInscrCnae.UseVisualStyleBackColor = true;
            // 
            // chkProdutorRural
            // 
            this.chkProdutorRural.AutoSize = true;
            this.chkProdutorRural.Location = new System.Drawing.Point(558, 46);
            this.chkProdutorRural.Name = "chkProdutorRural";
            this.chkProdutorRural.Size = new System.Drawing.Size(123, 20);
            this.chkProdutorRural.TabIndex = 18;
            this.chkProdutorRural.Text = "Produtor Rural";
            this.chkProdutorRural.UseVisualStyleBackColor = true;
            // 
            // chkoptantesimples
            // 
            this.chkoptantesimples.AutoSize = true;
            this.chkoptantesimples.Location = new System.Drawing.Point(558, 30);
            this.chkoptantesimples.Name = "chkoptantesimples";
            this.chkoptantesimples.Size = new System.Drawing.Size(209, 20);
            this.chkoptantesimples.TabIndex = 17;
            this.chkoptantesimples.Text = "Optante do Simples Nacional";
            this.chkoptantesimples.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.Image")));
            this.btnPesquisa.Location = new System.Drawing.Point(154, 31);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(27, 27);
            this.btnPesquisa.TabIndex = 15;
            this.btnPesquisa.TabStop = false;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 16);
            this.label24.TabIndex = 56;
            this.label24.Text = "CNAE";
            // 
            // txtCodCnae
            // 
            this.epValidaDados.SetFraseErro(this.txtCodCnae, "");
            this.txtCodCnae.Location = new System.Drawing.Point(53, 33);
            this.txtCodCnae.Name = "txtCodCnae";
            this.epValidaDados.SetObrigatorio(this.txtCodCnae, false);
            this.txtCodCnae.Size = new System.Drawing.Size(100, 23);
            this.txtCodCnae.TabIndex = 14;
            // 
            // txtDescricaoCnae
            // 
            this.epValidaDados.SetFraseErro(this.txtDescricaoCnae, "Cliente obrigatório.");
            this.txtDescricaoCnae.Location = new System.Drawing.Point(182, 33);
            this.txtDescricaoCnae.Name = "txtDescricaoCnae";
            this.epValidaDados.SetObrigatorio(this.txtDescricaoCnae, true);
            this.txtDescricaoCnae.ReadOnly = true;
            this.txtDescricaoCnae.Size = new System.Drawing.Size(358, 23);
            this.txtDescricaoCnae.TabIndex = 16;
            this.txtDescricaoCnae.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(518, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 16);
            this.label23.TabIndex = 52;
            this.label23.Text = "Inscrição SUFRAMA";
            // 
            // txtInscricaoSuframa
            // 
            this.epValidaDados.SetFraseErro(this.txtInscricaoSuframa, "Nome do Cliente obrigatório.");
            this.txtInscricaoSuframa.Location = new System.Drawing.Point(653, 6);
            this.txtInscricaoSuframa.Name = "txtInscricaoSuframa";
            this.epValidaDados.SetObrigatorio(this.txtInscricaoSuframa, true);
            this.txtInscricaoSuframa.Size = new System.Drawing.Size(123, 23);
            this.txtInscricaoSuframa.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(260, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 16);
            this.label22.TabIndex = 50;
            this.label22.Text = "Inscrição Municipal";
            // 
            // txtInscricaoMunicipal
            // 
            this.epValidaDados.SetFraseErro(this.txtInscricaoMunicipal, "Nome do Cliente obrigatório.");
            this.txtInscricaoMunicipal.Location = new System.Drawing.Point(392, 6);
            this.txtInscricaoMunicipal.Name = "txtInscricaoMunicipal";
            this.epValidaDados.SetObrigatorio(this.txtInscricaoMunicipal, true);
            this.txtInscricaoMunicipal.Size = new System.Drawing.Size(123, 23);
            this.txtInscricaoMunicipal.TabIndex = 12;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 16);
            this.label21.TabIndex = 48;
            this.label21.Text = "Inscrição Estadual";
            // 
            // txtInscricaoEstadual
            // 
            this.epValidaDados.SetFraseErro(this.txtInscricaoEstadual, "Nome do Cliente obrigatório.");
            this.txtInscricaoEstadual.Location = new System.Drawing.Point(134, 6);
            this.txtInscricaoEstadual.Name = "txtInscricaoEstadual";
            this.epValidaDados.SetObrigatorio(this.txtInscricaoEstadual, true);
            this.txtInscricaoEstadual.Size = new System.Drawing.Size(123, 23);
            this.txtInscricaoEstadual.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(485, 180);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Características";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNomeFantasia
            // 
            this.epValidaDados.SetFraseErro(this.txtNomeFantasia, "Nome Fantasia / Nome Abreviado obrigatório.");
            this.txtNomeFantasia.Location = new System.Drawing.Point(84, 63);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.epValidaDados.SetObrigatorio(this.txtNomeFantasia, true);
            this.txtNomeFantasia.Size = new System.Drawing.Size(154, 23);
            this.txtNomeFantasia.TabIndex = 60;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtCodigo, "");
            this.txtCodigo.Location = new System.Drawing.Point(190, 11);
            this.txtCodigo.Name = "txtCodigo";
            this.epValidaDados.SetObrigatorio(this.txtCodigo, false);
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 68;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtId, "");
            this.txtId.Location = new System.Drawing.Point(296, 11);
            this.txtId.Name = "txtId";
            this.epValidaDados.SetObrigatorio(this.txtId, false);
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 67;
            this.txtId.TabStop = false;
            this.txtId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.epValidaDados.SetFraseErro(this.txtDescricao, "Razão social / Nome Completo obrigatório.");
            this.txtDescricao.Location = new System.Drawing.Point(84, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.epValidaDados.SetObrigatorio(this.txtDescricao, true);
            this.txtDescricao.Size = new System.Drawing.Size(394, 23);
            this.txtDescricao.TabIndex = 58;
            // 
            // txtCodInt
            // 
            this.txtCodInt.Enabled = false;
            this.epValidaDados.SetFraseErro(this.txtCodInt, "");
            this.txtCodInt.Location = new System.Drawing.Point(84, 11);
            this.txtCodInt.Name = "txtCodInt";
            this.epValidaDados.SetObrigatorio(this.txtCodInt, false);
            this.txtCodInt.Size = new System.Drawing.Size(100, 23);
            this.txtCodInt.TabIndex = 62;
            this.txtCodInt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Código NCM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Unidade";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.epValidaDados.SetFraseErro(this.comboBox1, "UF obrigatório.");
            this.epValidaDados.SetIndiceCombo(this.comboBox1, -1);
            this.comboBox1.Location = new System.Drawing.Point(549, 62);
            this.comboBox1.MaxLength = 2;
            this.comboBox1.Name = "comboBox1";
            this.epValidaDados.SetObrigatorio(this.comboBox1, true);
            this.comboBox1.Size = new System.Drawing.Size(48, 24);
            this.comboBox1.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 78;
            this.label5.Text = "Código EAN";
            // 
            // textBox1
            // 
            this.epValidaDados.SetFraseErro(this.textBox1, "Nome Fantasia / Nome Abreviado obrigatório.");
            this.textBox1.Location = new System.Drawing.Point(324, 63);
            this.textBox1.Name = "textBox1";
            this.epValidaDados.SetObrigatorio(this.textBox1, true);
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Preço Unitário de Venda";
            // 
            // textBox2
            // 
            this.epValidaDados.SetFraseErro(this.textBox2, "Nome Fantasia / Nome Abreviado obrigatório.");
            this.textBox2.Location = new System.Drawing.Point(648, 38);
            this.textBox2.Name = "textBox2";
            this.epValidaDados.SetObrigatorio(this.textBox2, true);
            this.textBox2.Size = new System.Drawing.Size(127, 23);
            this.textBox2.TabIndex = 79;
            // 
            // frmCadEditProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(920, 309);
            this.Name = "frmCadEditProduto";
            this.Text = "Produto";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidaDados)).EndInit();
            this.tcProduto.ResumeLayout(false);
            this.tpInscrCnae.ResumeLayout(false);
            this.tpInscrCnae.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProduto;
        private System.Windows.Forms.TabPage tpEstoque;
        private System.Windows.Forms.TabPage tpTelefoneEmail;
        private System.Windows.Forms.TabPage tpInscrCnae;
        private System.Windows.Forms.CheckBox chkProdutorRural;
        private System.Windows.Forms.CheckBox chkoptantesimples;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCodCnae;
        private System.Windows.Forms.TextBox txtDescricaoCnae;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtInscricaoSuframa;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtInscricaoMunicipal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtInscricaoEstadual;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
