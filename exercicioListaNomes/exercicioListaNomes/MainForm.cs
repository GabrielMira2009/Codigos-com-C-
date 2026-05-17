
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;           


namespace exercicioListaNomes
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
		}
		
		const string caminhoArquivo = "usuarios.txt";
		
		void Button1Click(object sender, EventArgs e)
		{
			string nome = textBox1.Text.Trim();
            string data = textBox2.Text.Trim();
			
             using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
            {
                sw.WriteLine(nome + ";" + data);
            }
             
            textBox1.Clear();
            textBox2.Clear();
            
         	button2.Enabled = true;
            
		}
		
		void Button2Click(object sender, EventArgs e)
		{
	
			
			   richTextBox1.Clear();

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(';');
                if (partes.Length == 2)
                {
                    string nome = partes[0];
                    string data = partes[1];
                    richTextBox1.AppendText("Nome: " + nome + " | Nascimento: " + data + Environment.NewLine);
          
        		}
         	}
		}
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			string caminho = "usuarios.txt";

  
    	File.WriteAllText(caminho, string.Empty);


   		richTextBox1.Clear();

    	MessageBox.Show("Todos os dados foram apagados com sucesso!");
		}
	}
}