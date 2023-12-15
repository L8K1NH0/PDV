using SistemaPdv.DAO;
using SistemaPdv.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPdv.LogicaNegocio;

namespace SistemaPdv.View
{
    public partial class CRUD_Fornecedor : Form
    {
        //Estanciar funções do arquivo ClienteDAO
        ClienteDAO dao = new ClienteDAO();

        public CRUD_Fornecedor()
        {
            InitializeComponent();
        }

        private void CadastroDeCliente_Load(object sender, EventArgs e)
        {
            DgvConsulta.DataSource = dao.ListarCliente();
        }

        public void AlertOFF()
        {
            AlertContato.Visible = false;
            AlertBairro.Visible = false;
            AlertCpf.Visible = false;
            AlertEndereco.Visible = false;
            AlertID.Visible = false;
            AlertNome.Visible = false;
            AlertNumCasa.Visible = false;
        }

        public void AlertON()
        {
            AlertNome.Visible = true;
            AlertContato.Visible = true;
            AlertEndereco.Visible = true;
            AlertBairro.Visible = true;
            AlertNumCasa.Visible = true;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Estanciar objetos do cliente
            ClienteModel obj = new ClienteModel();

            string cel = TxtContato.Text;
            //Retirando caracteres especias para verificar numero de telefone
            cel = cel.Replace("(", "").Replace(")", "").Replace("-","").Replace(" ","");

            if(TxtNome.Text == string.Empty || cel == string.Empty || TxtLogradouro.Text == string.Empty || TxtBairro.Text == string.Empty || TxtNumeroCasa.TextLength == 0)
            {
                Erro customErro = new Erro("Todas as caixas devem ser preenchidas.");
                customErro.ShowDialog();

                AlertON();
            }
            else
            {
                if(cel.Length != 11)
                {
                    MessageBox.Show("Número de contato incompleto.");
                }
                else
                {
                    try
                    {
                        //Passando obj
                        obj.Nome = TxtNome.Text;
                        obj.Logradouro = TxtLogradouro.Text;
                        obj.Bairro = TxtBairro.Text;
                        obj.Cidade = TxtCidade.Text;
                        obj.NumeroCasa = int.Parse(TxtNumeroCasa.Text);
                        obj.Email = TxtEmail.Text;
                        obj.Contato = TxtContato.Text;
                        obj.CPF = TxtCPF.Text;

                        dao.CadastrarCliente(obj);

                        //Atualizar Dgv
                        DgvConsulta.DataSource = dao.ListarCliente();
                        Clear.ClearControl(this);

                        // ------------------------- SUBSTITUIR POR UMA FUNÇÃO -------------------------
                        TxtEmail.Text = string.Empty;
                        TxtContato.Text = string.Empty;
                        TxtCPF.Text = string.Empty;
                        TxtCEP.Text = string.Empty;
                        TxtLogradouro.Text = string.Empty;

                    }
                    catch (Exception)
                    {
                        Erro customErro = new Erro("Todas as caixas devem ser preenchidas.");
                        customErro.ShowDialog();
                    }
                }
            }
            //Atualizar Dgv
            DgvConsulta.DataSource = dao.ListarCliente();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);

            // ------------------------- SUBSTITUIR POR UMA FUNÇÃO -------------------------
            TxtEmail.Text = string.Empty;
            TxtContato.Text = string.Empty;
            TxtCPF.Text = string.Empty;
            TxtCEP.Text = string.Empty;
            TxtLogradouro.Text = string.Empty;

            DgvConsulta.DataSource = dao.ListarCliente();
            AlertOFF();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            //Estanciar objetos do cliente
            ClienteModel obj = new ClienteModel();

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM ALTERAR O CLIENTE?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                string cel = TxtContato.Text;
                //Retirando caracteres especias para verificar numero de telefone
                cel = cel.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

