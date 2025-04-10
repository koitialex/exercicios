using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);

            if (numero > 10)
            {
                MessageBox.Show($"O numero {numero} é maior que 10","Resultado");
            }
            else if(numero == 10)
            {
                MessageBox.Show($"O numero {numero} é igual a 10", "Resultado");
            }
            else if (numero < 10)
            {
                MessageBox.Show($"O numero {numero} é menor que 10", "Resultado");
            }
            
        }
    }
}
