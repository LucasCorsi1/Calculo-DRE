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
        private void ColocarTudoNoGrid()
        {
            dataGridView.Rows.Add(11);
            try
            {
                dataGridView.Rows[0].Cells[0].Value = "Dez, Liquidez Imediata: " + FormDRE.DRE.LiquidezImediata();
                dataGridView.Rows[1].Cells[0].Value = "Dez, Liquidez Seca: " + FormDRE.DRE.Liquidezseca();
                dataGridView.Rows[2].Cells[0].Value = "Dez, Liquidez Corrente: " + FormDRE.DRE.LiquidezCorrente();
                dataGridView.Rows[3].Cells[0].Value = "Dez, Liquidez Geral: " + FormDRE.DRE.LiquidezGeral();
                dataGridView.Rows[4].Cells[0].Value = "Dez, Analisede Endividamento: " + FormDRE.DRE.AnalisedeEndividamento();
                dataGridView.Rows[5].Cells[0].Value = "Dez, Capital de 3°s em relação ao PL: " + FormDRE.DRE.Participacaodecapitaldeterceirosemrelacaoaopatromonioliquido();
                dataGridView.Rows[6].Cells[0].Value = "Dez, Capital de 3°s em relação ao Ativo: " + FormDRE.DRE.ParticipacaodecapitaldeterceirosemrelacaoaoATIVO();
                dataGridView.Rows[7].Cells[0].Value = "Dez, Garatia do Capital de 3°s: " + FormDRE.DRE.Garatiadocapitaldeterceiros();
                dataGridView.Rows[8].Cells[0].Value = "Dez, Grau de Solvencia: " + FormDRE.DRE.Graudesolvencia();
                dataGridView.Rows[9].Cells[0].Value = "Dez, Giro do Ativo: " + FormDRE.DRE.Girodoativo();
                dataGridView.Rows[10].Cells[0].Value = "Dez, Lucratividade: " + FormDRE.DRE.Lucratividade();
                dataGridView.Rows[11].Cells[0].Value = "Dez, Prazo Medio de Estoques: " + FormDRE.DRE.Prazomediodeestoques();
                dataGridView.Rows[12].Cells[0].Value = "Dez, Prazo Medio Estoques/Periodo: " + FormDRE.DRE.PrazomedioEstoquesPorperidodo();
            }
            catch
            {
                MessageBox.Show("Nope Dez","Error");
            }
            try
            {
                dataGridView.Rows[0].Cells[1].Value  = "Jan, Liquidez Imediata: " + FormDRE.DRE.LiquidezImediata2();
                dataGridView.Rows[1].Cells[1].Value  = "Jan, Liquidez Seca: " + FormDRE.DRE.Liquidezseca2();
                dataGridView.Rows[2].Cells[1].Value  = "Jan, Liquidez Corrente: " + FormDRE.DRE.LiquidezCorrente2();
                dataGridView.Rows[3].Cells[1].Value  = "Jan, Liquidez Geral: " + FormDRE.DRE.LiquidezGeral2();
                dataGridView.Rows[4].Cells[1].Value  = "Jan, Analisede Endividamento: " + FormDRE.DRE.AnalisedeEndividamento2();
                dataGridView.Rows[5].Cells[1].Value  = "Jan, Capital de 3°s em relação ao PL: " + FormDRE.DRE.Participacaodecapitaldeterceirosemrelacaoaopatromonioliquido2();
                dataGridView.Rows[6].Cells[1].Value  = "Jan, Capital de 3°s em relação ao Ativo: " + FormDRE.DRE.ParticipacaodecapitaldeterceirosemrelacaoaoATIVO2();
                dataGridView.Rows[7].Cells[1].Value  = "Jan, Garatia do Capital de 3°s: " + FormDRE.DRE.Garatiadocapitaldeterceiros2();
                dataGridView.Rows[8].Cells[1].Value  = "Jan, Grau de Solvencia: " + FormDRE.DRE.Graudesolvencia2();
                dataGridView.Rows[9].Cells[1].Value  = "Jan, Giro do Ativo: " + FormDRE.DRE.Girodoativo2();
                dataGridView.Rows[10].Cells[1].Value = "Jan, Lucratividade: " + FormDRE.DRE.Lucratividade2();
                dataGridView.Rows[11].Cells[1].Value = "Jan, Prazo Medio de Estoques: " + FormDRE.DRE.Prazomediodeestoques2();
                dataGridView.Rows[12].Cells[1].Value = "Jan, Prazo Medio Estoques/Periodo: " + FormDRE.DRE.PrazomedioEstoquesPorperidodo2();
            }
            catch
            {
                MessageBox.Show("Nope Jan", "Error");
            }
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalAtivoDEZEMBRO();
                 dataGridView.Rows[0].Cells[2].Value = "Ativo Circulante/AtivoTotal: " + array[0].ToString();
                 dataGridView.Rows[1].Cells[2].Value = "Caixa/Ativo Circ: " + array[1].ToString();
                 dataGridView.Rows[2].Cells[2].Value = "Bancos Com Movimento/Ativo Circ: " + array[2].ToString();
                 dataGridView.Rows[3].Cells[2].Value = "Estoque/Ativo Circ: " + array[3].ToString();
                 dataGridView.Rows[4].Cells[2].Value = "A Receber/Ativo Circ: " + array[4].ToString();
                 dataGridView.Rows[5].Cells[2].Value = "Imobilizado/Ativo Total: " + array[5].ToString();
                 dataGridView.Rows[6].Cells[2].Value = "Veiculos/Imobilizado: " + array[6].ToString();
                 dataGridView.Rows[7].Cells[2].Value = "Moveis/Imobilizado: " + array[7].ToString();
                 dataGridView.Rows[8].Cells[2].Value = "Instalações/Imobilizado: " + array[8].ToString();
                 dataGridView.Rows[9].Cells[2].Value = "Maquinas/Imobilizado: " + array[9].ToString();
                dataGridView.Rows[10].Cells[2].Value = "Computadores/Imobilizado: " + array[10].ToString();
            }
            catch
            {
                MessageBox.Show("Nope, Analise vertical Ativo Dezembro", "Error");
            }
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalAtivoJaneiro();
                 dataGridView.Rows[0].Cells[3].Value = "Ativo Circulante/AtivoTotal: " + array[0].ToString();
                 dataGridView.Rows[1].Cells[3].Value = "Caixa/Ativo Circ: " + array[1].ToString();
                 dataGridView.Rows[2].Cells[3].Value = "Bancos Com Movimento/Ativo Circ: " + array[2].ToString();
                 dataGridView.Rows[3].Cells[3].Value = "Estoque/Ativo Circ: " + array[3].ToString();
                 dataGridView.Rows[4].Cells[3].Value = "A Receber/Ativo Circ: " + array[4].ToString();
                 dataGridView.Rows[5].Cells[3].Value = "Imobilizado/Ativo Total: " + array[5].ToString();
                 dataGridView.Rows[6].Cells[3].Value = "Veiculos/Imobilizado: " + array[6].ToString();
                 dataGridView.Rows[7].Cells[3].Value = "Moveis/Imobilizado: " + array[7].ToString();
                 dataGridView.Rows[8].Cells[3].Value = "Instalações/Imobilizado: " + array[8].ToString();
                 dataGridView.Rows[9].Cells[3].Value = "Maquinas/Imobilizado: " + array[9].ToString();
                dataGridView.Rows[10].Cells[3].Value = "Computadores/Imobilizado: " + array[10].ToString();
            }
            catch
            {
                MessageBox.Show("Nope, Analise vertical Ativo Janeiro", "Error");
            }
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalPASSIVODEZEMBRO();
                dataGridView.Rows[0].Cells[4].Value = "Circulante: " + array[0].ToString();
                dataGridView.Rows[1].Cells[4].Value = "Salario a Pagar: " + array[1].ToString();
                dataGridView.Rows[2].Cells[4].Value = "Fornecedores: " + array[2].ToString();
                dataGridView.Rows[3].Cells[4].Value = "Contas a Pagar:" + array[3].ToString();
                dataGridView.Rows[4].Cells[4].Value = "Financiamento: " + array[4].ToString();
                dataGridView.Rows[5].Cells[4].Value = "Não Circulante: " + array[5].ToString();
                dataGridView.Rows[6].Cells[4].Value = "Patromonio Liq: " + array[6].ToString();
                dataGridView.Rows[7].Cells[4].Value = "Capital Social: " + array[7].ToString();
                dataGridView.Rows[8].Cells[4].Value = "Lucro: " + array[8].ToString();
            }
            catch
            {
                MessageBox.Show("Nope, Analise vertical Passivo Dezembro", "Error");
            }
            //Não terminei
            /*
            try
            {
                double[] array = FormDRE.DRE.AnaliseverticalPASSIVOJaneiro();
                 dataGridView.Rows[0].Cells[5].Value = "Ativo Circulante/AtivoTotal: " + array[0].ToString();
                 dataGridView.Rows[1].Cells[5].Value = "Caixa/Ativo Circ: " + array[1].ToString();
                 dataGridView.Rows[2].Cells[5].Value = "Bancos Com Movimento/Ativo Circ: " + array[2].ToString();
                 dataGridView.Rows[3].Cells[5].Value = "Estoque/Ativo Circ: " + array[3].ToString();
                 dataGridView.Rows[4].Cells[5].Value = "A Receber/Ativo Circ: " + array[4].ToString();
                 dataGridView.Rows[5].Cells[5].Value = "Imobilizado/Ativo Total: " + array[5].ToString();
                 dataGridView.Rows[6].Cells[5].Value = "Veiculos/Imobilizado: " + array[6].ToString();
                 dataGridView.Rows[7].Cells[5].Value = "Moveis/Imobilizado: " + array[7].ToString();
                 dataGridView.Rows[8].Cells[5].Value = "Instalações/Imobilizado: " + array[8].ToString();
                 dataGridView.Rows[9].Cells[5].Value = "Maquinas/Imobilizado: " + array[9].ToString();
                dataGridView.Rows[10].Cells[5].Value = "Computadores/Imobilizado: " + array[10].ToString();
            }
            catch
            {
                MessageBox.Show("Nope, Analise vertical Ativo Dezembro", "Error");
            }
            */

        }
    }
}
