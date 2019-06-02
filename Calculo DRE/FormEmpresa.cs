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
    public partial class FormEmpresa : Form
    {
        public static FormEmpresa Empresa;
        public FormEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGridView gridform = new FormGridView();
            Empresa = this;
            gridform.Show();

        }
        public double[] analiseverticalresultadodaempresaDEZEMBRO()
        {
            double[] array = new double[13];
            double despesas = Convert.ToDouble(ALUGUEL.Text) + Convert.ToDouble(SALARIOS.Text) + Convert.ToDouble(luzaguatelefone.Text) + Convert.ToDouble(Impostederenda.Text) + Convert.ToDouble(contribuicaosocial.Text);
            array[0] = Convert.ToDouble(Vendas.Text) / Convert.ToDouble(Vendas.Text);
            array[1] = Convert.ToDouble(icmssemvendas.Text) / Convert.ToDouble(Vendas.Text);
            array[2] = Convert.ToDouble(Receitaliquida.Text) / Convert.ToDouble(Vendas.Text);
            array[3] = Convert.ToDouble(CMV.Text) / Convert.ToDouble(Vendas.Text);
            array[4] = Convert.ToDouble(LucroBruto.Text) / Convert.ToDouble(Vendas.Text);
            array[5] = despesas / Convert.ToDouble(Vendas.Text);
            array[6] = Convert.ToDouble(ALUGUEL.Text) / Convert.ToDouble(Vendas.Text);
            array[7] = Convert.ToDouble(SALARIOS.Text) / Convert.ToDouble(Vendas.Text);
            array[8] = Convert.ToDouble(luzaguatelefone.Text) / Convert.ToDouble(Vendas.Text);
            array[9] = Convert.ToDouble(LucroantesdoIR.Text) / Convert.ToDouble(Vendas.Text);
            array[10] = Convert.ToDouble(Impostederenda.Text) / Convert.ToDouble(Vendas.Text);
            array[11] = Convert.ToDouble(contribuicaosocial.Text) / Convert.ToDouble(Vendas.Text);
            array[12] = Convert.ToDouble(LucroOUPrejuizoAcumulado.Text) / Convert.ToDouble(Vendas.Text);
            return array;
        }
        public double[] analiseverticalresultadodaempresaJaneiro()
        {
            double[] array = new double[12];

            double despesas = Convert.ToDouble(aluguel2.Text) + Convert.ToDouble(salarios2.Text) + Convert.ToDouble(luzaguatelefone2.Text) + Convert.ToDouble(IR2.Text) + Convert.ToDouble(contribuicaosocial2.Text);

            array[0] = Convert.ToDouble(vendas2.Text) / Convert.ToDouble(vendas2.Text);
            array[1] = Convert.ToDouble(receitaliq2.Text) / Convert.ToDouble(vendas2.Text);
            array[2] = Convert.ToDouble(CMV2.Text) / Convert.ToDouble(vendas2.Text);
            array[3] = Convert.ToDouble(lucrobruto2.Text) / Convert.ToDouble(vendas2.Text);
            array[4] = despesas / Convert.ToDouble(vendas2.Text);
            array[5] = Convert.ToDouble(aluguel2.Text) / Convert.ToDouble(vendas2.Text);
            array[6] = Convert.ToDouble(salarios2.Text) / Convert.ToDouble(vendas2.Text);
            array[7] = Convert.ToDouble(luzaguatelefone2.Text) / Convert.ToDouble(vendas2.Text);
            array[8] = Convert.ToDouble(lucrosemIR2.Text) / Convert.ToDouble(vendas2.Text);
            array[9] = Convert.ToDouble(IR2.Text) / Convert.ToDouble(vendas2.Text);
            array[10] = Convert.ToDouble(contribuicaosocial2.Text) / Convert.ToDouble(vendas2.Text);
            array[11] = Convert.ToDouble(lucroouprejuizo2.Text) / Convert.ToDouble(vendas2.Text);
            return array;
        }
        public double[] AnaliseHorizontalresultadodaempresa()
        {
            double[] array = new double[13];
            double despesas = Convert.ToDouble(ALUGUEL.Text) + Convert.ToDouble(SALARIOS.Text) + Convert.ToDouble(luzaguatelefone.Text) + Convert.ToDouble(Impostederenda.Text) + Convert.ToDouble(contribuicaosocial.Text);
            double despesas1 = Convert.ToDouble(aluguel2.Text) + Convert.ToDouble(salarios2.Text) + Convert.ToDouble(luzaguatelefone2.Text) + Convert.ToDouble(IR2.Text) + Convert.ToDouble(contribuicaosocial2.Text);
            array[0] = ((Convert.ToDouble(vendas2.Text) / Convert.ToDouble(Vendas.Text)) - 1) * 100;
            array[1] = ((Convert.ToDouble(icmsobrevendas2.Text) / Convert.ToDouble(icmssemvendas.Text)) - 1) * 100;
            array[2] = ((Convert.ToDouble(receitaliq2.Text) / Convert.ToDouble(receita.Text)) - 1) * 100;
            array[3] = ((Convert.ToDouble(CMV2.Text) / Convert.ToDouble(CMV.Text)) - 1) * 100;
            array[4] = ((Convert.ToDouble(lucrobruto2.Text) / Convert.ToDouble(LucroBruto.Text)) - 1) * 100;
            array[5] = ((despesas1 / despesas) - 1) * 100;
            array[6] = ((Convert.ToDouble(aluguel2.Text) / Convert.ToDouble(ALUGUEL.Text)) - 1) * 100;
            array[7] = ((Convert.ToDouble(salarios2.Text) / Convert.ToDouble(SALARIOS.Text)) - 1) * 100;
            array[8] = ((Convert.ToDouble(luzaguatelefone2.Text) / Convert.ToDouble(luzaguatelefone.Text)) - 1) * 100;
            array[9] = ((Convert.ToDouble(lucrosemIR2.Text) / Convert.ToDouble(LucroantesdoIR.Text)) - 1) * 100;
            array[10] = ((Convert.ToDouble(IR2.Text) / Convert.ToDouble(Impostederenda.Text)) - 1) * 100;
            array[11] = ((Convert.ToDouble(contribuicaosocial2.Text) / Convert.ToDouble(contribuicaosocial.Text)) - 1) * 100;
            array[12] = ((Convert.ToDouble(lucroouprejuizo2.Text) / Convert.ToDouble(LucroOUPrejuizoAcumulado.Text)) - 1) * 100;
            return array;
        }
    }
}
