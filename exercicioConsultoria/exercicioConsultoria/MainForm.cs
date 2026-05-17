using System;
using System.IO;
using System.Windows.Forms;

namespace exercicioConsultoria
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }
        
        string arquivoFuncionarios = "funcionarios.txt";
        string arquivoGastoes = "gastoes.txt";

        void PictureBox1Click(object sender, EventArgs e)
        {
    

            string[] linhas = File.ReadAllLines(arquivoFuncionarios);

            double soma = 0;
            int total = 0;

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split('#');

                if (partes.Length != 3) continue;

                double valor = double.Parse(partes[2], System.Globalization.CultureInfo.InvariantCulture);

                soma += valor;
                total++;
            }

    

            double media = soma / total;

            textBox1.Text = media.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"));

            CriarArquivoGastoes(linhas, media);

            MessageBox.Show("Média calculada com sucesso!");
        }

        void PictureBox2Click(object sender, EventArgs e)
        {
      

            string[] linhas = File.ReadAllLines(arquivoGastoes);

            richTextBox1.Clear();

            foreach (string linha in linhas)
			{
    			string[] partes = linha.Split('#');

    			if (partes.Length != 3) continue;

    			string nome = partes[0];
    			string telefone = partes[1];
    			double valor = double.Parse(partes[2], System.Globalization.CultureInfo.InvariantCulture);

    		richTextBox1.AppendText(
        			"Nome: " + nome +
        			" | Telefone: " + telefone +
        			" | Valor gasto: R$ " +
        			valor.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")) +
        			Environment.NewLine
    			);
			}

            MessageBox.Show("Funcionários que gastam acima da média exibidos!");
        }

        private void CriarArquivoGastoes(string[] linhas, double media)
        {
            using (StreamWriter sw = new StreamWriter(arquivoGastoes, false))
            {
                foreach (string linha in linhas)
                {
                    string[] partes = linha.Split('#');

                    if (partes.Length != 3) continue;

                    string nome = partes[0];
                    string telefone = partes[1];
                    double valor = double.Parse(partes[2], System.Globalization.CultureInfo.InvariantCulture);


                    if (valor > media)
                    {
                    	sw.WriteLine(nome + "#" + telefone + "#" + valor.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));
                    }
                }
            }
        }
		
		
    }
}


