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
        public static FormDRE DRE;
        public FormDRE()
        {
            InitializeComponent();
        }

        FormEmpresa formEmpresa = new FormEmpresa();
        private void Calcular_Click(object sender, EventArgs e)
        {
            DRE = this;
            formEmpresa.Show();
        }
        //primeira parte dezembro
        public double LiquidezImediata()
        {
            return (Convert.ToDouble(Caixa1.Text) + Convert.ToDouble(BancosCMovimento1.Text) / Convert.ToDouble(PassivoCirculante1.Text));
        }
        public double Liquidezseca()
        {
            return (Convert.ToDouble(AtivoCirculante1.Text) - Convert.ToDouble(Estoque1.Text)) / Convert.ToDouble(PassivoCirculante1.Text);
        }
        public double LiquidezCorrente()
        {
            return Convert.ToDouble(AtivoCirculante1.Text) / Convert.ToDouble(PassivoCirculante1.Text);
        }
        public double LiquidezGeral()
        {
            return (Convert.ToDouble(AtivoCirculante1.Text) + Convert.ToDouble(AtivonãoCirculante1.Text)) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }
        public double AnalisedeEndividamento()
        {
            return Convert.ToDouble(PassivoCirculante1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text));
        }
        public double Participacaodecapitaldeterceirosemrelacaoaopatromonioliquido()
        {
            return (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text)) / Convert.ToDouble(PassivoPatromnioLiq1.Text);
        }
        public double ParticipacaodecapitaldeterceirosemrelacaoaoATIVO()
        {
            return (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text)) / Convert.ToDouble(AtivoTotal1.Text);
        }
        public double Garatiadocapitaldeterceiros()
        {
            return Convert.ToDouble(PassivoPatromnioLiq1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }
        public double Graudesolvencia()
        {
            return Convert.ToDouble(AtivoTotal1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }
        public double Girodoativo()
        {
            return Convert.ToDouble(formEmpresa.Vendas.Text) / Convert.ToDouble(AtivoTotal1.Text); // REVER
        }
        public double Lucratividade()
        {
            return Convert.ToDouble(formEmpresa.LucroBruto.Text) / Convert.ToDouble(formEmpresa.Vendas.Text);  //REVER
        }
        public double Prazomediodeestoques()
        {
            return Convert.ToDouble(formEmpresa.CMV.Text) / Convert.ToDouble(Estoque1.Text);
        }
        public double PrazomedioEstoquesPorperidodo()
        {
            return 360 / (Convert.ToDouble(formEmpresa.CMV.Text) / Convert.ToDouble(Estoque1.Text));
        }

        //segunda parte janeiro
        public double LiquidezImediata2()
        {
            return (Convert.ToDouble(caixa2.Text) + Convert.ToDouble(BancosCMovimento2.Text)) / Convert.ToDouble(PassivoCirculante2.Text);
        }
        public double Liquidezseca2()
        {
            return (Convert.ToDouble(AtivoCirculante2.Text) - Convert.ToDouble(estoque2.Text)) / Convert.ToDouble(PassivoCirculante2.Text);
        }
        public double LiquidezCorrente2()
        {
            return Convert.ToDouble(AtivoCirculante2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
        }
        public double LiquidezGeral2()
        {
            return (Convert.ToDouble(AtivoCirculante2.Text) + Convert.ToDouble(AtivoNaoCirculante2.Text)) / (Convert.ToDouble(PassivoCirculante2.Text) + Convert.ToDouble(PassivoNaocirculante2.Text));
        }
        public double AnalisedeEndividamento2()
        {
            return Convert.ToDouble(PassivoCirculante2.Text) / (Convert.ToDouble(PassivoCirculante2.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO2.Text));
        }
        public double Participacaodecapitaldeterceirosemrelacaoaopatromonioliquido2()
        {
            return (Convert.ToDouble(PassivoCirculante2.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO2.Text)) / Convert.ToDouble(PassvioPatrimonioLiq2.Text);
        }
        public double ParticipacaodecapitaldeterceirosemrelacaoaoATIVO2()
        {
            return (Convert.ToDouble(PassivoCirculante2.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO2.Text)) / Convert.ToDouble(AtivoTotal2.Text);
        }
        public double Garatiadocapitaldeterceiros2()
        {
            return Convert.ToDouble(PassvioPatrimonioLiq2.Text) / (Convert.ToDouble(PassivoCirculante2.Text) + Convert.ToDouble(PassivoNaocirculante2.Text));
        }
        public double Graudesolvencia2()
        {
            return Convert.ToDouble(AtivoTotal2.Text) / (Convert.ToDouble(PassivoCirculante2.Text) + Convert.ToDouble(PassivoNaocirculante2.Text));
        }
        public double Girodoativo2()
        {
            return Convert.ToDouble(formEmpresa.vendas2.Text) / Convert.ToDouble(AtivoTotal2.Text); // REVER
        }
        public double Lucratividade2()
        {
            return Convert.ToDouble(formEmpresa.lucrobruto2.Text) / Convert.ToDouble(formEmpresa.vendas2.Text);  //REVER
        }
        public double Prazomediodeestoques2()
        {
            return Convert.ToDouble(formEmpresa.CMV2.Text) / Convert.ToDouble(estoque2.Text);
        }
        public double PrazomedioEstoquesPorperidodo2()
        {
            return 360 / (Convert.ToDouble(formEmpresa.CMV2.Text) / Convert.ToDouble(estoque2.Text));
        }

        //Analises Verticais e Horizontais
        public double[] AnaliseverticalAtivoJaneiro()
        {
            //Enumerado em ordem dentro do array
            double[] array = new double[11];
            array[0] = Convert.ToDouble(AtivoCirculante1.Text) / Convert.ToDouble(AtivoTotal1.Text);
            array[1] = Convert.ToDouble(Caixa1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            array[2] = Convert.ToDouble(BancosCMovimento1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            array[3] = Convert.ToDouble(Estoque1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            array[4] = Convert.ToDouble(Contasaareceber1.Text) / Convert.ToDouble(AtivoCirculante1.Text);
            array[5] = Convert.ToDouble(Imobilizado1.Text) / Convert.ToDouble(AtivoTotal1.Text);
            array[6] = Convert.ToDouble(Veiculos1.Text) / Convert.ToDouble(Imobilizado1.Text);
            array[7] = Convert.ToDouble(Moveis1.Text) / Convert.ToDouble(Imobilizado1.Text);
            array[8] = Convert.ToDouble(Instalacoes1.Text) / Convert.ToDouble(Imobilizado1.Text);
            array[9] = Convert.ToDouble(maquinas1.Text) / Convert.ToDouble(Imobilizado1.Text);
            array[10] = Convert.ToDouble(computadores1.Text) / Convert.ToDouble(Imobilizado1.Text);
            return array;
        }
        public double[] AnaliseverticalAtivoDEZEMBRO()
        {
            //Enumerado em ordem dentro do array
            double[] array = new double[11];
            array[0] = Convert.ToDouble(AtivoCirculante2.Text) / Convert.ToDouble(AtivoTotal2.Text);
            array[1] = Convert.ToDouble(caixa2.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            array[2] = Convert.ToDouble(BancosCMovimento1.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            array[3] = Convert.ToDouble(estoque2.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            array[4] = Convert.ToDouble(contasareceber2.Text) / Convert.ToDouble(AtivoCirculante2.Text);
            array[5] = Convert.ToDouble(AtivoImobilizado2.Text) / Convert.ToDouble(AtivoTotal2.Text);
            array[6] = Convert.ToDouble(veiculos2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            array[7] = Convert.ToDouble(Moveis2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            array[8] = Convert.ToDouble(Instalacoes2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            array[9] = Convert.ToDouble(maquinas2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            array[10] = Convert.ToDouble(computadores2.Text) / Convert.ToDouble(AtivoImobilizado2.Text);
            return array;
        }
        public double[] AnaliseverticalPASSIVOJaneiro()
        {
            //Enumerado em ordem dentro do array
            double[] array = new double[9]; 
            array[0] = Convert.ToDouble(PassivoCirculante1.Text)              / Convert.ToDouble(PassivoTotal1.Text);
            array[1] = Convert.ToDouble(PASSIVOSALARIOSENCARGOSPAGAR.Text)    / Convert.ToDouble(PassivoCirculante1.Text);
            array[2] = Convert.ToDouble(PASSIVOFORNECEDORES.Text)             / Convert.ToDouble(PassivoCirculante1.Text);
            array[3] = Convert.ToDouble(PASSIVOCONTASAPAGAR.Text)             / Convert.ToDouble(PassivoCirculante1.Text);
            array[4] = Convert.ToDouble(PASSIVOFINANCIAMENTO.Text)            / Convert.ToDouble(PassivoCirculante1.Text);
            array[5] = Convert.ToDouble(PassivoNaoCirculante1.Text)           / Convert.ToDouble(PassivoTotal1.Text);
            array[6] = Convert.ToDouble(PassivoPatromnioLiq1.Text)            / Convert.ToDouble(PassivoTotal1.Text);
            array[7] = Convert.ToDouble(PASSIVOCAPITALSOCIAL.Text)            / Convert.ToDouble(PassivoPatromnioLiq1.Text);
            array[8] = Convert.ToDouble(PASSIVOLUCROOUPREJUIZO.Text)          / Convert.ToDouble(PassivoPatromnioLiq1.Text);
            return array;
        }
        public double[] AnaliseverticalPASSIVODEZEMBRO()
        {
            //Enumerado em ordem dentro do array
            double[] array = new double[9];
            array[0] = Convert.ToDouble(PassivoCirculante2.Text) / Convert.ToDouble(PassivoTotal2.Text);
            array[1] = Convert.ToDouble(PASSIVOSALARIOSENCARGOSPAGAR2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            array[2] = Convert.ToDouble(PASSIVOFORNECEDORES2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            array[3] = Convert.ToDouble(PASSIVOCONTASAPAGAR2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            array[4] = Convert.ToDouble(PASSIVOFINANCIAMENTO2.Text) / Convert.ToDouble(PassivoCirculante2.Text);
            array[5] = Convert.ToDouble(PassivoNaocirculante2.Text) / Convert.ToDouble(PassivoTotal2.Text);
            array[6] = Convert.ToDouble(PassvioPatrimonioLiq2.Text) / Convert.ToDouble(PassivoTotal2.Text);
            array[7] = Convert.ToDouble(PASSIVOCAPITALSOCIAL2.Text) / Convert.ToDouble(PassvioPatrimonioLiq2.Text);
            array[8] = Convert.ToDouble(PASSIVOLUCROOUPREJUIZO2.Text) / Convert.ToDouble(PassvioPatrimonioLiq2.Text);
            return array;
        }
        public double[] AnaliseHorizontaATIVOlDEZEMBROEJaneiro()
        {
            //Enumerado em ordem dentro do array
            double[] array = new double[11];
            array[0] = ((Convert.ToDouble(AtivoCirculante2.Text) / Convert.ToDouble(AtivoCirculante1.Text)) - 1) * 100;
            array[1] = ((Convert.ToDouble(caixa2.Text) / Convert.ToDouble(Caixa1.Text)) - 1) * 100;
            array[2] = ((Convert.ToDouble(BancosCMovimento1.Text) / Convert.ToDouble(BancosCMovimento1.Text)) - 1) * 100;
            array[3] = ((Convert.ToDouble(estoque2.Text) / Convert.ToDouble(Estoque1.Text)) - 1) * 100;
            array[4] = ((Convert.ToDouble(contasareceber2.Text) / Convert.ToDouble(Contasaareceber1.Text)) - 1) * 100;
            array[5] = ((Convert.ToDouble(AtivoImobilizado2.Text) / Convert.ToDouble(Imobilizado1.Text)) - 1) * 100;
            array[6] = ((Convert.ToDouble(veiculos2.Text) / Convert.ToDouble(Veiculos1.Text)) - 1) * 100;
            array[7] = ((Convert.ToDouble(Moveis2.Text) / Convert.ToDouble(Moveis1.Text)) - 1) * 100;
            array[8] = ((Convert.ToDouble(Instalacoes2.Text) / Convert.ToDouble(Instalacoes1.Text)) - 1) * 100;
            array[9] = ((Convert.ToDouble(maquinas2.Text) / Convert.ToDouble(maquinas1.Text)) - 1) * 100;
            array[10] = ((Convert.ToDouble(computadores2.Text) / Convert.ToDouble(computadores1.Text)) - 1) * 100;
            return array;
        }
        public double[] AnaliseHorizontaPassivolDEZEMBROEJaneiro()
        {
            //Enumerado em ordem dentro do array
            double[] array = new double[9];
            array[0] = ((Convert.ToDouble(PassivoCirculante2.Text) / Convert.ToDouble(PassivoNaoCirculante1.Text)) - 1) * 100;
            array[1] = ((Convert.ToDouble(PASSIVOSALARIOSENCARGOSPAGAR2.Text) / Convert.ToDouble(PASSIVOSALARIOSENCARGOSPAGAR.Text)) - 1) * 100;
            array[2] = ((Convert.ToDouble(PASSIVOFORNECEDORES2.Text) / Convert.ToDouble(PASSIVOFORNECEDORES.Text)) - 1) * 100;
            array[3] = ((Convert.ToDouble(PASSIVOCONTASAPAGAR2.Text) / Convert.ToDouble(PASSIVOCONTASAPAGAR.Text)) - 1) * 100;
            array[4] = ((Convert.ToDouble(PASSIVOFINANCIAMENTO2.Text) / Convert.ToDouble(PASSIVOFINANCIAMENTO.Text)) - 1) * 100;
            array[5] = ((Convert.ToDouble(PassivoNaocirculante2.Text) / Convert.ToDouble(PassivoNaoCirculante1.Text)) - 1) * 100;
            array[6] = ((Convert.ToDouble(PassvioPatrimonioLiq2.Text) / Convert.ToDouble(PassivoPatromnioLiq1.Text)) - 1) * 100;
            array[7] = ((Convert.ToDouble(PASSIVOCAPITALSOCIAL2.Text) / Convert.ToDouble(PASSIVOCAPITALSOCIAL.Text)) - 1) * 100;
            array[8] = ((Convert.ToDouble(PASSIVOLUCROOUPREJUIZO2.Text) / Convert.ToDouble(PASSIVOLUCROOUPREJUIZO.Text)) - 1) * 100;
            return array;
        }
    }
}
