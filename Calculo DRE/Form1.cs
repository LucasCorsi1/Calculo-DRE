﻿using System;
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
    public partial class FormDRE : Form
    {
        public FormDRE()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText(liquidezGeral().ToString());

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
            return ( Convert.ToDouble(AtivoCirculante1.Text) + Convert.ToDouble(AtivonãoCirculante1.Text)) / ( Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PassivoNaoCirculante1.Text));
        }

        private double analisedeEndividamento()
        {
            return Convert.ToDouble(PassivoCirculante1.Text) / (Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text));
        }

        private double participacaodecapitaldeterceiros()
        {
            return ( Convert.ToDouble(PassivoCirculante1.Text) + Convert.ToDouble(PASSIVOFINANCIAMENTO.Text) ) / Convert.ToDouble( PassivoPatromnioLiq1.Text);
        }

    }
}
