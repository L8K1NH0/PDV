namespace SistemaPdv.View
{
    partial class CRUD_Produto
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
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.TabProduto = new System.Windows.Forms.TabControl();
            this.TabDadoProduto = new System.Windows.Forms.TabPage();
            this.LblIdCategoria = new System.Windows.Forms.Label();
            this.TxtCategoriaProduto = new System.Windows.Forms.TextBox();
            this.DgvProduto = new System.Windows.Forms.DataGridView();
            this.TxtNome_Consulta = new System.Windows.Forms.TextBox();
            this.LblNome_Consulta = new System.Windows.Forms.Label();
            this.TxtCategoriaSelecionada = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtValorUnitarioProduto = new System.Windows.Forms.TextBox();
            this.LblValorUnitario = new System.Windows.Forms.Label();
            this.TxtNomeProduto = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtIdProduto = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.TabDadoCategoria = new System.Windows.Forms.TabPage();
            this.TxtConsultaCategoria = new System.Windows.Forms.TextBox();
            this.LblNomeCategoria = new System.Windows.Forms.Label();
            this.DgvCategoria = new System.Windows.Forms.DataGridView();
            this.TxtDescricaoCategoria = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtIdCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TabProduto.SuspendLayout();
            this.TabDadoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduto)).BeginInit();
            this.TabDadoCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(683, 405);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(109, 33);
            this.BtnMenu.TabIndex = 11;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(361, 405);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(109, 33);
            this.BtnExcluir.TabIndex = 10;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(246, 405);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(109, 33);
            this.BtnAtualizar.TabIndex = 9;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(131, 405);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(109, 33);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Location = new System.Drawing.Point(16, 405);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(109, 33);
            this.BtnNovo.TabIndex = 7;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TabProduto
            // 
            this.TabProduto.Controls.Add(this.TabDadoProduto);
            this.TabProduto.Controls.Add(this.TabDadoCategoria);
            this.TabProduto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabProduto.Location = new System.Drawing.Point(16, 56);
            this.TabProduto.Name = "TabProduto";
            this.TabProduto.SelectedIndex = 0;
            this.TabProduto.Size = new System.Drawing.Size(776, 343);
            this.TabProduto.TabIndex = 6;
            // 
            // TabDadoProduto
            // 
            this.TabDadoProduto.Controls.Add(this.LblIdCategoria);
            this.TabDadoProduto.Controls.Add(this.TxtCategoriaProduto);
            this.TabDadoProduto.Controls.Add(this.DgvProduto);
            this.TabDadoProduto.Controls.Add(this.TxtNome_Consulta);
            this.TabDadoProduto.Controls.Add(this.LblNome_Consulta);
            this.TabDadoProduto.Controls.Add(this.TxtCategoriaSelecionada);
            this.TabDadoProduto.Controls.Add(this.LblCategoria);
            this.TabDadoProduto.Controls.Add(this.TxtValorUnitarioProduto);
            this.TabDadoProduto.Controls.Add(this.LblValorUnitario);
            this.TabDadoProduto.Controls.Add(this.TxtNomeProduto);
            this.TabDadoProduto.Controls.Add(this.LblNome);
            this.TabDadoProduto.Controls.Add(this.TxtIdProduto);
            this.TabDadoProduto.Controls.Add(this.LblId);
            this.TabDadoProduto.Location = new System.Drawing.Point(4, 29);
            this.TabDadoProduto.Name = "TabDadoProduto";
            this.TabDadoProduto.Padding = new System.Windows.Forms.Padding(3);
            this.TabDadoProduto.Size = new System.Drawing.Size(768, 310);
            this.TabDadoProduto.TabIndex = 0;
            this.TabDadoProduto.Text = "Produto";
            this.TabDadoProduto.UseVisualStyleBackColor = true;
            // 
            // LblIdCategoria
            // 
            this.LblIdCategoria.AutoSize = true;
            this.LblIdCategoria.Location = new System.Drawing.Point(266, 217);
            this.LblIdCategoria.Name = "LblIdCategoria";
            this.LblIdCategoria.Size = new System.Drawing.Size(31, 20);
            this.LblIdCategoria.TabIndex = 19;
            this.LblIdCategoria.Text = "ID :";
            // 
            // TxtCategoriaProduto
            // 
            this.TxtCategoriaProduto.Location = new System.Drawing.Point(303, 210);
            this.TxtCategoriaProduto.Name = "TxtCategoriaProduto";
            this.TxtCategoriaProduto.ReadOnly = true;
            this.TxtCategoriaProduto.Size = new System.Drawing.Size(47, 27);
            this.TxtCategoriaProduto.TabIndex = 18;
            // 
            // DgvProduto
            // 
            this.DgvProduto.AllowUserToAddRows = false;
            this.DgvProduto.AllowUserToDeleteRows = false;
            this.DgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduto.EnableHeadersVisualStyles = false;
            this.DgvProduto.Location = new System.Drawing.Point(402, 54);
            this.DgvProduto.Name = "DgvProduto";
            this.DgvProduto.ReadOnly = true;
            this.DgvProduto.Size = new System.Drawing.Size(360, 250);
            this.DgvProduto.TabIndex = 17;
            this.DgvProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduto_CellDoubleClick);
            // 
            // TxtNome_Consulta
            // 
            this.TxtNome_Consulta.Location = new System.Drawing.Point(531, 18);
            this.TxtNome_Consulta.Name = "TxtNome_Consulta";
            this.TxtNome_Consulta.Size = new System.Drawing.Size(231, 27);
            this.TxtNome_Consulta.TabIndex = 16;
            this.TxtNome_Consulta.TextChanged += new System.EventHandler(this.TxtNome_Consulta_TextChanged_1);
            // 
            // LblNome_Consulta
            // 
            this.LblNome_Consulta.AutoSize = true;
            this.LblNome_Consulta.Location = new System.Drawing.Point(398, 21);
            this.LblNome_Consulta.Name = "LblNome_Consulta";
            this.LblNome_Consulta.Size = new System.Drawing.Size(114, 20);
            this.LblNome_Consulta.TabIndex = 15;
            this.LblNome_Consulta.Text = "Nome Produto :";
            // 
            // TxtCategoriaSelecionada
            // 
            this.TxtCategoriaSelecionada.Location = new System.Drawing.Point(133, 210);
            this.TxtCategoriaSelecionada.Name = "TxtCategoriaSelecionada";
            this.TxtCategoriaSelecionada.ReadOnly = true;
            this.TxtCategoriaSelecionada.Size = new System.Drawing.Size(87, 27);
            this.TxtCategoriaSelecionada.TabIndex = 14;
            this.TxtCategoriaSelecionada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCategoriaProduto_KeyDown);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(6, 213);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(81, 20);
            this.LblCategoria.TabIndex = 10;
            this.LblCategoria.Text = "Categoria :";
            // 
            // TxtValorUnitarioProduto
            // 
            this.TxtValorUnitarioProduto.Location = new System.Drawing.Point(133, 150);
            this.TxtValorUnitarioProduto.Name = "TxtValorUnitarioProduto";
            this.TxtValorUnitarioProduto.Size = new System.Drawing.Size(87, 27);
            this.TxtValorUnitarioProduto.TabIndex = 9;
            this.TxtValorUnitarioProduto.TextChanged += new System.EventHandler(this.TxtValorUnitarioProduto_TextChanged);
            this.TxtValorUnitarioProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUnitarioProduto_KeyPress);
            // 
            // LblValorUnitario
            // 
            this.LblValorUnitario.AutoSize = true;
            this.LblValorUnitario.Location = new System.Drawing.Point(3, 153);
            this.LblValorUnitario.Name = "LblValorUnitario";
            this.LblValorUnitario.Size = new System.Drawing.Size(108, 20);
            this.LblValorUnitario.TabIndex = 8;
            this.LblValorUnitario.Text = "Valor Unitario :";
            // 
            // TxtNomeProduto
            // 
            this.TxtNomeProduto.Location = new System.Drawing.Point(133, 86);
            this.TxtNomeProduto.Name = "TxtNomeProduto";
            this.TxtNomeProduto.Size = new System.Drawing.Size(257, 27);
            this.TxtNomeProduto.TabIndex = 3;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(6, 89);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(57, 20);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome :";
            // 
            // TxtIdProduto
            // 
            this.TxtIdProduto.Location = new System.Drawing.Point(72, 17);
            this.TxtIdProduto.Name = "TxtIdProduto";
            this.TxtIdProduto.ReadOnly = true;
            this.TxtIdProduto.Size = new System.Drawing.Size(58, 27);
            this.TxtIdProduto.TabIndex = 1;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(6, 20);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(31, 20);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID :";
            // 
            // TabDadoCategoria
            // 
            this.TabDadoCategoria.Controls.Add(this.TxtConsultaCategoria);
            this.TabDadoCategoria.Controls.Add(this.LblNomeCategoria);
            this.TabDadoCategoria.Controls.Add(this.DgvCategoria);
            this.TabDadoCategoria.Controls.Add(this.TxtDescricaoCategoria);
            this.TabDadoCategoria.Controls.Add(this.label1);
            this.TabDadoCategoria.Controls.Add(this.TxtNomeCategoria);
            this.TabDadoCategoria.Controls.Add(this.label2);
            this.TabDadoCategoria.Controls.Add(this.TxtIdCategoria);
            this.TabDadoCategoria.Controls.Add(this.label3);
            this.TabDadoCategoria.Location = new System.Drawing.Point(4, 29);
            this.TabDadoCategoria.Name = "TabDadoCategoria";
            this.TabDadoCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.TabDadoCategoria.Size = new System.Drawing.Size(768, 310);
            this.TabDadoCategoria.TabIndex = 1;
            this.TabDadoCategoria.Text = "Categoria";
            this.TabDadoCategoria.UseVisualStyleBackColor = true;
            // 
            // TxtConsultaCategoria
            // 
            this.TxtConsultaCategoria.Location = new System.Drawing.Point(539, 18);
            this.TxtConsultaCategoria.Name = "TxtConsultaCategoria";
            this.TxtConsultaCategoria.Size = new System.Drawing.Size(223, 27);
            this.TxtConsultaCategoria.TabIndex = 25;
            this.TxtConsultaCategoria.TextChanged += new System.EventHandler(this.TxtConsultaCategoria_TextChanged);
            // 
            // LblNomeCategoria
            // 
            this.LblNomeCategoria.AutoSize = true;
            this.LblNomeCategoria.Location = new System.Drawing.Point(398, 21);
            this.LblNomeCategoria.Name = "LblNomeCategoria";
            this.LblNomeCategoria.Size = new System.Drawing.Size(126, 20);
            this.LblNomeCategoria.TabIndex = 24;
            this.LblNomeCategoria.Text = "Nome Categoria :";
            // 
            // DgvCategoria
            // 
            this.DgvCategoria.AllowUserToAddRows = false;
            this.DgvCategoria.AllowUserToDeleteRows = false;
            this.DgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategoria.EnableHeadersVisualStyles = false;
            this.DgvCategoria.Location = new System.Drawing.Point(402, 54);
            this.DgvCategoria.Name = "DgvCategoria";
            this.DgvCategoria.ReadOnly = true;
            this.DgvCategoria.Size = new System.Drawing.Size(360, 250);
            this.DgvCategoria.TabIndex = 23;
            this.DgvCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCategoria_CellDoubleClick_1);
            // 
            // TxtDescricaoCategoria
            // 
            this.TxtDescricaoCategoria.Location = new System.Drawing.Point(111, 142);
            this.TxtDescricaoCategoria.Name = "TxtDescricaoCategoria";
            this.TxtDescricaoCategoria.Size = new System.Drawing.Size(224, 86);
            this.TxtDescricaoCategoria.TabIndex = 22;
            this.TxtDescricaoCategoria.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descrição :";
            // 
            // TxtNomeCategoria
            // 
            this.TxtNomeCategoria.Location = new System.Drawing.Point(111, 96);
            this.TxtNomeCategoria.Name = "TxtNomeCategoria";
            this.TxtNomeCategoria.Size = new System.Drawing.Size(224, 27);
            this.TxtNomeCategoria.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nome :";
            // 
            // TxtIdCategoria
            // 
            this.TxtIdCategoria.Enabled = false;
            this.TxtIdCategoria.Location = new System.Drawing.Point(111, 27);
            this.TxtIdCategoria.Name = "TxtIdCategoria";
            this.TxtIdCategoria.ReadOnly = true;
            this.TxtIdCategoria.Size = new System.Drawing.Size(58, 27);
            this.TxtIdCategoria.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID :";
            // 
            // CRUD_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TabProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD_Produto";
            this.Load += new System.EventHandler(this.CRUD_Produto_Load);
            this.TabProduto.ResumeLayout(false);
            this.TabDadoProduto.ResumeLayout(false);
            this.TabDadoProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduto)).EndInit();
            this.TabDadoCategoria.ResumeLayout(false);
            this.TabDadoCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.TabControl TabProduto;
        private System.Windows.Forms.TabPage TabDadoProduto;
        private System.Windows.Forms.TextBox TxtValorUnitarioProduto;
        private System.Windows.Forms.Label LblValorUnitario;
        private System.Windows.Forms.TextBox TxtNomeProduto;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtIdProduto;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TabPage TabDadoCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtIdCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TxtDescricaoCategoria;
        private System.Windows.Forms.TextBox TxtCategoriaSelecionada;
        private System.Windows.Forms.DataGridView DgvProduto;
        private System.Windows.Forms.TextBox TxtNome_Consulta;
        private System.Windows.Forms.Label LblNome_Consulta;
        private System.Windows.Forms.TextBox TxtConsultaCategoria;
        private System.Windows.Forms.Label LblNomeCategoria;
        private System.Windows.Forms.DataGridView DgvCategoria;
        private System.Windows.Forms.Label LblIdCategoria;
        private System.Windows.Forms.TextBox TxtCategoriaProduto;
        private System.Windows.Forms.Label LblCategoria;
    }
}