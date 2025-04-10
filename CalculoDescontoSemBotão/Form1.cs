using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculodesconto
{
    public partial class frmDesconto : Form
    {
        public frmDesconto()
        {
            InitializeComponent();
            txtValorCompra.TextChanged += CalcularDesconto; //o segredo do sistema está em .textchanged ele permite com que a interação aconteça sem a necessidade do botão
            txtDesconto.TextChanged += CalcularDesconto;
        }

        private void CalcularDesconto(object sender, EventArgs e)
        {
            decimal desconto, valor, resultado;
            //aqui valida se é um número, caso ele é um número ele passa. senao ele para aí
            if (txtValorCompra.Text == "" || txtDesconto.Text == "") 
            {
                lblValorResultado.Text = "";  //aqui é para prevenir do sistema manda mensagem de aviso toda vez que for digitar um número. Ele deixa o lblValorResultado vazia.
                return;
            }    
                ;

            if(!decimal.TryParse(txtValorCompra.Text, out valor) || !decimal.TryParse(txtDesconto.Text, out desconto)) //Toda vez que não coloca um número inteiro ou decimal aparecerar uma mensagem de erro
            {
                
                MessageBox.Show("Inseriu nenhum número", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            resultado = valor -( valor *( desconto/100));

            lblValorResultado.Text = resultado.ToString();

        }

  
    }
}
