namespace SistemaPdv.View
{
    partial class Relatorio
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
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.LblRelatorio = new System.Windows.Forms.Label();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.LblDataPesqAntiga = new System.Windows.Forms.Label();
            this.LblDataPesqRecente = new System.Windows.Forms.Label();
            this.DgvValores = new System.Windows.Forms.DataGridView();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.LblProdutos = new System.Windows.Forms.Label();
            this.LblValores = new System.Windows.Forms.Label();
            this.LblFluxo = new System.Windows.Forms.Label();
            this.DgvFluxo = new System.Windows.Forms.DataGridView();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFluxo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(12, 80);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.Size = new System.Drawing.Size(526, 339);
            this.DgvProdutos.TabIndex = 0;
            // 
            // LblRelatorio
            // 
            this.LblRelatorio.AutoSize = true;
            this.LblRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelatorio.Location = new System.Drawing.Point(389, 7);
            this.LblRelatorio.Name = "LblRelatorio";
            this.LblRelatorio.Size = new System.Drawing.Size(175, 37);
            this.LblRelatorio.TabIndex = 1;
            this.LblRelatorio.Text = "RELATÓRIO";
            this.LblRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblRelatorio.UseCompatibleTextRendering = true;
            // 
            // DTP1
            // 
            this.DTP1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP1.Location = new System.Drawing.Point(193, 440);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(141, 33);
            this.DTP1.TabIndex = 4;
            this.DTP1.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // LblDataPesqAntiga
            // 
            this.LblDataPesqAntiga.AutoSize = true;
            this.LblDataPesqAntiga.BackColor = System.Drawing.SystemColors.Control;
            this.LblDataPesqAntiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataPesqAntiga.Location = new System.Drawing.Point(12, 447);
            this.LblDataPesqAntiga.Name = "LblDataPesqAntiga";
            this.LblDataPesqAntiga.Size = new System.Drawing.Size(161, 24);
            this.LblDataPesqAntiga.TabIndex = 56;
            this.LblDataPesqAntiga.Text = "Data mais antiga : ";
            // 
            // LblDataPesqRecente
            // 
            this.LblDataPesqRecente.AutoSize = true;
            this.LblDataPesqRecente.BackColor = System.Drawing.SystemColors.Control;
            this.LblDataPesqRecente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataPesqRecente.Location = new System.Drawing.Point(12, 495);
            this.LblDataPesqRecente.Name = "LblDataPesqRecente";
            this.LblDataPesqRecente.Size = new System.Drawing.Size(175, 24);
            this.LblDataPesqRecente.TabIndex = 57;
            this.LblDataPesqRecente.Text = "Data mais recente : ";
            // 
            // DgvValores
            // 
            this.DgvValores.AllowUserToAddRows = false;
            this.DgvValores.AllowUserToDeleteRows = false;
            this.DgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvValores.Location = new System.Drawing.Point(544, 80);
            this.DgvValores.Name = "DgvValores";
            this.DgvValores.ReadOnly = true;
            this.DgvValores.Size = new System.Drawing.Size(389, 108);
            this.DgvValores.TabIndex = 59;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(823, 494);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(110, 30);
            this.BtnMenu.TabIndex = 72;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // LblProdutos
            // 
            this.LblProdutos.AutoSize = true;
            this.LblProdutos.BackColor = System.Drawing.SystemColors.Control;
            this.LblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProdutos.Location = new System.Drawing.Point(12, 53);
            this.LblProdutos.Name = "LblProdutos";
            this.LblProdutos.Size = new System.Drawing.Size(171, 24);
            this.LblProdutos.TabIndex = 73;
            this.LblProdutos.Text = "Produtos Vendidos\r\n";
            // 
            // LblValores
            // 
            this.LblValores.AutoSize = true;
            this.LblValores.BackColor = System.Drawing.SystemColors.Control;
            this.LblValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValores.Location = new System.Drawing.Point(540, 53);
            this.LblValores.Name = "LblValores";
            this.LblValores.Size = new System.Drawing.Size(211, 24);
            this.LblValores.TabIndex = 74;
            this.LblValores.Text = "Formas de Pagamentos";
            // 
            // LblFluxo
            // 
            this.LblFluxo.AutoSize = true;
            this.LblFluxo.BackColor = System.Drawing.SystemColors.Control;
            this.LblFluxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFluxo.Location = new System.Drawing.Point(540, 205);
            this.LblFluxo.Name = "LblFluxo";
            this.LblFluxo.Size = new System.Drawing.Size(147, 24);
            this.LblFluxo.TabIndex = 75;
            this.LblFluxo.Text = "Fluxo de Caixa :";
            // 
            // DgvFluxo
            // 
            this.DgvFluxo.AllowUserToAddRows = false;
            this.DgvFluxo.AllowUserToDeleteRows = false;
            this.DgvFluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFluxo.Location = new System.Drawing.Point(544, 232);
            this.DgvFluxo.Name = "DgvFluxo";
            this.DgvFluxo.ReadOnly = true;
            this.DgvFluxo.Size = new System.Drawing.Size(389, 187);
            this.DgvFluxo.TabIndex = 76;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(361, 491);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(110, 30);
            this.BtnAtualizar.TabIndex = 77;
            this.BtnAtualizar.Text = "Pesquisar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // DTP2
            // 
            this.DTP2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP2.Location = new System.Drawing.Point(193, 491);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(141, 33);
            this.DTP2.TabIndex = 78;
            this.DTP2.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 542);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.DgvFluxo);
            this.Controls.Add(this.LblFluxo);
            this.Controls.Add(this.LblValores);
            this.Controls.Add(this.LblProdutos);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.DgvValores);
            this.Controls.Add(this.LblDataPesqRecente);
            this.Controls.Add(this.LblDataPesqAntiga);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.LblRelatorio);
            this.Controls.Add(this.DgvProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFluxo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Label LblRelatorio;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Label LblDataPesqAntiga;
        private System.Windows.Forms.Label LblDataPesqRecente;
        private System.Windows.Forms.DataGridView DgvValores;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label LblProdutos;
        private System.Windows.Forms.Label LblValores;
        private System.Windows.Forms.Label LblFluxo;
        private System.Windows.Forms.DataGridView DgvFluxo;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.DateTimePicker DTP2;
    }
}