namespace SistemaPdv.View
{
    partial class Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caixa));
            this.TxtIdPedido = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.LblNomeCliente = new System.Windows.Forms.Label();
            this.TxtCredito = new System.Windows.Forms.TextBox();
            this.TxtDebito = new System.Windows.Forms.TextBox();
            this.LblContato = new System.Windows.Forms.Label();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblProdutosSelecionados = new System.Windows.Forms.Label();
            this.TxtValorProduto = new System.Windows.Forms.TextBox();
            this.DgvProdutosSelecionados = new System.Windows.Forms.DataGridView();
            this.TxtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.LblValorProduto = new System.Windows.Forms.Label();
            this.DgvEscolhaProdutos = new System.Windows.Forms.DataGridView();
            this.TxtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.BtnAdicionarProduto = new System.Windows.Forms.Button();
            this.LblQuantidadeProduto = new System.Windows.Forms.Label();
            this.LblNomeProduto = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.LblIdProduto = new System.Windows.Forms.Label();
            this.LblFormaPagamento = new System.Windows.Forms.Label();
            this.BtnFinalizarVenda = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtPix = new System.Windows.Forms.TextBox();
            this.TxtDinheiro = new System.Windows.Forms.TextBox();
            this.CkbDinheiro = new System.Windows.Forms.CheckBox();
            this.CkbPix = new System.Windows.Forms.CheckBox();
            this.CkbDebito = new System.Windows.Forms.CheckBox();
            this.CkbCredito = new System.Windows.Forms.CheckBox();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.BtnValorTotal = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblNumResidencia = new System.Windows.Forms.Label();
            this.TxtNumResidencia = new System.Windows.Forms.TextBox();
            this.TxtContato = new System.Windows.Forms.MaskedTextBox();
            this.RbtnEntrega = new System.Windows.Forms.RadioButton();
            this.RbtnRetirada = new System.Windows.Forms.RadioButton();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutosSelecionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEscolhaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIdPedido
            // 
            this.TxtIdPedido.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtIdPedido.Enabled = false;
            this.TxtIdPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtIdPedido.Location = new System.Drawing.Point(59, 20);
            this.TxtIdPedido.Name = "TxtIdPedido";
            this.TxtIdPedido.ReadOnly = true;
            this.TxtIdPedido.Size = new System.Drawing.Size(35, 27);
            this.TxtIdPedido.TabIndex = 7;
            this.TxtIdPedido.TabStop = false;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.BackColor = System.Drawing.SystemColors.Control;
            this.LblId.Location = new System.Drawing.Point(22, 23);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(31, 20);
            this.LblId.TabIndex = 6;
            this.LblId.Text = "ID :";
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtNomeCliente.Location = new System.Drawing.Point(249, 20);
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(207, 27);
            this.TxtNomeCliente.TabIndex = 9;
            this.TxtNomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeCliente_KeyDown);
            // 
            // LblNomeCliente
            // 
            this.LblNomeCliente.AutoSize = true;
            this.LblNomeCliente.BackColor = System.Drawing.SystemColors.Control;
            this.LblNomeCliente.Location = new System.Drawing.Point(126, 23);
            this.LblNomeCliente.Name = "LblNomeCliente";
            this.LblNomeCliente.Size = new System.Drawing.Size(127, 20);
            this.LblNomeCliente.TabIndex = 8;
            this.LblNomeCliente.Text = "Nome do cliente :";
            // 
            // TxtCredito
            // 
            this.TxtCredito.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtCredito.Enabled = false;
            this.TxtCredito.Location = new System.Drawing.Point(336, 128);
            this.TxtCredito.Name = "TxtCredito";
            this.TxtCredito.Size = new System.Drawing.Size(83, 27);
            this.TxtCredito.TabIndex = 11;
            this.TxtCredito.Text = "0";
            this.TxtCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCredito_KeyPress);
            // 
            // TxtDebito
            // 
            this.TxtDebito.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtDebito.Enabled = false;
            this.TxtDebito.Location = new System.Drawing.Point(336, 161);
            this.TxtDebito.Name = "TxtDebito";
            this.TxtDebito.Size = new System.Drawing.Size(83, 27);
            this.TxtDebito.TabIndex = 13;
            this.TxtDebito.Text = "0";
            this.TxtDebito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDebito_KeyPress);
            // 
            // LblContato
            // 
            this.LblContato.AutoSize = true;
            this.LblContato.BackColor = System.Drawing.SystemColors.Control;
            this.LblContato.Location = new System.Drawing.Point(22, 471);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(69, 20);
            this.LblContato.TabIndex = 22;
            this.LblContato.Text = "Contato :";
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtEndereco.Location = new System.Drawing.Point(118, 414);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(221, 27);
            this.TxtEndereco.TabIndex = 21;
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.BackColor = System.Drawing.SystemColors.Control;
            this.LblEndereco.Location = new System.Drawing.Point(22, 417);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(78, 20);
            this.LblEndereco.TabIndex = 20;
            this.LblEndereco.Text = "Endereço :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(466, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 594);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // LblProdutosSelecionados
            // 
            this.LblProdutosSelecionados.AutoSize = true;
            this.LblProdutosSelecionados.BackColor = System.Drawing.SystemColors.Control;
            this.LblProdutosSelecionados.Location = new System.Drawing.Point(556, 336);
            this.LblProdutosSelecionados.Name = "LblProdutosSelecionados";
            this.LblProdutosSelecionados.Size = new System.Drawing.Size(167, 20);
            this.LblProdutosSelecionados.TabIndex = 43;
            this.LblProdutosSelecionados.Text = "Produtos Selecionados :";
            this.LblProdutosSelecionados.Click += new System.EventHandler(this.LblProdutosSelecionados_Click);
            // 
            // TxtValorProduto
            // 
            this.TxtValorProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtValorProduto.Enabled = false;
            this.TxtValorProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtValorProduto.Location = new System.Drawing.Point(787, 161);
            this.TxtValorProduto.Name = "TxtValorProduto";
            this.TxtValorProduto.Size = new System.Drawing.Size(75, 27);
            this.TxtValorProduto.TabIndex = 50;
            // 
            // DgvProdutosSelecionados
            // 
            this.DgvProdutosSelecionados.AllowUserToAddRows = false;
            this.DgvProdutosSelecionados.AllowUserToDeleteRows = false;
            this.DgvProdutosSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutosSelecionados.EnableHeadersVisualStyles = false;
            this.DgvProdutosSelecionados.Location = new System.Drawing.Point(530, 362);
            this.DgvProdutosSelecionados.Name = "DgvProdutosSelecionados";
            this.DgvProdutosSelecionados.ReadOnly = true;
            this.DgvProdutosSelecionados.Size = new System.Drawing.Size(418, 226);
            this.DgvProdutosSelecionados.TabIndex = 42;
            this.toolTip1.SetToolTip(this.DgvProdutosSelecionados, "Dê dois cliques para apagar o item");
            this.DgvProdutosSelecionados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutosSelecionados_CellDoubleClick);
            // 
            // TxtPesquisaProduto
            // 
            this.TxtPesquisaProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtPesquisaProduto.Location = new System.Drawing.Point(492, 49);
            this.TxtPesquisaProduto.Name = "TxtPesquisaProduto";
            this.TxtPesquisaProduto.Size = new System.Drawing.Size(258, 27);
            this.TxtPesquisaProduto.TabIndex = 40;
            this.TxtPesquisaProduto.TextChanged += new System.EventHandler(this.TxtPesquisaProduto_TextChanged);
            // 
            // LblValorProduto
            // 
            this.LblValorProduto.AutoSize = true;
            this.LblValorProduto.BackColor = System.Drawing.SystemColors.Control;
            this.LblValorProduto.Location = new System.Drawing.Point(783, 138);
            this.LblValorProduto.Name = "LblValorProduto";
            this.LblValorProduto.Size = new System.Drawing.Size(51, 20);
            this.LblValorProduto.TabIndex = 49;
            this.LblValorProduto.Text = "Valor :";
            // 
            // DgvEscolhaProdutos
            // 
            this.DgvEscolhaProdutos.AllowUserToAddRows = false;
            this.DgvEscolhaProdutos.AllowUserToDeleteRows = false;
            this.DgvEscolhaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEscolhaProdutos.Location = new System.Drawing.Point(492, 84);
            this.DgvEscolhaProdutos.Name = "DgvEscolhaProdutos";
            this.DgvEscolhaProdutos.ReadOnly = true;
            this.DgvEscolhaProdutos.Size = new System.Drawing.Size(258, 235);
            this.DgvEscolhaProdutos.TabIndex = 41;
            this.DgvEscolhaProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEscolhaProdutos_CellDoubleClick);
            // 
            // TxtQuantidadeProduto
            // 
            this.TxtQuantidadeProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtQuantidadeProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtQuantidadeProduto.Location = new System.Drawing.Point(894, 161);
            this.TxtQuantidadeProduto.Name = "TxtQuantidadeProduto";
            this.TxtQuantidadeProduto.Size = new System.Drawing.Size(100, 27);
            this.TxtQuantidadeProduto.TabIndex = 48;
            this.TxtQuantidadeProduto.TextChanged += new System.EventHandler(this.TxtQuantidadeProduto_TextChanged);
            this.TxtQuantidadeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidadeProduto_KeyPress);
            // 
            // BtnAdicionarProduto
            // 
            this.BtnAdicionarProduto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarProduto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnAdicionarProduto.Location = new System.Drawing.Point(890, 236);
            this.BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            this.BtnAdicionarProduto.Size = new System.Drawing.Size(100, 30);
            this.BtnAdicionarProduto.TabIndex = 44;
            this.BtnAdicionarProduto.Text = "Adicionar";
            this.BtnAdicionarProduto.UseVisualStyleBackColor = false;
            this.BtnAdicionarProduto.Click += new System.EventHandler(this.BtnAdicionarProduto_Click);
            // 
            // LblQuantidadeProduto
            // 
            this.LblQuantidadeProduto.AutoSize = true;
            this.LblQuantidadeProduto.BackColor = System.Drawing.SystemColors.Control;
            this.LblQuantidadeProduto.Location = new System.Drawing.Point(890, 134);
            this.LblQuantidadeProduto.Name = "LblQuantidadeProduto";
            this.LblQuantidadeProduto.Size = new System.Drawing.Size(94, 20);
            this.LblQuantidadeProduto.TabIndex = 47;
            this.LblQuantidadeProduto.Text = "Quantidade :";
            this.LblQuantidadeProduto.Click += new System.EventHandler(this.LblQuantidadeProduto_Click);
            // 
            // LblNomeProduto
            // 
            this.LblNomeProduto.AutoSize = true;
            this.LblNomeProduto.BackColor = System.Drawing.SystemColors.Control;
            this.LblNomeProduto.Location = new System.Drawing.Point(783, 52);
            this.LblNomeProduto.Name = "LblNomeProduto";
            this.LblNomeProduto.Size = new System.Drawing.Size(57, 20);
            this.LblNomeProduto.TabIndex = 45;
            this.LblNomeProduto.Text = "Nome :";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtNomeProduto.Enabled = false;
            this.TxtNomeProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtNomeProduto.Location = new System.Drawing.Point(787, 75);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(207, 27);
            this.TxtNomeProduto.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(448, 293);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(12, 339);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(448, 172);
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtIdProduto.Enabled = false;
            this.TxtIdProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtIdProduto.Location = new System.Drawing.Point(787, 236);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.Size = new System.Drawing.Size(75, 27);
            this.TxtIdProduto.TabIndex = 54;
            // 
            // LblIdProduto
            // 
            this.LblIdProduto.AutoSize = true;
            this.LblIdProduto.BackColor = System.Drawing.SystemColors.Control;
            this.LblIdProduto.Location = new System.Drawing.Point(783, 213);
            this.LblIdProduto.Name = "LblIdProduto";
            this.LblIdProduto.Size = new System.Drawing.Size(31, 20);
            this.LblIdProduto.TabIndex = 53;
            this.LblIdProduto.Text = "ID :";
            // 
            // LblFormaPagamento
            // 
            this.LblFormaPagamento.AutoSize = true;
            this.LblFormaPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.LblFormaPagamento.Location = new System.Drawing.Point(22, 84);
            this.LblFormaPagamento.Name = "LblFormaPagamento";
            this.LblFormaPagamento.Size = new System.Drawing.Size(160, 20);
            this.LblFormaPagamento.TabIndex = 55;
            this.LblFormaPagamento.Text = "Forma de pagamneto :";
            this.LblFormaPagamento.Click += new System.EventHandler(this.LblFormaPagamento_Click);
            // 
            // BtnFinalizarVenda
            // 
            this.BtnFinalizarVenda.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFinalizarVenda.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFinalizarVenda.ForeColor = System.Drawing.Color.White;
            this.BtnFinalizarVenda.Location = new System.Drawing.Point(12, 561);
            this.BtnFinalizarVenda.Name = "BtnFinalizarVenda";
            this.BtnFinalizarVenda.Size = new System.Drawing.Size(147, 30);
            this.BtnFinalizarVenda.TabIndex = 57;
            this.BtnFinalizarVenda.Text = "Finalizar Venda";
            this.BtnFinalizarVenda.UseVisualStyleBackColor = false;
            this.BtnFinalizarVenda.Click += new System.EventHandler(this.BtnFinalizarVenda_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(217, 561);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 30);
            this.BtnCancelar.TabIndex = 59;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtPix
            // 
            this.TxtPix.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtPix.Enabled = false;
            this.TxtPix.Location = new System.Drawing.Point(130, 161);
            this.TxtPix.Name = "TxtPix";
            this.TxtPix.Size = new System.Drawing.Size(83, 27);
            this.TxtPix.TabIndex = 63;
            this.TxtPix.Text = "0";
            this.TxtPix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPix_KeyPress);
            // 
            // TxtDinheiro
            // 
            this.TxtDinheiro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtDinheiro.Enabled = false;
            this.TxtDinheiro.Location = new System.Drawing.Point(130, 128);
            this.TxtDinheiro.Name = "TxtDinheiro";
            this.TxtDinheiro.Size = new System.Drawing.Size(83, 27);
            this.TxtDinheiro.TabIndex = 61;
            this.TxtDinheiro.Text = "0";
            this.TxtDinheiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDinheiro_KeyPress);
            // 
            // CkbDinheiro
            // 
            this.CkbDinheiro.AutoSize = true;
            this.CkbDinheiro.BackColor = System.Drawing.SystemColors.Control;
            this.CkbDinheiro.Location = new System.Drawing.Point(26, 130);
            this.CkbDinheiro.Name = "CkbDinheiro";
            this.CkbDinheiro.Size = new System.Drawing.Size(92, 24);
            this.CkbDinheiro.TabIndex = 64;
            this.CkbDinheiro.Text = "Dinheiro :";
            this.CkbDinheiro.UseVisualStyleBackColor = false;
            this.CkbDinheiro.CheckedChanged += new System.EventHandler(this.CkbDinheiro_CheckedChanged);
            // 
            // CkbPix
            // 
            this.CkbPix.AutoSize = true;
            this.CkbPix.BackColor = System.Drawing.SystemColors.Control;
            this.CkbPix.Location = new System.Drawing.Point(26, 163);
            this.CkbPix.Name = "CkbPix";
            this.CkbPix.Size = new System.Drawing.Size(54, 24);
            this.CkbPix.TabIndex = 65;
            this.CkbPix.Text = "Pix :";
            this.CkbPix.UseVisualStyleBackColor = false;
            this.CkbPix.CheckedChanged += new System.EventHandler(this.CkbPix_CheckedChanged);
            // 
            // CkbDebito
            // 
            this.CkbDebito.AutoSize = true;
            this.CkbDebito.BackColor = System.Drawing.SystemColors.Control;
            this.CkbDebito.Location = new System.Drawing.Point(243, 163);
            this.CkbDebito.Name = "CkbDebito";
            this.CkbDebito.Size = new System.Drawing.Size(81, 24);
            this.CkbDebito.TabIndex = 67;
            this.CkbDebito.Text = "Débito :";
            this.CkbDebito.UseVisualStyleBackColor = false;
            this.CkbDebito.CheckedChanged += new System.EventHandler(this.CkbDebito_CheckedChanged);
            // 
            // CkbCredito
            // 
            this.CkbCredito.AutoSize = true;
            this.CkbCredito.BackColor = System.Drawing.SystemColors.Control;
            this.CkbCredito.Location = new System.Drawing.Point(243, 130);
            this.CkbCredito.Name = "CkbCredito";
            this.CkbCredito.Size = new System.Drawing.Size(84, 24);
            this.CkbCredito.TabIndex = 66;
            this.CkbCredito.Text = "Crédito :";
            this.CkbCredito.UseVisualStyleBackColor = false;
            this.CkbCredito.CheckedChanged += new System.EventHandler(this.CkbCredito_CheckedChanged);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Location = new System.Drawing.Point(118, 248);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(120, 27);
            this.TxtValorTotal.TabIndex = 69;
            this.TxtValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorTotal_KeyPress);
            // 
            // BtnValorTotal
            // 
            this.BtnValorTotal.Location = new System.Drawing.Point(16, 247);
            this.BtnValorTotal.Name = "BtnValorTotal";
            this.BtnValorTotal.Size = new System.Drawing.Size(100, 30);
            this.BtnValorTotal.TabIndex = 70;
            this.BtnValorTotal.Text = "Valor Total :";
            this.BtnValorTotal.UseVisualStyleBackColor = true;
            this.BtnValorTotal.Click += new System.EventHandler(this.BtnValorTotal_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(350, 561);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(110, 30);
            this.BtnMenu.TabIndex = 71;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblNumResidencia
            // 
            this.LblNumResidencia.AutoSize = true;
            this.LblNumResidencia.BackColor = System.Drawing.SystemColors.Control;
            this.LblNumResidencia.Location = new System.Drawing.Point(346, 421);
            this.LblNumResidencia.Name = "LblNumResidencia";
            this.LblNumResidencia.Size = new System.Drawing.Size(33, 20);
            this.LblNumResidencia.TabIndex = 72;
            this.LblNumResidencia.Text = "N° :";
            // 
            // TxtNumResidencia
            // 
            this.TxtNumResidencia.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtNumResidencia.Location = new System.Drawing.Point(385, 417);
            this.TxtNumResidencia.Name = "TxtNumResidencia";
            this.TxtNumResidencia.Size = new System.Drawing.Size(49, 27);
            this.TxtNumResidencia.TabIndex = 73;
            this.TxtNumResidencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumResidencia_KeyPress);
            // 
            // TxtContato
            // 
            this.TxtContato.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtContato.Location = new System.Drawing.Point(118, 464);
            this.TxtContato.Mask = "(99) 0000-00000";
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(141, 27);
            this.TxtContato.TabIndex = 74;
            this.TxtContato.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TxtContato_MaskInputRejected);
            // 
            // RbtnEntrega
            // 
            this.RbtnEntrega.AutoSize = true;
            this.RbtnEntrega.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RbtnEntrega.Location = new System.Drawing.Point(68, 365);
            this.RbtnEntrega.Name = "RbtnEntrega";
            this.RbtnEntrega.Size = new System.Drawing.Size(91, 24);
            this.RbtnEntrega.TabIndex = 75;
            this.RbtnEntrega.TabStop = true;
            this.RbtnEntrega.Text = "ENTREGA";
            this.RbtnEntrega.UseVisualStyleBackColor = false;
            this.RbtnEntrega.CheckedChanged += new System.EventHandler(this.RbtnEntrega_CheckedChanged);
            // 
            // RbtnRetirada
            // 
            this.RbtnRetirada.AutoSize = true;
            this.RbtnRetirada.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RbtnRetirada.Location = new System.Drawing.Point(283, 365);
            this.RbtnRetirada.Name = "RbtnRetirada";
            this.RbtnRetirada.Size = new System.Drawing.Size(96, 24);
            this.RbtnRetirada.TabIndex = 76;
            this.RbtnRetirada.TabStop = true;
            this.RbtnRetirada.Text = "RETIRADA";
            this.RbtnRetirada.UseVisualStyleBackColor = false;
            this.RbtnRetirada.CheckedChanged += new System.EventHandler(this.RbtnRetirada_CheckedChanged);
            // 
            // LblPesquisar
            // 
            this.LblPesquisar.AutoSize = true;
            this.LblPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.LblPesquisar.Location = new System.Drawing.Point(502, 23);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.Size = new System.Drawing.Size(135, 20);
            this.LblPesquisar.TabIndex = 77;
            this.LblPesquisar.Text = "Pesquisar Produto :";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(530, 336);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 78;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Dê dois cliques em um item para apagalo");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(106, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 79;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Com a caixa de texto selecionada, aperte a tecla F2 e selecione o cliente");
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 618);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LblPesquisar);
            this.Controls.Add(this.RbtnRetirada);
            this.Controls.Add(this.RbtnEntrega);
            this.Controls.Add(this.TxtContato);
            this.Controls.Add(this.TxtNumResidencia);
            this.Controls.Add(this.LblNumResidencia);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnValorTotal);
            this.Controls.Add(this.TxtValorTotal);
            this.Controls.Add(this.CkbDebito);
            this.Controls.Add(this.CkbCredito);
            this.Controls.Add(this.CkbPix);
            this.Controls.Add(this.CkbDinheiro);
            this.Controls.Add(this.TxtPix);
            this.Controls.Add(this.TxtDinheiro);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnFinalizarVenda);
            this.Controls.Add(this.LblFormaPagamento);
            this.Controls.Add(this.TxtIdProduto);
            this.Controls.Add(this.LblIdProduto);
            this.Controls.Add(this.LblProdutosSelecionados);
            this.Controls.Add(this.TxtValorProduto);
            this.Controls.Add(this.DgvProdutosSelecionados);
            this.Controls.Add(this.TxtPesquisaProduto);
            this.Controls.Add(this.LblValorProduto);
            this.Controls.Add(this.DgvEscolhaProdutos);
            this.Controls.Add(this.TxtQuantidadeProduto);
            this.Controls.Add(this.BtnAdicionarProduto);
            this.Controls.Add(this.LblQuantidadeProduto);
            this.Controls.Add(this.LblNomeProduto);
            this.Controls.Add(this.TxtNomeProduto);
            this.Controls.Add(this.LblContato);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.TxtDebito);
            this.Controls.Add(this.TxtCredito);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.LblNomeCliente);
            this.Controls.Add(this.TxtIdPedido);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutosSelecionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEscolhaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtIdPedido;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.Label LblNomeCliente;
        private System.Windows.Forms.TextBox TxtCredito;
        private System.Windows.Forms.TextBox TxtDebito;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblProdutosSelecionados;
        private System.Windows.Forms.TextBox TxtValorProduto;
        private System.Windows.Forms.DataGridView DgvProdutosSelecionados;
        private System.Windows.Forms.TextBox TxtPesquisaProduto;
        private System.Windows.Forms.Label LblValorProduto;
        private System.Windows.Forms.DataGridView DgvEscolhaProdutos;
        private System.Windows.Forms.TextBox TxtQuantidadeProduto;
        private System.Windows.Forms.Button BtnAdicionarProduto;
        private System.Windows.Forms.Label LblQuantidadeProduto;
        private System.Windows.Forms.Label LblNomeProduto;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtIdProduto;
        private System.Windows.Forms.Label LblIdProduto;
        private System.Windows.Forms.Label LblFormaPagamento;
        private System.Windows.Forms.Button BtnFinalizarVenda;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtPix;
        private System.Windows.Forms.TextBox TxtDinheiro;
        private System.Windows.Forms.CheckBox CkbDinheiro;
        private System.Windows.Forms.CheckBox CkbPix;
        private System.Windows.Forms.CheckBox CkbDebito;
        private System.Windows.Forms.CheckBox CkbCredito;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Button BtnValorTotal;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblNumResidencia;
        private System.Windows.Forms.TextBox TxtNumResidencia;
        private System.Windows.Forms.MaskedTextBox TxtContato;
        private System.Windows.Forms.RadioButton RbtnEntrega;
        private System.Windows.Forms.RadioButton RbtnRetirada;
        private System.Windows.Forms.Label LblPesquisar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}