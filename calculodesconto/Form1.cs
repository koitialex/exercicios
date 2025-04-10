﻿using System;
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
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtValorCompra.Text == "" || txtDesconto.Text == "")
            {
                MessageBox.Show("Inseriu nenhum número", "Avido",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float valor, desconto, resultado;

            valor = float.Parse(txtValorCompra.Text);

            desconto = float.Parse(txtDesconto.Text);

            resultado = valor -( valor *( desconto/100));

            lblValorResultado.Text = resultado.ToString();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtValorCompra.Clear();
            txtDesconto.Clear();
            lblValorResultado.Text = "0";

        }
    }
}