using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_DRE
{
    public partial class FormDRE : Form
    {
        public FormDRE()
        {
            InitializeComponent();
        }
        FormEmpresa form = new FormEmpresa();
        
        private void Calcular_Click(object sender, EventArgs e)
        {
            form.Show();

        }

        private double LiquidezImediata()
        {
            return (Convert.ToDouble(Caixa1.Text) + Convert.ToDouble(BancosCMovimento1.Text)) / Convert.ToDouble(PassivoCirculante1.Text);
        }

        private double liquidezseca()
        {
            return (Convert.ToDouble(AtivoCirculante1.Text) - Convert.ToDouble(Estoque1.Text)) / Convert.ToDouble(PassivoCirculante1.Text);
        }

        private double liquidezCorrente()
        {
            return Convert.ToDouble(AtivoCirculante1.Text) / Convert.ToDouble(PassivoCirculante1.Text);
        }

        private double liquidezGeral()
        {
            return (Convert.ToDouble(AtivoCirculante1.Text) + Convert.ToDouble(AtivonãoCirculante1.Text)) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }

        private double analisedeEndividamento()
        {
            return Convert.ToDouble(PassivoCirculante1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text));
        }

        private double participacaodecapitaldeterceirosemrelacaoaopatromonioliquido()
        {
            return (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text)) / Convert.ToDouble(PassivoPatromnioLiq1.Text);
        }

        private double participacaodecapitaldeterceirosemrelacaoaoATIVO()
        {
            return (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text)) / Convert.ToDouble(AtivoTotal1.Text);
        }

        private double garatiadocapitaldeterceiros()
        {
            return Convert.ToDouble(PassivoPatromnioLiq1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }

        private double graudesolvencia()
        {
            return Convert.ToDouble(AtivoTotal1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }

        private double girodoativo()
        {
            return Convert.ToDouble(form.Vendas.Text) / Convert.ToDouble(AtivoTotal1.Text); // REVER
        }

        private double Lucratividade()
        {
            return Convert.ToDouble(form.LucroBruto.Text) / Convert.ToDouble(form.Vendas.Text);  //REVER
        }

        private double prazomediodeestoques()
        {
            return Convert.ToDouble(form.CMV.Text) / Convert.ToDouble(Estoque1.Text);
        }

        private double prazomedioEstoquesPorperidodo()
        {
            return 360 / (Convert.ToDouble(form.CMV.Text) / Convert.ToDouble(Estoque1.Text));
        }


        private void analiseverticalAtivoJaneiro()
        {
            // enumerado em ordem alfabetica

            double a = Convert.ToDouble(AtivoCirculante1.Text) / Convert.ToDouble(AtivoTotal1.Text);
            ////
            double b = Convert.ToDouble(Caixa1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            double c = Convert.ToDouble(BancosCMovimento1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            double d = Convert.ToDouble(Estoque1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            double e = Convert.ToDouble(Contasaareceber1.Text) / Convert.ToDouble(AtivoCirculante1.Text);

            //////
            double f = Convert.ToDouble(Imobilizado1.Text) / Convert.ToDouble(AtivoTotal1.Text);
            ///
            double g = Convert.ToDouble(Veiculos1.Text) / Convert.ToDouble(Imobilizado1.Text);
            double h = Convert.ToDouble(Moveis1.Text) / Convert.ToDouble(Imobilizado1.Text);
            double i = Convert.ToDouble(Instalacoes1.Text) / Convert.ToDouble(Imobilizado1.Text);
            double j = Convert.ToDouble(maquinas1.Text) / Convert.ToDouble(Imobilizado1.Text);
            double k = Convert.ToDouble(computadores1.Text) / Convert.ToDouble(Imobilizado1.Text);


        }

        private void analiseverticalAtivoDEZEMBRO()
        {
            // enumerado em ordem alfabetica

            double a = Convert.ToDouble(AtivoCirculante2.Text) / Convert.ToDouble(AtivoTotal2.Text);
            ////
            double b = Convert.ToDouble(caixa2.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            double c = Convert.ToDouble(BancosCMovimento1.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            double d = Convert.ToDouble(estoque2.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            double e = Convert.ToDouble(Contasaareceber1.Text) / Convert.ToDouble(AtivoCirculante1.Text);

            //////
            double f = Convert.ToDouble(AtivoImobilizado2.Text) / Convert.ToDouble(AtivoTotal2.Text);
            ///
            double g = Convert.ToDouble(veiculos2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            double h = Convert.ToDouble(Moveis2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            double i = Convert.ToDouble(Instalacoes2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            double j = Convert.ToDouble(maquinas2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            double k = Convert.ToDouble(computadores2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);


        }



        private void analiseverticalPASSIVOJaneiro()
        {
            // enumerado em ordem alfabetica

            double a = Convert.ToDouble(PassivoCirculante1.Text) / Convert.ToDouble(PassivoTotal1.Text);
            ////
            double b = Convert.ToDouble(PASSIVOSALARIOSENCARGOSPAGAR.Text) / Convert.ToDouble(PassivoCirculante1.Text);
            double c = Convert.ToDouble(PASSIVOFORNECEDORES.Text) / Convert.ToDouble(PassivoCirculante1.Text);
            double d = Convert.ToDouble(PASSIVOCONTASAPAGAR.Text) / Convert.ToDouble(PassivoCirculante1.Text);
            double e = Convert.ToDouble(PASSIVOFINANCIAMENTO.Text) / Convert.ToDouble(PassivoCirculante1.Text);

            //////
            double f = Convert.ToDouble(PassivoNaoCirculante1.Text) / Convert.ToDouble(PassivoTotal1.Text);
            //////
            double h = Convert.ToDouble(PassivoPatromnioLiq1.Text) / Convert.ToDouble(PassivoTotal1.Text);

            double i = Convert.ToDouble(PASSIVOCAPITALSOCIAL.Text) / Convert.ToDouble(PassivoPatromnioLiq1.Text);
            double j = Convert.ToDouble(PASSIVOLUCROOUPREJUIZO.Text) / Convert.ToDouble(PassivoPatromnioLiq1.Text);
          


        }


        private void analiseverticalPASSIVODEZEMBRO()
        {
            // enumerado em ordem alfabetica

            double a = Convert.ToDouble(PassivoCirculante2.Text) / Convert.ToDouble(PassivoTotal2.Text);
            ////
            double b = Convert.ToDouble(PASSIVOSALARIOSENCARGOSPAGAR2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            double c = Convert.ToDouble(PASSIVOFORNECEDORES2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            double d = Convert.ToDouble(PASSIVOCONTASAPAGAR2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            double e = Convert.ToDouble(PASSIVOFINANCIAMENTO2.Text) / Convert.ToDouble(PassivoCirculante2.Text);

            //////
            double f = Convert.ToDouble(PassivoNaocirculante2.Text) / Convert.ToDouble(PassivoTotal2.Text);
            //////
            double h = Convert.ToDouble(PassvioPatrimonioLiq2.Text) / Convert.ToDouble(PassivoTotal2.Text);

            double i = Convert.ToDouble(PASSIVOCAPITALSOCIAL2.Text) / Convert.ToDouble(PassvioPatrimonioLiq2.Text);
            double j = Convert.ToDouble(PASSIVOLUCROOUPREJUIZO2.Text) / Convert.ToDouble(PassvioPatrimonioLiq2.Text);



        }


        private void AnaliseHorizontaATIVOlDEZEMBROEJaneiro()
        {


        }

    }
}
