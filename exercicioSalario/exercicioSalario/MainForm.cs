using System;
using System.Windows.Forms;

namespace exercicioSalario
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void Button1Click(object sender, EventArgs e)
        {
     
            {
                // Obtém os valores digitados
                double sal = double.Parse(textBox1.Text); // Salário
                double faltas = double.Parse(textBox2.Text); // Número de faltas

                // Cálculo dos descontos
                double inss = sal * 0.12;
                double descontoFaltas = (sal / 30);
                double vezes = descontoFaltas * faltas;
                double salarioLiquido = sal - vezes - inss;

                // Exibe os valores na tela
                textBox3.Text = inss.ToString("C"); // Desconto do INSS
                textBox5.Text = vezes.ToString("C"); // Desconto por faltas
                textBox4.Text = salarioLiquido.ToString("C"); // Salário líquido final
            }
        }
    }
}

