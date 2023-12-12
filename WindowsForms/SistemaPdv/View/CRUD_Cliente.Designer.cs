namespace SistemaPdv.View
{
    partial class CRUD_Fornecedor
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
            this.TabCliente = new System.Windows.Forms.TabControl();
            this.TabDados = new System.Windows.Forms.TabPage();
            this.TxtNumeroCasa = new System.Windows.Forms.TextBox();
            this.LblNumeroCasa = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.LblLogradouro = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AlertBairro = new System.Windows.Forms.Label();
            this.AlertNumCasa = new System.Windows.Forms.Label();
            this.AlertEndereco = new System.Windows.Forms.Label();
            this.BtnCEP = new System.Windows.Forms.Button();
            this.TxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTituloEndereco = new System.Windows.Forms.Label();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AlertID = new System.Windows.Forms.Label();
            this.BtnValidarCPF = new System.Windows.Forms.Button();
            this.AlertCpf = new System.Windows.Forms.Label();
            this.AlertContato = new System.Windows.Forms.Label();
            this.AlertNome = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.TxtContato = new System.Windows.Forms.MaskedTextBox();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblTituloCliente = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblContato = new System.Windows.Forms.Label();
            this.TabConsulta = new System.Windows.Forms.TabPage();
            this.DgvConsulta = new System.Windows.Forms.DataGridView();
            this.TxtNome_Consulta = new System.Windows.Forms.TextBox();
            this.LblNome_Consulta = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.TabCliente.SuspendLayout();
            this.TabDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCliente
            // 
            this.TabCliente.Controls.Add(this.TabDados);
            this.TabCliente.Controls.Add(this.TabConsulta);
            this.TabCliente.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabCliente.Location = new System.Drawing.Point(12, 56);
            this.TabCliente.Name = "TabCliente";
            this.TabCliente.SelectedIndex = 0;
            this.TabCliente.Size = new System.Drawing.Size(776, 343);
            this.TabCliente.TabIndex = 0;
            // 
            // TabDados
            // 
            this.TabDados.Controls.Add(this.TxtNumeroCasa);
            this.TabDados.Controls.Add(this.LblNumeroCasa);
            this.TabDados.Controls.Add(this.TxtCidade);
            this.TabDados.Controls.Add(this.LblCidade);
            this.TabDados.Controls.Add(this.TxtBairro);
            this.TabDados.Controls.Add(this.LblBairro);
            this.TabDados.Controls.Add(this.LblLogradouro);
            this.TabDados.Controls.Add(this.TxtNome);
            this.TabDados.Controls.Add(this.LblNome);
            this.TabDados.Controls.Add(this.TxtId);
            this.TabDados.Controls.Add(this.LblId);
            this.TabDados.Controls.Add(this.panel1);
            this.TabDados.Controls.Add(this.panel2);
            this.TabDados.Location = new System.Drawing.Point(4, 29);
            this.TabDados.Name = "TabDados";
            this.TabDados.Padding = new System.Windows.Forms.Padding(3);
            this.TabDados.Size = new System.Drawing.Size(768, 310);
            this.TabDados.TabIndex = 0;
            this.TabDados.Text = "Dados";
            this.TabDados.UseVisualStyleBackColor = true;
            // 
            // TxtNumeroCasa
            // 
            this.TxtNumeroCasa.Location = new System.Drawing.Point(492, 242);
            this.TxtNumeroCasa.Name = "TxtNumeroCasa";
            this.TxtNumeroCasa.Size = new System.Drawing.Size(69, 27);
            this.TxtNumeroCasa.TabIndex = 15;
            this.TxtNumeroCasa.TextChanged += new System.EventHandler(this.TxtNumeroCasa_TextChanged);
            // 
            // LblNumeroCasa
            // 
            this.LblNumeroCasa.AutoSize = true;
            this.LblNumeroCasa.Location = new System.Drawing.Point(394, 245);
            this.LblNumeroCasa.Name = "LblNumeroCasa";
            this.LblNumeroCasa.Size = new System.Drawing.Size(70, 20);
            this.LblNumeroCasa.TabIndex = 14;
            this.LblNumeroCasa.Text = "Numero :";
            this.LblNumeroCasa.Click += new System.EventHandler(this.LblNumeroCasa_Click);
            // 
            // TxtCidade
            // 
            this.TxtCidade.Location = new System.Drawing.Point(492, 189);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(243, 27);
            this.TxtCidade.TabIndex = 13;
            this.TxtCidade.TextChanged += new System.EventHandler(this.TxtCidade_TextChanged);
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(394, 192);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(63, 20);
            this.LblCidade.TabIndex = 12;
            this.LblCidade.Text = "Cidade :";
            this.LblCidade.Click += new System.EventHandler(this.LblCidade_Click);
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(492, 139);
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(243, 27);
            this.TxtBairro.TabIndex = 11;
            this.TxtBairro.TextChanged += new System.EventHandler(this.TxtBairro_TextChanged);
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Location = new System.Drawing.Point(394, 142);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(56, 20);
            this.LblBairro.TabIndex = 10;
            this.LblBairro.Text = "Bairro :";
            this.LblBairro.Click += new System.EventHandler(this.LblBairro_Click);
            // 
            // LblLogradouro
            // 
            this.LblLogradouro.AutoSize = true;
            this.LblLogradouro.Location = new System.Drawing.Point(394, 89);
            this.LblLogradouro.Name = "LblLogradouro";
            this.LblLogradouro.Size = new System.Drawing.Size(78, 20);
            this.LblLogradouro.TabIndex = 8;
            this.LblLogradouro.Text = "Endereço :";
            this.LblLogradouro.Click += new System.EventHandler(this.LblLogradouro_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(86, 86);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(257, 27);
            this.TxtNome.TabIndex = 3;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(8, 89);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(57, 20);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome :";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(86, 17);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(58, 27);
            this.TxtId.TabIndex = 1;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(8, 20);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(31, 20);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "ID :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AlertBairro);
            this.panel1.Controls.Add(this.AlertNumCasa);
            this.panel1.Controls.Add(this.AlertEndereco);
            this.panel1.Controls.Add(this.BtnCEP);
            this.panel1.Controls.Add(this.TxtCEP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblTituloEndereco);
            this.panel1.Controls.Add(this.TxtLogradouro);
            this.panel1.Location = new System.Drawing.Point(385, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 298);
            this.panel1.TabIndex = 18;
            // 
            // AlertBairro
            // 
            this.AlertBairro.AutoSize = true;
            this.AlertBairro.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertBairro.ForeColor = System.Drawing.Color.Red;
            this.AlertBairro.Location = new System.Drawing.Point(350, 133);
            this.AlertBairro.Name = "AlertBairro";
            this.AlertBairro.Size = new System.Drawing.Size(22, 28);
            this.AlertBairro.TabIndex = 27;
            this.AlertBairro.Text = "*";
            this.AlertBairro.Visible = false;
            // 
            // AlertNumCasa
            // 
            this.AlertNumCasa.AutoSize = true;
            this.AlertNumCasa.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertNumCasa.ForeColor = System.Drawing.Color.Red;
            this.AlertNumCasa.Location = new System.Drawing.Point(179, 235);
            this.AlertNumCasa.Name = "AlertNumCasa";
            this.AlertNumCasa.Size = new System.Drawing.Size(22, 28);
            this.AlertNumCasa.TabIndex = 26;
            this.AlertNumCasa.Text = "*";
            this.AlertNumCasa.Visible = false;
            // 
            // AlertEndereco
            // 
            this.AlertEndereco.AutoSize = true;
            this.AlertEndereco.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertEndereco.ForeColor = System.Drawing.Color.Red;
            this.AlertEndereco.Location = new System.Drawing.Point(350, 80);
            this.AlertEndereco.Name = "AlertEndereco";
            this.AlertEndereco.Size = new System.Drawing.Size(22, 28);
            this.AlertEndereco.TabIndex = 25;
            this.AlertEndereco.Text = "*";
            this.AlertEndereco.Visible = false;
            // 
            // BtnCEP
            // 
            this.BtnCEP.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCEP.Location = new System.Drawing.Point(219, 34);
            this.BtnCEP.Name = "BtnCEP";
            this.BtnCEP.Size = new System.Drawing.Size(91, 30);
            this.BtnCEP.TabIndex = 6;
            this.BtnCEP.Text = "Pesquisar";
            this.BtnCEP.UseVisualStyleBackColor = true;
            this.BtnCEP.Click += new System.EventHandler(this.BtnCEP_Click);
            // 
            // TxtCEP
            // 
            this.TxtCEP.Location = new System.Drawing.Point(107, 34);
            this.TxtCEP.Mask = "00000-999";
            this.TxtCEP.Name = "TxtCEP";
            this.TxtCEP.Size = new System.Drawing.Size(94, 27);
            this.TxtCEP.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "CEP :";
            // 
            // LblTituloEndereco
            // 
            this.LblTituloEndereco.AutoSize = true;
            this.LblTituloEndereco.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloEndereco.Location = new System.Drawing.Point(293, 11);
            this.LblTituloEndereco.Name = "LblTituloEndereco";
            this.LblTituloEndereco.Size = new System.Drawing.Size(79, 20);
            this.LblTituloEndereco.TabIndex = 21;
            this.LblTituloEndereco.Text = "Endereço";
            this.LblTituloEndereco.Click += new System.EventHandler(this.LblTituloEndereco_Click);
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(107, 80);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(243, 27);
            this.TxtLogradouro.TabIndex = 9;
            this.TxtLogradouro.TextChanged += new System.EventHandler(this.TxtLogradouro_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AlertID);
            this.panel2.Controls.Add(this.BtnValidarCPF);
            this.panel2.Controls.Add(this.AlertCpf);
            this.panel2.Controls.Add(this.AlertContato);
            this.panel2.Controls.Add(this.AlertNome);
            this.panel2.Controls.Add(this.LblCPF);
            this.panel2.Controls.Add(this.TxtContato);
            this.panel2.Controls.Add(this.TxtCPF);
            this.panel2.Controls.Add(this.LblTituloCliente);
            this.panel2.Controls.Add(this.TxtEmail);
            this.panel2.Controls.Add(this.LblEmail);
            this.panel2.Controls.Add(this.LblContato);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 298);
            this.panel2.TabIndex = 19;
            // 
            // AlertID
            // 
            this.AlertID.AutoSize = true;
            this.AlertID.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertID.ForeColor = System.Drawing.Color.Red;
            this.AlertID.Location = new System.Drawing.Point(144, 10);
            this.AlertID.Name = "AlertID";
            this.AlertID.Size = new System.Drawing.Size(22, 28);
            this.AlertID.TabIndex = 25;
            this.AlertID.Text = "*";
            this.AlertID.Visible = false;
            // 
            // BtnValidarCPF
            // 
            this.BtnValidarCPF.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarCPF.Location = new System.Drawing.Point(243, 226);
            this.BtnValidarCPF.Name = "BtnValidarCPF";
            this.BtnValidarCPF.Size = new System.Drawing.Size(109, 33);
            this.BtnValidarCPF.TabIndex = 6;
            this.BtnValidarCPF.Text = "Validar";
            this.BtnValidarCPF.UseVisualStyleBackColor = true;
            this.BtnValidarCPF.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlertCpf
            // 
            this.AlertCpf.AutoSize = true;
            this.AlertCpf.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertCpf.ForeColor = System.Drawing.Color.Red;
            this.AlertCpf.Location = new System.Drawing.Point(215, 235);
            this.AlertCpf.Name = "AlertCpf";
            this.AlertCpf.Size = new System.Drawing.Size(22, 28);
            this.AlertCpf.TabIndex = 24;
            this.AlertCpf.Text = "*";
            this.AlertCpf.Visible = false;
            // 
            // AlertContato
            // 
            this.AlertContato.AutoSize = true;
            this.AlertContato.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertContato.ForeColor = System.Drawing.Color.Red;
            this.AlertContato.Location = new System.Drawing.Point(215, 183);
            this.AlertContato.Name = "AlertContato";
            this.AlertContato.Size = new System.Drawing.Size(22, 28);
            this.AlertContato.TabIndex = 23;
            this.AlertContato.Text = "*";
            this.AlertContato.Visible = false;
            // 
            // AlertNome
            // 
            this.AlertNome.AutoSize = true;
            this.AlertNome.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertNome.ForeColor = System.Drawing.Color.Red;
            this.AlertNome.Location = new System.Drawing.Point(342, 80);
            this.AlertNome.Name = "AlertNome";
            this.AlertNome.Size = new System.Drawing.Size(22, 28);
            this.AlertNome.TabIndex = 20;
            this.AlertNome.Text = "*";
            this.AlertNome.Visible = false;
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Location = new System.Drawing.Point(6, 239);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(40, 20);
            this.LblCPF.TabIndex = 16;
            this.LblCPF.Text = "CPF :";
            // 
            // TxtContato
            // 
            this.TxtContato.Location = new System.Drawing.Point(81, 180);
            this.TxtContato.Mask = "(99) 0000-00000";
            this.TxtContato.Name = "TxtContato";
            this.TxtContato.Size = new System.Drawing.Size(141, 27);
            this.TxtContato.TabIndex = 22;
            // 
            // TxtCPF
            // 
            this.TxtCPF.Location = new System.Drawing.Point(80, 232);
            this.TxtCPF.Mask = "###.###.###-##";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(134, 27);
            this.TxtCPF.TabIndex = 21;
            this.TxtCPF.TextChanged += new System.EventHandler(this.TxtCPF_TextChanged);
            // 
            // LblTituloCliente
            // 
            this.LblTituloCliente.AutoSize = true;
            this.LblTituloCliente.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloCliente.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloCliente.Location = new System.Drawing.Point(302, 11);
            this.LblTituloCliente.Name = "LblTituloCliente";
            this.LblTituloCliente.Size = new System.Drawing.Size(62, 20);
            this.LblTituloCliente.TabIndex = 20;
            this.LblTituloCliente.Text = "Cliente";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(77, 128);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(257, 27);
            this.TxtEmail.TabIndex = 7;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(6, 131);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(53, 20);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "Email :";
            // 
            // LblContato
            // 
            this.LblContato.AutoSize = true;
            this.LblContato.Location = new System.Drawing.Point(6, 183);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(69, 20);
            this.LblContato.TabIndex = 4;
            this.LblContato.Text = "Contato :";
            // 
            // TabConsulta
            // 
            this.TabConsulta.Controls.Add(this.DgvConsulta);
            this.TabConsulta.Controls.Add(this.TxtNome_Consulta);
            this.TabConsulta.Controls.Add(this.LblNome_Consulta);
            this.TabConsulta.Location = new System.Drawing.Point(4, 29);
            this.TabConsulta.Name = "TabConsulta";
            this.TabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.TabConsulta.Size = new System.Drawing.Size(768, 310);
            this.TabConsulta.TabIndex = 1;
            this.TabConsulta.Text = "Consulta";
            this.TabConsulta.UseVisualStyleBackColor = true;
            // 
            // DgvConsulta
            // 
            this.DgvConsulta.AllowUserToAddRows = false;
            this.DgvConsulta.AllowUserToDeleteRows = false;
            this.DgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConsulta.EnableHeadersVisualStyles = false;
            this.DgvConsulta.Location = new System.Drawing.Point(6, 54);
            this.DgvConsulta.Name = "DgvConsulta";
            this.DgvConsulta.ReadOnly = true;
            this.DgvConsulta.Size = new System.Drawing.Size(756, 250);
            this.DgvConsulta.TabIndex = 6;
            this.DgvConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsulta_CellDoubleClick);
            // 
            // TxtNome_Consulta
            // 
            this.TxtNome_Consulta.Location = new System.Drawing.Point(86, 21);
            this.TxtNome_Consulta.Name = "TxtNome_Consulta";
            this.TxtNome_Consulta.Size = new System.Drawing.Size(257, 27);
            this.TxtNome_Consulta.TabIndex = 5;
            this.TxtNome_Consulta.TextChanged += new System.EventHandler(this.TxtNome_Consulta_TextChanged);
            // 
            // LblNome_Consulta
            // 
            this.LblNome_Consulta.AutoSize = true;
            this.LblNome_Consulta.Location = new System.Drawing.Point(6, 24);
            this.LblNome_Consulta.Name = "LblNome_Consulta";
            this.LblNome_Consulta.Size = new System.Drawing.Size(57, 20);
            this.LblNome_Consulta.TabIndex = 4;
            this.LblNome_Consulta.Text = "Nome :";
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Location = new System.Drawing.Point(12, 405);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(109, 33);
            this.BtnNovo.TabIndex = 1;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
            this.BtnCadastrar.Location = new System.Drawing.Point(127, 405);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(109, 33);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(242, 405);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(109, 33);
            this.BtnAtualizar.TabIndex = 3;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(357, 405);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(109, 33);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Location = new System.Drawing.Point(675, 405);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(109, 33);
            this.BtnMenu.TabIndex = 5;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // CRUD_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.TabCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.CadastroDeCliente_Load);
            this.TabCliente.ResumeLayout(false);
            this.TabDados.ResumeLayout(false);
            this.TabDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabConsulta.ResumeLayout(false);
            this.TabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCliente;
        private System.Windows.Forms.TabPage TabDados;
        private System.Windows.Forms.TabPage TabConsulta;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.TextBox TxtNumeroCasa;
        private System.Windows.Forms.Label LblNumeroCasa;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.Label LblLogradouro;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtNome_Consulta;
        private System.Windows.Forms.Label LblNome_Consulta;
        private System.Windows.Forms.DataGridView DgvConsulta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTituloEndereco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTituloCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtContato;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.MaskedTextBox TxtCEP;
        private System.Windows.Forms.Button BtnCEP;
        private System.Windows.Forms.Label AlertContato;
        private System.Windows.Forms.Label AlertNome;
        private System.Windows.Forms.Label AlertCpf;
        private System.Windows.Forms.Label AlertBairro;
        private System.Windows.Forms.Label AlertNumCasa;
        private System.Windows.Forms.Label AlertEndereco;
        private System.Windows.Forms.Button BtnValidarCPF;
        private System.Windows.Forms.Label AlertID;
    }
}