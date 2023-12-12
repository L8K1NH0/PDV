using SistemaPdv.DAO;
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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
            
            RelatorioDAO dao = new RelatorioDAO();
            string data = DateTime.Now.ToString("yyyy-MM-dd");
            string dataFluxo = DateTime.Now.ToString("yyyy-MM-dd");


            DTP1.Value = DateTime.Today;
            DTP2.Value = DateTime.Today;

            DgvProdutos.DataSource = dao.ListarProdutos(data, data);
            DgvValores.DataSource = dao.ListarValores(data, data);
            DgvFluxo.DataSource = dao.ListarFluxo(dataFluxo, dataFluxo);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.Show();
            this.Hide();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            RelatorioDAO dao = new RelatorioDAO();
            string dataAntigaFluxo = DTP1.Value.ToString("yyyy-MM-dd");
            string dataRecenteFluxo = DTP2.Value.ToString("yyyy-MM-dd");

            string dataRecente = DTP1.Value.ToString("yyyy-MM-dd");
            string dataAntiga = DTP2.Value.ToString("yyyy-MM-dd");

            DgvProdutos.DataSource = dao.ListarProdutos(dataAntiga, dataRecente);
            DgvValores.DataSource = dao.ListarValores(dataAntiga, dataRecente);
            DgvFluxo.DataSource = dao.ListarFluxo(dataAntigaFluxo, dataRecenteFluxo);
        }
    }
}
