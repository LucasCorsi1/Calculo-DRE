using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_DRE
{
    public partial class FormGridView : Form
    {
        public FormGridView()
        {
            InitializeComponent();
            ColocarTudoNoGrid();
        }
        FormEmpresa Empresa = new FormEmpresa();
        private void ColocarTudoNoGrid()
        {
            dataGridView.Rows.Add(12);
            //Indices Atv Dez
            try
            {
                dataGridView.Rows[0].Cells[0].Value = "Liquidez Imediata: " + FormDRE.DRE.LiquidezImediata().ToString("N1");
                dataGridView.Rows[1].Cells[0].Value = "Liquidez Seca: " + FormDRE.DRE.Liquidezseca().ToString("N1") ;
                dataGridView.Rows[2].Cells[0].Value = "Liquidez Corrente: " + FormDRE.DRE.LiquidezCorrente().ToString("N1");
                dataGridView.Rows[3].Cells[0].Value = "Liquidez Geral: " + FormDRE.DRE.LiquidezGeral().ToString("N1");
                dataGridView.Rows[4].Cells[0].Value = "Analisede Endividamento: " + FormDRE.DRE.AnalisedeEndividamento().ToString("N1");
                dataGridView.Rows[5].Cells[0].Value = "Capital de 3°s em relação ao PL: " + FormDRE.DRE.Participacaodecapitaldeterceirosemrelacaoaopatromonioliquido().ToString("N1");
                dataGridView.Rows[6].Cells[0].Value = "Capital de 3°s em relação ao Ativo: " + FormDRE.DRE.ParticipacaodecapitaldeterceirosemrelacaoaoATIVO().ToString("N1");
                dataGridView.Rows[7].Cells[0].Value = "Garatia do Capital de 3°s: " + FormDRE.DRE.Garatiadocapitaldeterceiros().ToString("N1");
                dataGridView.Rows[8].Cells[0].Value = "Grau de Solvencia: " + FormDRE.DRE.Graudesolvencia().ToString("N1");
                dataGridView.Rows[9].Cells[0].Value = "Giro do Ativo: " + FormDRE.DRE.Girodoativo().ToString("N3");
                dataGridView.Rows[10].Cells[0].Value = "Lucratividade: " + FormDRE.DRE.Lucratividade().ToString("N3");
                dataGridView.Rows[11].Cells[0].Value = "Prazo Medio de Estoques: " + FormDRE.DRE.Prazomediodeestoques().ToString("N1");
                
            }
            catch
            {
            }
            //Indices Atv Jan
            try
            {
                dataGridView.Rows[0].Cells[1].Value = "Liquidez Imediata: " + FormDRE.DRE.LiquidezImediata2().ToString("N1");
                dataGridView.Rows[1].Cells[1].Value = "Liquidez Seca: " + FormDRE.DRE.Liquidezseca2().ToString("N1");
                dataGridView.Rows[2].Cells[1].Value = "Liquidez Corrente: " + FormDRE.DRE.LiquidezCorrente2().ToString("N1");
                dataGridView.Rows[3].Cells[1].Value = "Liquidez Geral: " + FormDRE.DRE.LiquidezGeral2().ToString("N1");
                dataGridView.Rows[4].Cells[1].Value = "Analisede Endividamento: " + FormDRE.DRE.AnalisedeEndividamento2().ToString("N1");
                dataGridView.Rows[5].Cells[1].Value = "Capital de 3°s em relação ao PL: " + FormDRE.DRE.Participacaodecapitaldeterceirosemrelacaoaopatromonioliquido2().ToString("N1");
                dataGridView.Rows[6].Cells[1].Value = "Capital de 3°s em relação ao Ativo: " + FormDRE.DRE.ParticipacaodecapitaldeterceirosemrelacaoaoATIVO2().ToString("N1");
                dataGridView.Rows[7].Cells[1].Value = "Garatia do Capital de 3°s: " + FormDRE.DRE.Garatiadocapitaldeterceiros2().ToString("N1");
                dataGridView.Rows[8].Cells[1].Value = "Grau de Solvencia: " + FormDRE.DRE.Graudesolvencia2().ToString("N1");
                dataGridView.Rows[9].Cells[1].Value = "Giro do Ativo: " + FormDRE.DRE.Girodoativo2().ToString("N3");
                dataGridView.Rows[10].Cells[1].Value = "Lucratividade: " + FormDRE.DRE.Lucratividade2().ToString("N3");
                dataGridView.Rows[11].Cells[1].Value = "Prazo Medio de Estoques: " + FormDRE.DRE.Prazomediodeestoques2().ToString("N1");
            }
            catch
            {

            }
            //Analise vertical Ativo DEZEMBRO
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalAtivoDEZEMBRO();

                dataGridView.Rows[0].Cells[2].Value = "Ativo Circulante/AtivoTotal: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[2].Value = "Caixa/Ativo Circ: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[2].Value = "Bancos Com Movimento/Ativo Circ: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[2].Value = "Estoque/Ativo Circ: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[2].Value = "A Receber/Ativo Circ: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[2].Value = "Imobilizado/Ativo Total: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[2].Value = "Veiculos/Imobilizado: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[2].Value = "Moveis/Imobilizado: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[2].Value = "Instalações/Imobilizado: " + array[8].ToString("N1");
                dataGridView.Rows[9].Cells[2].Value = "Maquinas/Imobilizado: " + array[9].ToString("N1");
                dataGridView.Rows[10].Cells[2].Value = "Computadores/Imobilizado: " + array[10].ToString("N1");
            }
            catch
            {

            }
            //Analise vertical Ativo Janeiro
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalAtivoJaneiro();
                dataGridView.Rows[0].Cells[3].Value = "Ativo Circulante/AtivoTotal: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[3].Value = "Caixa/Ativo Circ: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[3].Value = "Bancos Com Movimento/Ativo Circ: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[3].Value = "Estoque/Ativo Circ: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[3].Value = "A Receber/Ativo Circ: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[3].Value = "Imobilizado/Ativo Total: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[3].Value = "Veiculos/Imobilizado: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[3].Value = "Moveis/Imobilizado: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[3].Value = "Instalações/Imobilizado: " + array[8].ToString("N1");
                dataGridView.Rows[9].Cells[3].Value = "Maquinas/Imobilizado: " + array[9].ToString("N1");
                dataGridView.Rows[10].Cells[3].Value = "Computadores/Imobilizado: " + array[10].ToString("N1");
            }
            catch
            {

            }
            //Analise vertical PASSIVO DEZEMBRO
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalPASSIVODEZEMBRO();
                dataGridView.Rows[0].Cells[4].Value = "Circulante/Total: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[4].Value = "Salarios Encargo/Circulante: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[4].Value = "Fornecedores/Circulante: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[4].Value = "Contas A Pagar/Circulante: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[4].Value = "Financiamento/Circulante: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[4].Value = "Não Circulante/Total: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[4].Value = "Patromnio Liquido/Total: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[4].Value = "Capital Social/Patromnio Liquido: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[4].Value = "Lucro ou Preguizo/Patromnio Liquido: " + array[8].ToString("N1");
            }
            catch
            {

            }
            //Analise vertical PASSIVO Janeiro
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalPASSIVOJaneiro();
                dataGridView.Rows[0].Cells[5].Value = "Circulante/Total: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[5].Value = "Salarios Encargo/Circulante: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[5].Value = "Fornecedores/Circulante: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[5].Value = "Contas A Pagar/Circulante: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[5].Value = "Financiamento/Circulante: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[5].Value = "Não Circulante/Total: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[5].Value = "Patromnio Liquido/Total: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[5].Value = "Capital Social/Patromnio Liquido: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[5].Value = "Lucro ou Preguizo/Patromnio Liquido: " + array[8].ToString("N1");
            }
            catch
            {

            }
            //Analise Horizonta ATIVO DEZEMBRO E Janeiro
            try
            {
                double[] array = FormDRE.DRE.AnaliseHorizontaATIVOlDEZEMBROEJaneiro();
                dataGridView.Rows[0].Cells[6].Value = "AtivoCirculante: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[6].Value = "Caixa: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[6].Value = "BancosCMovimento: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[6].Value = "Estoque: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[6].Value = "Contasareceber: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[6].Value = "AtivoImobilizado: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[6].Value = "Veiculos: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[6].Value = "Moveis: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[6].Value = "Instalacoes: " + array[8].ToString("N1");
                dataGridView.Rows[9].Cells[6].Value = "Maquinas: " + array[9].ToString("N1");
                dataGridView.Rows[10].Cells[6].Value = "Computadores: " + array[10].ToString("N1");
            }
            catch
            {

            }
            //Analise Horizonta Passivo DEZEMBRO E Janeiro
            try
            {
                double[] array = FormDRE.DRE.AnaliseHorizontaPassivolDEZEMBROEJaneiro();
                dataGridView.Rows[0].Cells[10].Value = "Circulante: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[10].Value = "Salarios Encargos: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[10].Value = "Fornecedores: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[10].Value = "Contas Apagar: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[10].Value = "Financiamento: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[10].Value = "Não Circulante: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[10].Value = "Patrimonio Liquido: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[10].Value = "Capital Social: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[10].Value = "Lucro Ou Prejuizo: " + array[8].ToString("N1");
            }
            catch
            {

            }
            //Analise Vertical resultado da empresa DEZEMBRO
            try
            {
                double[] array = Empresa.analiseverticalresultadodaempresaDEZEMBRO();
                dataGridView.Rows[0].Cells[8].Value = "Vendas: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[8].Value = "ICMS Sem Vendas: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[8].Value = "Receita Líquida: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[8].Value = "CMV: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[8].Value = "Lucro Bruto: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[8].Value = "Despesas: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[8].Value = "Aluguel: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[8].Value = "Salarios: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[8].Value = "Luz/Agua/Telefone: " + array[8].ToString("N1");
                dataGridView.Rows[9].Cells[8].Value = "Lucro Antes do IR: " + array[9].ToString("N1");
                dataGridView.Rows[10].Cells[8].Value = "Imposte De Renda: " + array[10].ToString("N1");
                dataGridView.Rows[11].Cells[8].Value = "Contribuição Social: " + array[11].ToString("N1");
                dataGridView.Rows[12].Cells[8].Value = "Lucro Ou Prejuizo Acumulado: " + array[12].ToString("N1");
            }
            catch
            {

            }
            //Analise Vertical resultado da empresa JANEIRO
            try
            {
                double[] array = Empresa.analiseverticalresultadodaempresaJaneiro();
                dataGridView.Rows[0].Cells[9].Value = "Vendas: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[9].Value = "Receita Líquida: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[9].Value = "CMV: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[9].Value = "Lucro Bruto: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[9].Value = "Despesas: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[9].Value = "Aluguel: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[9].Value = "Salarios: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[9].Value = "Luz/Agua/Telefone: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[9].Value = "Lucro Antes do IR: " + array[8].ToString("N1");
                dataGridView.Rows[9].Cells[9].Value = "Imposto De Renda: " + array[9].ToString("N1");
                dataGridView.Rows[10].Cells[9].Value = "Contribuição Social: " + array[10].ToString("N1");
                dataGridView.Rows[11].Cells[9].Value = "Lucro Ou Prejuizo: " + array[11].ToString("N1");
            }
            catch
            {

            }
            //Analise Vertical resultado da empresa
            try
            {
                double[] array = Empresa.AnaliseHorizontalresultadodaempresa();

                dataGridView.Rows[0].Cells[7].Value = "Vendas: " + array[0].ToString("N1");
                dataGridView.Rows[1].Cells[7].Value = "ICMS Sem Vendas: " + array[1].ToString("N1");
                dataGridView.Rows[2].Cells[7].Value = "Receita Líquida: " + array[2].ToString("N1");
                dataGridView.Rows[3].Cells[7].Value = "CMV: " + array[3].ToString("N1");
                dataGridView.Rows[4].Cells[7].Value = "Lucro Bruto: " + array[4].ToString("N1");
                dataGridView.Rows[5].Cells[7].Value = "Despesas: " + array[5].ToString("N1");
                dataGridView.Rows[6].Cells[7].Value = "Aluguel: " + array[6].ToString("N1");
                dataGridView.Rows[7].Cells[7].Value = "Salarios: " + array[7].ToString("N1");
                dataGridView.Rows[8].Cells[7].Value = "Luz/Agua/Telefone: " + array[8].ToString("N1");
                dataGridView.Rows[9].Cells[7].Value = "Lucro Antes do IR: " + array[9].ToString("N1");
                dataGridView.Rows[10].Cells[7].Value = "Imposto De Renda: " + array[10].ToString("N1");
                dataGridView.Rows[11].Cells[7].Value = "Contribuição Social: " + array[11].ToString("N1");
                dataGridView.Rows[12].Cells[7].Value = "Lucro Ou Prejuizo Acumulado: " + array[12].ToString("N1");
            }
            catch
            {

            }
        }

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        private void buttonexcel_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    }

                    //
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch
                {
                    XcelApp.Quit();
                }
            }
        }
    }
}
