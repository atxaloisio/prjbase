﻿namespace prjbase
{
    partial class frmBaseList
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
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.lblTotalPaginas = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblNumeroPagina = new System.Windows.Forms.Label();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFiltro = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBotoes.Controls.Add(this.lblTotalPaginas);
            this.pnlBotoes.Controls.Add(this.lblDe);
            this.pnlBotoes.Controls.Add(this.lblNumeroPagina);
            this.pnlBotoes.Controls.Add(this.btnPrimeiro);
            this.pnlBotoes.Controls.Add(this.btnAnterior);
            this.pnlBotoes.Controls.Add(this.btnProximo);
            this.pnlBotoes.Controls.Add(this.btnUltimo);
            this.pnlBotoes.Controls.Add(this.btnFechar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotoes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(116, 405);
            this.pnlBotoes.TabIndex = 10;
            // 
            // lblTotalPaginas
            // 
            this.lblTotalPaginas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalPaginas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPaginas.Location = new System.Drawing.Point(70, 322);
            this.lblTotalPaginas.Name = "lblTotalPaginas";
            this.lblTotalPaginas.Size = new System.Drawing.Size(40, 16);
            this.lblTotalPaginas.TabIndex = 18;
            this.lblTotalPaginas.Text = "0";
            this.lblTotalPaginas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDe
            // 
            this.lblDe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(51, 322);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(22, 16);
            this.lblDe.TabIndex = 17;
            this.lblDe.Text = "de";
            this.lblDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroPagina
            // 
            this.lblNumeroPagina.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumeroPagina.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagina.Location = new System.Drawing.Point(9, 322);
            this.lblNumeroPagina.Name = "lblNumeroPagina";
            this.lblNumeroPagina.Size = new System.Drawing.Size(39, 16);
            this.lblNumeroPagina.TabIndex = 16;
            this.lblNumeroPagina.Text = "0";
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrimeiro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Image = global::prjbase.Properties.Resources.primeiro;
            this.btnPrimeiro.Location = new System.Drawing.Point(6, 341);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(26, 23);
            this.btnPrimeiro.TabIndex = 15;
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnterior.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Image = global::prjbase.Properties.Resources.anterior;
            this.btnAnterior.Location = new System.Drawing.Point(34, 341);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(24, 23);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProximo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Image = global::prjbase.Properties.Resources.proximo;
            this.btnProximo.Location = new System.Drawing.Point(60, 341);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(24, 23);
            this.btnProximo.TabIndex = 13;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUltimo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Image = global::prjbase.Properties.Resources.ultimo;
            this.btnUltimo.Location = new System.Drawing.Point(86, 341);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(26, 23);
            this.btnUltimo.TabIndex = 12;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFechar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFechar.Image = global::prjbase.Properties.Resources.fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(4, 370);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(109, 33);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Image = global::prjbase.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(4, 71);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(109, 33);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncluir.Image = global::prjbase.Properties.Resources.novo;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(4, 37);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(109, 33);
            this.btnIncluir.TabIndex = 9;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Image = global::prjbase.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEditar.Location = new System.Drawing.Point(4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 33);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.panel2);
            this.pnlDados.Controls.Add(this.panel1);
            this.pnlDados.Controls.Add(this.panel3);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(116, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(615, 405);
            this.pnlDados.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 313);
            this.panel2.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(0, 0);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(615, 313);
            this.dgvDados.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 57);
            this.panel1.TabIndex = 0;
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiltro.Location = new System.Drawing.Point(0, 0);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.Size = new System.Drawing.Size(615, 57);
            this.dgvFiltro.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 35);
            this.panel3.TabIndex = 2;
            // 
            // frmBaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(731, 405);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "frmBaseList";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaseList_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.pnlDados.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlBotoes;
        public System.Windows.Forms.Panel pnlDados;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnIncluir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.DataGridView dgvDados;
        protected System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDe;
        protected System.Windows.Forms.Label lblTotalPaginas;
        protected System.Windows.Forms.Label lblNumeroPagina;
        protected System.Windows.Forms.Button btnPrimeiro;
        protected System.Windows.Forms.Button btnAnterior;
        protected System.Windows.Forms.Button btnProximo;
        protected System.Windows.Forms.Button btnUltimo;
    }
}
