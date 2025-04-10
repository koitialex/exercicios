using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysBidimensional
{
    public partial class frmBidimensional : Form
    {
            int[,] matriz =
         {
            {1, 5,-2},
            {8, 3, 0},
            {4,-1, 2}
        };

            int i;
            int j;
        }

        private void frmBidimensional_Load(object sender, EventArgs e)
        {
        for (i = 0; i <= 2; i++)
        {
            for (j = 0; j <= 2; j++)
            {
                txtDisplay.Text += matriz[i, j].ToString() + " ";

            }
            txtDisplay.Text += Environment.NewLine;
        }
        }

    private void btnMostrar_Click(object sender, EventArgs e)
        {
        int maior = matriz[0, 0];

        for (i = 0; i <= 2; i++)
        {
            for (j = 0; j <= 2; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }
        MessageBox.Show("O maior valor da matriz é: " + maior);
    }
}

