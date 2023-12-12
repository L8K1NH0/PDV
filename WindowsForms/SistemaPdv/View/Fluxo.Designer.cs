namespace SistemaPdv.View
{
    partial class Fluxo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fluxo));
            this.DgvValores = new System.Windows.Forms.DataGridView();
            this.BtnAbrir = new System.Windows.Forms.Button();
            this.LblNomeCliente = new System.Windows.Forms.Label();
            this.DtpAbrir = new System.Windows.Forms.DateTimePicker();
            this.TxtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechar = new System.Windows.Forms.DateTimePicker();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSaldoFinal = new System.Windows.Forms.TextBox();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.TxtValorFinalAuto = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvValores
            // 
            this.DgvValores.AllowUserToAddRows = false;
            this.DgvValores.AllowUserToDeleteRows = false;
            this.DgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvValores.Location = new System.Drawing.Point(12, 129);
            this.DgvValores.Name = "DgvValores";
            this.DgvValores.ReadOnly = true;
            this.DgvValores.Size = new System.Drawing.Size(525, 89);
            this.DgvValores.TabIndex = 0;
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrir.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrir.ForeColor = System.Drawing.Color.White;
            this.BtnAbrir.Location = new System.Drawing.Point(13, 60);
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(239, 30);
            this.BtnAbrir.TabIndex = 71;
            this.BtnAbrir.Text = "Abrir Caixa";
            this.BtnAbrir.UseVisualStyleBackColor = false;
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // LblNomeCliente
            // 
            this.LblNomeCliente.AutoSize = true;
            this.LblNomeCliente.BackColor = System.Drawing.SystemColors.Control;
            this.LblNomeCliente.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeCliente.Location = new System.Drawing.Point(9, 32);
            this.LblNomeCliente.Name = "LblNomeCliente";
            this.LblNomeCliente.Size = new System.Drawing.Size(83, 20);
            this.LblNomeCliente.TabIndex = 72;
            this.LblNomeCliente.Text = "Data/Hora:";
            // 
            // DtpAbrir
            // 
            this.DtpAbrir.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DtpAbrir.Enabled = false;
            this.DtpAbrir.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpAbrir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpAbrir.Location = new System.Drawing.Point(91, 25);
            this.DtpAbrir.Name = "DtpAbrir";
            this.DtpAbrir.Size = new System.Drawing.Size(161, 29);
            this.DtpAbrir.TabIndex = 73;
            this.DtpAbrir.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // TxtSaldoInicial
            // 
            this.TxtSaldoInicial.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtSaldoInicial.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldoInicial.Location = new System.Drawing.Point(402, 43);
            this.TxtSaldoInicial.Name = "TxtSaldoInicial";
            this.TxtSaldoInicial.Size = new System.Drawing.Size(135, 27);
            this.TxtSaldoInicial.TabIndex = 74;
            this.TxtSaldoInicial.Text = "0";
            this.TxtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldoInicial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Saldo Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Data/Hora:";
            // 
            // DtpFechar
            // 
            this.DtpFechar.CustomFormat = "dd/MM/yyyy HH:mm";
            this.DtpFechar.Enabled = false;
            this.DtpFechar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechar.Location = new System.Drawing.Point(91, 252);
            this.DtpFechar.Name = "DtpFechar";
            this.DtpFechar.Size = new System.Drawing.Size(161, 29);
            this.DtpFechar.TabIndex = 77;
            this.DtpFechar.Value = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            // 
            // BtnFechar
            // 
            this.BtnFechar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.ForeColor = System.Drawing.Color.White;
            this.BtnFechar.Location = new System.Drawing.Point(14, 287);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(238, 30);
            this.BtnFechar.TabIndex = 78;
            this.BtnFechar.Text = "Fechar Caixa";
            this.BtnFechar.UseVisualStyleBackColor = false;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(437, 350);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(100, 30);
            this.BtnMenu.TabIndex = 79;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 81;
            this.label3.Text = "Saldo Final :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtSaldoFinal
            // 
            this.TxtSaldoFinal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtSaldoFinal.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldoFinal.Location = new System.Drawing.Point(402, 287);
            this.TxtSaldoFinal.Name = "TxtSaldoFinal";
            this.TxtSaldoFinal.Size = new System.Drawing.Size(135, 27);
            this.TxtSaldoFinal.TabIndex = 80;
            this.TxtSaldoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldoFinal_KeyPress);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.BackColor = System.Drawing.SystemColors.Control;
            this.LblConfirmar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmar.Location = new System.Drawing.Point(295, 290);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(101, 20);
            this.LblConfirmar.TabIndex = 82;
            this.LblConfirmar.Text = "Confirmação :";
            // 
            // TxtValorFinalAuto
            // 
            this.TxtValorFinalAuto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.TxtValorFinalAuto.Enabled = false;
            this.TxtValorFinalAuto.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorFinalAuto.Location = new System.Drawing.Point(402, 249);
            this.TxtValorFinalAuto.Name = "TxtValorFinalAuto";
            this.TxtValorFinalAuto.ReadOnly = true;
            this.TxtValorFinalAuto.Size = new System.Drawing.Size(135, 27);
            this.TxtValorFinalAuto.TabIndex = 83;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(269, 252);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Valor total calculado automaticamente.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(269, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Campo para confirmar o valor calculado");
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informação";
            // 
            // Fluxo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.TxtValorFinalAuto);
            this.Controls.Add(this.LblConfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSaldoFinal);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.DtpFechar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSaldoInicial);
            this.Controls.Add(this.DtpAbrir);
            this.Controls.Add(this.LblNomeCliente);
            this.Controls.Add(this.BtnAbrir);
            this.Controls.Add(this.DgvValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fluxo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo";
            ((System.ComponentModel.ISupportInitialize)(this.DgvValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvValores;
        private System.Windows.Forms.Button BtnAbrir;
        private System.Windows.Forms.Label LblNomeCliente;
        private System.Windows.Forms.TextBox TxtSaldoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSaldoFinal;
        private System.Windows.Forms.DateTimePicker DtpAbrir;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.TextBox TxtValorFinalAuto;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}