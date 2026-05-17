
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioSpringfield
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		string[] nomes = new string[15];
			int indiceN = 0;
			
			double[] salarios = new double[15];
			int indiceS =0;
		
		void Button1Click(object sender, EventArgs e)
		{
			if(indiceN < nomes.Length & indiceS < salarios.Length){
				nomes[indiceN]= textBox1.Text.ToString();
				salarios[indiceS]= Convert.ToDouble(textBox2.Text);
				indiceN++;
				indiceS++;
				textBox1.Clear();
				textBox2.Clear();
				listBox1.Items.Clear();
				for(int i=0, i2 = 0; i < indiceN && i2 < indiceS; i++, i2++){
					listBox1.Items.Add(nomes[i] + " - " + salarios[i2].ToString());
			}
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			double soma = 0;
			
			for(int i = 0; i < indiceS; i++){
				
				soma += salarios[i];
				
			}
			
			label4.Text = "Soma: " + soma.ToString("F2");
		}
	
		
		void Button3Click(object sender, EventArgs e)
		{
			
			double maior = salarios[0];
    		int indiceMaior = 0;

    		for (int i = 1; i < indiceS; i++)
    		{	
        	if (salarios[i] > maior)
        	{
            maior = salarios[i];
            indiceMaior = i; 
        }
    }

    		string nomeMaior = nomes[indiceMaior];
    		label1.Text = "Maior salário: " + nomeMaior + " - R$ " + maior.ToString("F2");
		}

	}
}
