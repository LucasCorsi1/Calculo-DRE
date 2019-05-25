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

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void analiseverticalresultadodaempresaDEZEMBRO()
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



        private void analiseverticalresultadodaempresaJaneiro()
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

        private void AnaliseHorizontalresultadodaempresa()
        {
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

    }
}
