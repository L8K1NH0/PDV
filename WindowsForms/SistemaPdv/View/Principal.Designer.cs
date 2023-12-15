namespace SistemaPdv
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAIXAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fLUXOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvPedidosRealizados = new System.Windows.Forms.DataGridView();
            this.DgvPedidoEspecifico = new System.Windows.Forms.DataGridView();
            this.LblPedidoRealizado = new System.Windows.Forms.Label();
            this.LblPedidoEspecifico = new System.Windows.Forms.Label();
            this.LblNomeCli = new System.Windows.Forms.Label();
            this.TxtNomeCli = new System.Windows.Forms.TextBox();
            this.LblIdPedido = new System.Windows.Forms.Label();
            this.TxtIdPedido = new System.Windows.Forms.TextBox();
            this.LblContato = new System.Windows.Forms.Label();
            this.TxtContato = new System.Windows.Forms.TextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LblValorCompra = new System.Windows.Forms.Label();
            this.TxtValorCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvFormaPagamento = new System.Windows.Forms.DataGridView();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosRealizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidoEspecifico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.cAIXAToolStripMenuItem,
            this.pDVToolStripMenuItem,
            this.fLUXOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1193, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cADASTROToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.produtoToolStripMenuItem.Text = "Produto";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // cAIXAToolStripMenuItem
            // 
            this.cAIXAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAIXAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cAIXAToolStripMenuItem.Name = "cAIXAToolStripMenuItem";
            this.cAIXAToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.cAIXAToolStripMenuItem.Text = "CAIXA";
            this.cAIXAToolStripMenuItem.Click += new System.EventHandler(this.cAIXAToolStripMenuItem_Click);
            // 
            // pDVToolStripMenuItem
            // 
            this.pDVToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pDVToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem";
            this.pDVToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.pDVToolStripMenuItem.Text = "RELATÓRIO";
            this.pDVToolStripMenuItem.Click += new System.EventHandler(this.pDVToolStripMenuItem_Click);
            // 
            // fLUXOToolStripMenuItem
            // 
            this.fLUXOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fLUXOToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fLUXOToolStripMenuItem.Name = "fLUXOToolStripMenuItem";
            this.fLUXOToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.fLUXOToolStripMenuItem.Text = "FLUXO DE CAIXA";
            this.fLUXOToolStripMenuItem.Click += new System.EventHandler(this.fLUXOToolStripMenuItem_Click);
            // 
            // DgvPedidosRealizados
            // 
            this.DgvPedidosRealizados.AllowUserToAddRows = false;
            this.DgvPedidosRealizados.AllowUserToDeleteRows = false;
            this.DgvPedidosRealizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidosRealizados.EnableHeadersVisualStyles = false;
            this.DgvPedidosRealizados.Location = new System.Drawing.Point(12, 86);
            this.DgvPedidosRealizados.Name = "DgvPedidosRealizados";
            this.DgvPedidosRealizados.ReadOnly = true;
            this.DgvPedidosRealizados.Size = new System.Drawing.Size(542, 519);
            this.DgvPedidosRealizados.TabIndex = 43;
            this.DgvPedidosRealizados.DoubleClick += new System.EventHandler(this.DgvPedidosRealizados_DoubleClick);
            // 
            // DgvPedidoEspecifico
            // 
            this.DgvPedidoEspecifico.AllowUserToAddRows = false;
            this.DgvPedidoEspecifico.AllowUserToDeleteRows = false;
            this.DgvPedidoEspecifico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPedidoEspecifico.EnableHeadersVisualStyles = false;
            this.DgvPedidoEspecifico.Location = new System.Drawing.Point(748, 86);
            this.DgvPedidoEspecifico.Name = "DgvPedidoEspecifico";
            this.DgvPedidoEspecifico.ReadOnly = true;
            this.DgvPedidoEspecifico.Size = new System.Drawing.Size(415, 169);
            this.DgvPedidoEspecifico.TabIndex = 44;
            // 
            // LblPedidoRealizado
            // 
            this.LblPedidoRealizado.AutoSize = true;
            this.LblPedidoRealizado.BackColor = System.Drawing.Color.Transparent;
            this.LblPedidoRealizado.Location = new System.Drawing.Point(8, 45);
            this.LblPedidoRealizado.Name = "LblPedidoRealizado";
            this.LblPedidoRealizado.Size = new System.Drawing.Size(138, 20);
            this.LblPedidoRealizado.TabIndex = 78;
            this.LblPedidoRealizado.Text = "Pedidos Realizados";
            // 
            // LblPedidoEspecifico
            // 
            this.LblPedidoEspecifico.AutoSize = true;
            this.LblPedidoEspecifico.BackColor = System.Drawing.Color.Transparent;
            this.LblPedidoEspecifico.Location = new System.Drawing.Point(744, 45);
            this.LblPedidoEspecifico.Name = "LblPedidoEspecifico";
            this.LblPedidoEspecifico.Size = new System.Drawing.Size(127, 20);
            this.LblPedidoEspecifico.TabIndex = 79;
            this.LblPedidoEspecifico.Text = "Pedido Especifico";
            // 
            // LblNomeCli
            // 
            this.LblNomeCli.AutoSize = true;
            this.LblNomeCli.BackColor = System.Drawing.Color.Transparent;
            this.LblNomeCli.Location = new System.Drawing.Point(744, 396);
            this.LblNomeCli.Name = "LblNomeCli";
            this.LblNomeCli.Size = new System.Drawing.Size(139, 20);
            this.LblNomeCli.TabIndex = 81;
            this.LblNomeCli.Text = "Nome do(a) Clinte :";
            // 
            // TxtNomeCli
            // 
            this.TxtNomeCli.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtNomeCli.Location = new System.Drawing.Point(892, 393);
            this.TxtNomeCli.Name = "TxtNomeCli";
            this.TxtNomeCli.Size = new System.Drawing.Size(271, 27);
            this.TxtNomeCli.TabIndex = 80;
            // 
            // LblIdPedido
            // 
            this.LblIdPedido.AutoSize = true;
            this.LblIdPedido.BackColor = System.Drawing.Color.Transparent;
            this.LblIdPedido.Location = new System.Drawing.Point(1053, 525);
            this.LblIdPedido.Name = "LblIdPedido";
            this.LblIdPedido.Size = new System.Drawing.Size(31, 20);
            this.LblIdPedido.TabIndex = 83;
            this.LblIdPedido.Text = "ID :";
            // 
            // TxtIdPedido
            // 
            this.TxtIdPedido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtIdPedido.Location = new System.Drawing.Point(1090, 521);
            this.TxtIdPedido.Name = "TxtIdPedido";
            this.TxtIdPedido.Size = new System.Drawing.Size(73, 27);
            this.TxtIdPedido.TabIndex = 82;
            // 
            // LblContato
            // 
            this.LblContato.AutoSize = true;
            this.LblContato.BackColor = System.Drawing.Color.Transparent;
            this.LblContato.Location = new System.Drawing.Point(744, 436);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(69, 20);
            this.LblContato.TabIndex = 85;
            this.LblContato.Text = "Contato :";
            // 
            // TxtContato
            // 
            this.TxtContato.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtContato.Location = new System.Drawing.Point(892, 433);
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(271, 27);
            this.TxtContato.TabIndex = 84;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.Color.Transparent;
            this.LblEndereco.Location = new System.Drawing.Point(744, 478);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(78, 20);
            this.LblEndereco.TabIndex = 87;
            this.LblEndereco.Text = "Endereço :";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtEndereco.Location = new System.Drawing.Point(892, 475);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(271, 27);
            this.TxtEndereco.TabIndex = 86;
            // 
            // LblValorCompra
            // 
            this.LblValorCompra.AutoSize = true;
            this.LblValorCompra.BackColor = System.Drawing.Color.Transparent;
            this.LblValorCompra.Location = new System.Drawing.Point(744, 521);
            this.LblValorCompra.Name = "LblValorCompra";
            this.LblValorCompra.Size = new System.Drawing.Size(127, 20);
            this.LblValorCompra.TabIndex = 89;
            this.LblValorCompra.Text = "Valor da compra :";
            // 
            // TxtValorCompra
            // 
            this.TxtValorCompra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtValorCompra.Location = new System.Drawing.Point(892, 518);
            this.TxtValorCompra.Name = "TxtValorCompra";
            this.TxtValorCompra.Size = new System.Drawing.Size(90, 27);
            this.TxtValorCompra.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(744, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Pedido Especifico";
            // 
            // DgvFormaPagamento
            // 
            this.DgvFormaPagamento.AllowUserToAddRows = false;
            this.DgvFormaPagamento.AllowUserToDeleteRows = false;
            this.DgvFormaPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFormaPagamento.EnableHeadersVisualStyles = false;
            this.DgvFormaPagamento.Location = new System.Drawing.Point(748, 295);
            this.DgvFormaPagamento.Name = "DgvFormaPagamento";
            this.DgvFormaPagamento.ReadOnly = true;
            this.DgvFormaPagamento.Size = new System.Drawing.Size(415, 75);
            this.DgvFormaPagamento.TabIndex = 91;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(748, 620);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 38);
            this.BtnLimpar.TabIndex = 92;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(994, 620);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(169, 38);
            this.BtnCancelar.TabIndex = 93;
            this.BtnCancelar.Text = "Cancelar Pedido";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(12, 620);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(181, 38);
            this.BtnUpdate.TabIndex = 94;
            this.BtnUpdate.Text = "Atualizar tabela";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(152, 45);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 95;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Dê dois cliques em um item para vê mais informações\r\n");
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1193, 670);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.DgvFormaPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblValorCompra);
            this.Controls.Add(this.TxtValorCompra);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.LblContato);
            this.Controls.Add(this.TxtContato);
            this.Controls.Add(this.LblIdPedido);
            this.Controls.Add(this.TxtIdPedido);
            this.Controls.Add(this.LblNomeCli);
            this.Controls.Add(this.TxtNomeCli);
            this.Controls.Add(this.LblPedidoEspecifico);
            this.Controls.Add(this.LblPedidoRealizado);
            this.Controls.Add(this.DgvPedidoEspecifico);
            this.Controls.Add(this.DgvPedidosRealizados);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidosRealizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPedidoEspecifico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormaPagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAIXAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fLUXOToolStripMenuItem;
        private System.Windows.Forms.DataGridView DgvPedidosRealizados;
        private System.Windows.Forms.DataGridView DgvPedidoEspecifico;
        private System.Windows.Forms.Label LblPedidoRealizado;
        private System.Windows.Forms.Label LblPedidoEspecifico;
        private System.Windows.Forms.Label LblNomeCli;
        private System.Windows.Forms.TextBox TxtNomeCli;
        private System.Windows.Forms.Label LblIdPedido;
        private System.Windows.Forms.TextBox TxtIdPedido;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.TextBox TxtContato;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label LblValorCompra;
        private System.Windows.Forms.TextBox TxtValorCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvFormaPagamento;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