                if (TxtNome.Text == string.Empty || cel == string.Empty || TxtLogradouro.Text == string.Empty || TxtBairro.Text == string.Empty || TxtNumeroCasa.TextLength == 0)
                {
                    Erro customErro = new Erro("Todas as caixas devem ser preenchidas.");
                    customErro.ShowDialog();

                    AlertON();
                }
                else
                {
                    if (cel.Length != 11)
                    {
                        MessageBox.Show("Número de contato incompleto.");
                    }
                    else
                    {
                        try
                        {
                            //Passando obj
                            obj.Id = int.Parse(TxtId.Text);
                            obj.Nome = TxtNome.Text;
                            obj.Logradouro = TxtLogradouro.Text;
                            obj.Bairro = TxtBairro.Text;
                            obj.Cidade = TxtCidade.Text;
                            obj.NumeroCasa = int.Parse(TxtNumeroCasa.Text);
                            obj.Email = TxtEmail.Text;
                            obj.Contato = TxtContato.Text;
                            obj.CPF = TxtCPF.Text;

                            dao.AlterarCliente(obj);

                            //Atualizar Dgv
                            DgvConsulta.DataSource = dao.ListarCliente();



                        }
                        catch (Exception)
                        {
                            Erro customErro = new Erro("Verifique os campos obrigatorios.");
                            customErro.ShowDialog();

                            AlertID.Visible = true;
                            AlertNome.Visible = true;
                            AlertContato.Visible = true;
                            AlertEndereco.Visible = true;
                            AlertBairro.Visible = true;
                            AlertNumCasa.Visible = true;
                        }
                    }
                }
                //Atualizar Dgv
                DgvConsulta.DataSource = dao.ListarCliente();
            }

            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Estanciar objetos do cliente
            ClienteModel obj = new ClienteModel();

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM APAGAR O CLIENTE?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    obj.Id = int.Parse(TxtId.Text);

                    dao.ExcluirCliente(obj);

                    //Atualizar Dgv
                    DgvConsulta.DataSource = dao.ListarCliente();

                    Clear.ClearControl(this);

                    // ------------------------- SUBSTITUIR POR UMA FUNÇÃO -------------------------
                    TxtEmail.Text = string.Empty;
                    TxtContato.Text = string.Empty;
                    TxtCPF.Text = string.Empty;
                    TxtCEP.Text = string.Empty;
                    TxtLogradouro.Text = string.Empty;
                }
                catch (Exception)
                {
                    Erro customErro = new Erro("Verifique os campos obrigatorios.");
                    customErro.ShowDialog();

                    AlertID.Visible = true;
                }
            }
        }

        private void DgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pegar dados selecionados
                TxtId.Text = DgvConsulta.CurrentRow.Cells[0].Value.ToString();
                TxtNome.Text = DgvConsulta.CurrentRow.Cells[1].Value.ToString();
                TxtLogradouro.Text = DgvConsulta.CurrentRow.Cells[2].Value.ToString();
                TxtBairro.Text = DgvConsulta.CurrentRow.Cells[3].Value.ToString();
                TxtCidade.Text = DgvConsulta.CurrentRow.Cells[4].Value.ToString();
                TxtNumeroCasa.Text = DgvConsulta.CurrentRow.Cells[5].Value.ToString();
                TxtEmail.Text = DgvConsulta.CurrentRow.Cells[6].Value.ToString();
                TxtContato.Text = DgvConsulta.CurrentRow.Cells[7].Value.ToString();
                TxtCPF.Text = DgvConsulta.CurrentRow.Cells[8].Value.ToString();

                //Alterar a guia 
                TabCliente.SelectedTab = TabDados;
            }
            catch (Exception)
            {
                throw;  //Não ha necessidade de um retorno ao usuario
            }
            
        }

        private void TxtNome_Consulta_TextChanged(object sender, EventArgs e)
        {
            string nome = TxtNome_Consulta.Text;

            DgvConsulta.DataSource = dao.ListarClienteNome(nome);
        }

        private void LblLogradouro_Click(object sender, EventArgs e)
        {

        }

        private void LblBairro_Click(object sender, EventArgs e)
        {

        }

        private void LblCidade_Click(object sender, EventArgs e)
        {

        }

        private void LblNumeroCasa_Click(object sender, EventArgs e)
        {

        }

        private void TxtNumeroCasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //Principal principal = new Principal();
            //principal.Show();
            this.Hide();
        }

        private void LblTituloEndereco_Click(object sender, EventArgs e)
        {

        }

        private void BtnCEP_Click(object sender, EventArgs e)
        {
            //Botão pesquisar CEP
            try
            {
                string cep = TxtCEP.Text;
                string xml = $"https://viacep.com.br/ws/{cep}/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                TxtLogradouro.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                TxtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                //TxtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                TxtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, digite o endereço manualmente");
            }
        }

        private void TxtCPF_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool res;

            try
            {
                res = ValidarCPF.IsCpf(TxtCPF.Text);
            }
            catch (Exception)
            {
                throw;
            }
            

            if (res == true)
            {
                AlertCpf.Visible = false;
            }
            else
            {
                AlertCpf.Visible = true;
            }
        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }        
    }
}
