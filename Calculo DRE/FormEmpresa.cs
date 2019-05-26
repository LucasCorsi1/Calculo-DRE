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
        public FormEmpresa()
        {
            InitializeComponent();
        }

        FormGridView gridform = new FormGridView();
        private void button1_Click(object sender, EventArgs e)
        {
            gridform.Show();
        }


        private void analiseverticalresultadodaempresaDEZEMBRO()
        {
            // enumerado em ordem alfabetica

            double a = Convert.ToDouble(Vendas.Text) / Convert.ToDouble(Vendas.Text);
            ////
            double b = Convert.ToDouble(icmssemvendas.Text) / Convert.ToDouble(Vendas.Text);
            double c = Convert.ToDouble(Receitaliquida.Text) / Convert.ToDouble(Vendas.Text);

            double d = Convert.ToDouble(CMV.Text) / Convert.ToDouble(Vendas.Text);
            double e = Convert.ToDouble(LucroBruto.Text) / Convert.ToDouble(Vendas.Text);

            //////
            double f = Convert.ToDouble(DESPESAS.Text) / Convert.ToDouble(Vendas.Text);
            //////
            double h = Convert.ToDouble(ALUGUEL.Text) / Convert.ToDouble(Vendas.Text);

            double i = Convert.ToDouble(SALARIOS.Text) / Convert.ToDouble(Vendas.Text);
            double j = Convert.ToDouble(luzaguatelefone.Text) / Convert.ToDouble(Vendas.Text);

            double kf = Convert.ToDouble(LucroantesdoIR.Text) / Convert.ToDouble(Vendas.Text);

            double l = Convert.ToDouble(Impostederenda.Text) / Convert.ToDouble(Vendas.Text);

            double m = Convert.ToDouble(contribuicaosocial.Text) / Convert.ToDouble(Vendas.Text);
            double n = Convert.ToDouble(LucroOUPrejuizoAcumulado.Text) / Convert.ToDouble(Vendas.Text);



        }



        private void analiseverticalresultadodaempresaJaneiro()
        {
            double a = Convert.ToDouble(vendas2.Text) / Convert.ToDouble(vendas2.Text);
            ////
            double b = Convert.ToDouble(icmsobrevendas2.Text) / Convert.ToDouble(vendas2.Text);
            double c = Convert.ToDouble(receitaliq2.Text) / Convert.ToDouble(vendas2.Text);

            double d = Convert.ToDouble(CMV2.Text) / Convert.ToDouble(vendas2.Text);
            double e = Convert.ToDouble(lucrobruto2.Text) / Convert.ToDouble(vendas2.Text);

            //////
            double f = Convert.ToDouble(despesas2.Text) / Convert.ToDouble(vendas2.Text);
            //////
            double h = Convert.ToDouble(aluguel2.Text) / Convert.ToDouble(vendas2.Text);

            double i = Convert.ToDouble(salarios2.Text) / Convert.ToDouble(vendas2.Text);
            double j = Convert.ToDouble(luzaguatelefone2.Text) / Convert.ToDouble(vendas2.Text);

            double k = Convert.ToDouble(lucrosemIR2.Text) / Convert.ToDouble(vendas2.Text);

            double l = Convert.ToDouble(IR2.Text) / Convert.ToDouble(vendas2.Text);

            double m = Convert.ToDouble(contribuicaosocial2.Text) / Convert.ToDouble(vendas2.Text);
            double n = Convert.ToDouble(lucroouprejuizo2.Text) / Convert.ToDouble(vendas2.Text);

        }

        private void AnaliseHorizontalresultadodaempresa()
        {
            double a = ((Convert.ToDouble(vendas2.Text) / Convert.ToDouble(Vendas.Text)) - 1) * 100;
            ////
            double b = ((Convert.ToDouble(icmsobrevendas2.Text) / Convert.ToDouble(icmssemvendas.Text)) - 1) * 100;
            double c = ((Convert.ToDouble(receitaliq2.Text) / Convert.ToDouble(receita.Text)) - 1) * 100;

            double d = ((Convert.ToDouble(CMV2.Text) / Convert.ToDouble(CMV.Text)) - 1) * 100;
            double e = ((Convert.ToDouble(lucrobruto2.Text) / Convert.ToDouble(LucroBruto.Text)) - 1) * 100;

            //////
            double f = ((Convert.ToDouble(despesas2.Text) / Convert.ToDouble(DESPESAS.Text)) - 1) * 100;
            //////
            double h = ((Convert.ToDouble(aluguel2.Text) / Convert.ToDouble(ALUGUEL.Text))-1)*100;

            double i = ((Convert.ToDouble(salarios2.Text) / Convert.ToDouble(SALARIOS.Text))-1)*100;
            double j = ((Convert.ToDouble(luzaguatelefone2.Text) / Convert.ToDouble(luzaguatelefone.Text))-1)*100;

            double k = ((Convert.ToDouble(lucrosemIR2.Text) / Convert.ToDouble(LucroantesdoIR.Text))-1)*100;

            double l = ((Convert.ToDouble(IR2.Text) / Convert.ToDouble(Impostederenda.Text))-1)*100;

            double m = ((Convert.ToDouble(contribuicaosocial2.Text) / Convert.ToDouble(contribuicaosocial.Text))-1)*100;
            double n = ((Convert.ToDouble(lucroouprejuizo2.Text) / Convert.ToDouble(LucroOUPrejuizoAcumulado.Text))-1)*100;


        }

    }
}
