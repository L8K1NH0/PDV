using SistemaPdv.DAO;
using SistemaPdv.LogicaNegocio;
using SistemaPdv.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPdv.View
{
    public partial class CRUD_Cliente : Form
    {
        //Estanciar funções do arquivo ClienteDAO
        FornecedorDAO dao = new FornecedorDAO();

        public CRUD_Cliente()
        {
            InitializeComponent();
        }

        private void CadastroDeCliente_Load(object sender, EventArgs e)
        {
            DgvConsulta.DataSource = dao.ListarFornecedor();
        }

        public void AlertOFF()
        {
            AlertContato.Visible = false;
            AlertBairro.Visible = false;
            AlertCnpj.Visible = false;
            AlertEndereco.Visible = false;
            AlertID.Visible = false;
            AlertNome.Visible = false;
            AlertNumEstabelecimento.Visible = false;
        }

        public void AlertON()
        {
            AlertNome.Visible = true;
            AlertContato.Visible = true;
            AlertEndereco.Visible = true;
            AlertBairro.Visible = true;
            AlertNumEstabelecimento.Visible = true;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Estanciar objetos do cliente
            FornecedorModel obj = new FornecedorModel();

            string cel = TxtContato.Text;
            //Retirando caracteres especias para verificar numero de telefone
            cel = cel.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (TxtNome.Text == string.Empty || cel == string.Empty || TxtLogradouro.Text == string.Empty || TxtBairro.Text == string.Empty || TxtNumeroEstabelecimento.TextLength == 0)
            {
                Erro customErro = new Erro("Verifique os campos obrigatorios.");
                customErro.ShowDialog();

                AlertNome.Visible = true;
                AlertContato.Visible = true;
                AlertEndereco.Visible = true;
                AlertBairro.Visible = true;
                AlertNumEstabelecimento.Visible = true;
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
                        obj.Numero = int.Parse(TxtNumeroEstabelecimento.Text);
                        obj.Email = TxtEmail.Text;
                        obj.Contato = TxtContato.Text;
                        obj.CNPJ = TxtCNPJ.Text;

                        dao.CadastrarFornecedor(obj);

                        //Limpar toda a pagina
                        Clear.ClearControl(this);

                        //Atualizar Dgv
                        DgvConsulta.DataSource = dao.ListarFornecedor();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show($"Confira os dados. \nERRO:{erro}");
                    }
                }
            }
            //Atualizar Dgv
            DgvConsulta.DataSource = dao.ListarFornecedor();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            //Limpar toda a pagina
            Clear.ClearControl(this);

            DgvConsulta.DataSource = dao.ListarFornecedor();

            AlertOFF();

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            //Estanciar objetos do cliente
            FornecedorModel obj = new FornecedorModel();

            string cel = TxtContato.Text;
            //Retirando caracteres especias para verificar numero de telefone
            cel = cel.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

            if (TxtNome.Text == string.Empty || cel == string.Empty || TxtLogradouro.Text == string.Empty || TxtBairro.Text == string.Empty || TxtNumeroEstabelecimento.TextLength == 0)
            {
                Erro customErro = new Erro("Verifique os campos obrigatorios.");
                customErro.ShowDialog();

                AlertNome.Visible = true;
                AlertContato.Visible = true;
                AlertEndereco.Visible = true;
                AlertBairro.Visible = true;
                AlertNumEstabelecimento.Visible = true;
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
                        obj.Id = int.Parse(TxtId.Text);
                        obj.Nome = TxtNome.Text;
                        obj.Logradouro = TxtLogradouro.Text;
                        obj.Bairro = TxtBairro.Text;
                        obj.Cidade = TxtCidade.Text;
                        obj.Numero = int.Parse(TxtNumeroEstabelecimento.Text);
                        obj.Email = TxtEmail.Text;
                        obj.Contato = TxtContato.Text;
                        obj.CNPJ = TxtCNPJ.Text;

                        dao.AlterarFornecedor(obj);

                        //Atualizar Dgv
                        DgvConsulta.DataSource = dao.ListarFornecedor();

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
                        AlertNumEstabelecimento.Visible = true;
                    }
                }
            }
            //Atualizar Dgv
            DgvConsulta.DataSource = dao.ListarFornecedor();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Estanciar objetos do cliente
            FornecedorModel obj = new FornecedorModel();

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM APAGAR O ITEM?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    obj.Id = int.Parse(TxtId.Text);

                    dao.ExcluirFornecedor(obj);

                    //Limpar toda a pagina
                    Clear.ClearControl(this);

                    //Atualizar Dgv
                    DgvConsulta.DataSource = dao.ListarFornecedor();
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
                TxtNumeroEstabelecimento.Text = DgvConsulta.CurrentRow.Cells[5].Value.ToString();
                TxtEmail.Text = DgvConsulta.CurrentRow.Cells[6].Value.ToString();
                TxtContato.Text = DgvConsulta.CurrentRow.Cells[7].Value.ToString();
                TxtCNPJ.Text = DgvConsulta.CurrentRow.Cells[8].Value.ToString();

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

            DgvConsulta.DataSource = dao.ListarFornecedorNome(nome);
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
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void LblContato_Click(object sender, EventArgs e)
        {

        }

        private void BtnValidarCPF_Click(object sender, EventArgs e)
        {
            bool res;

            try
            {
                res = ValidarCNPJ.IsCnpj(TxtCNPJ.Text);
            }
            catch (Exception)
            {

                throw;
            }
            

            if (res == true)
            {
                AlertCnpj.Visible = false;
            }
            else
            {
                AlertCnpj.Visible = true;
            }
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

        private void TxtNumeroEstabelecimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
    }
}
