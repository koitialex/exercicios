using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_com_design
{

    public partial class frmCalculadora : Form
    {
        private Operacao OperacaoSelecionada { get; set; }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }

        enum Operacao
    {
        adicao,
        subtracao,
        divisao,
        multiplicacao,
    }
        public frmCalculadora()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblDisplay.Text = "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblDisplay.Text = "-";
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblDisplay.Text = "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblDisplay.Text = "/";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch(OperacaoSelecionada)
            {
                case Operacao.adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
           if(!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            lblDisplay.Text = "";
        }
    }
}
