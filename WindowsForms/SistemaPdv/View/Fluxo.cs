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

namespace SistemaPdv.View
{
    public partial class Fluxo : Form
    {
        public Fluxo()
        {
            InitializeComponent();

            RelatorioDAO dao = new RelatorioDAO();
            string data = DateTime.Now.ToString("yyyy-MM-dd");

            DgvValores.DataSource = dao.ListarValores(data,data);

            DtpAbrir.Value = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            DtpFechar.Value = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            TxtSaldoInicial.Text = dao.ValorInicial().ToString();
            TxtSaldoFinal.Text = dao.ValorFinal().ToString();

            if (dao.VerificarCaixaOpen())
            {
                TxtSaldoInicial.Enabled = false;
            }
            else
            {
                TxtSaldoInicial.Enabled=true;
            }

            if (dao.VerificarCaixaClose())
            {
                TxtSaldoFinal.Enabled = false;
            }
            else
            {
                TxtSaldoFinal.Enabled = true;
            }

            decimal pix = decimal.Parse(DgvValores.Rows[0].Cells[0].Value.ToString());
            decimal din = decimal.Parse(DgvValores.Rows[0].Cells[1].Value.ToString());
            decimal deb = decimal.Parse(DgvValores.Rows[0].Cells[2].Value.ToString());
            decimal cred = decimal.Parse(DgvValores.Rows[0].Cells[3].Value.ToString());

            decimal total = pix + din + deb + cred;

            TxtValorFinalAuto.Text = total.ToString("F");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            RelatorioDAO dao = new RelatorioDAO();
            FluxoModel obj = new FluxoModel();

            if (dao.VerificarCaixaOpen())
            {
                MessageBox.Show("O caixa ja foi aberto.");
            }
            else
            {
                obj.SaldoInicial = float.Parse(TxtSaldoInicial.Text);
                obj.DataOpen = DtpAbrir.Value;

                dao.AbrirCaixa(obj);
            }            
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            RelatorioDAO dao = new RelatorioDAO();
            FluxoModel obj = new FluxoModel();

            if (dao.VerificarCaixaClose())
            {
                obj.SaldoFinal = float.Parse(TxtSaldoFinal.Text);
                obj.DataClose = DtpFechar.Value;
                obj.Id = dao.UltimoIdFluxo();

                dao.FecharCaixa(obj);
            }
            else
            {
                MessageBox.Show("O caixa ja foi fechado.");
            }            
        }

        private void TxtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void TxtSaldoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.Show();
            this.Hide();
        }
    }
}
