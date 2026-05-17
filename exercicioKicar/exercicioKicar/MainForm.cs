
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioKicar
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		
		string[] nomes = new string[20];
			int indiceN = 0;
			
		string[] cargo = new string[20];
			int indiceC = 0;
			
		string[] setor = new string[20];
			int indiceSe = 0;
				
		double[] salarios = new double[20];
			int indiceS =0;
			
		double[] totalVendas = new double[20];
			int indiceT =0;
		
		void Button1Click(object sender, EventArgs e)
		{
			if(indiceN < nomes.Length && indiceC < cargo.Length && indiceSe < setor.Length && indiceS < salarios.Length && indiceT < totalVendas.Length){
				nomes[indiceN]= textBox1.Text.ToString();
				cargo[indiceC]= textBox2.Text.ToString();
				setor[indiceSe]= textBox3.Text.ToString();
				salarios[indiceS]= Convert.ToDouble(textBox4.Text);
				totalVendas[indiceT]= Convert.ToDouble(textBox5.Text);
				indiceN++;
				indiceC++;
				indiceSe++;
				indiceS++;
				indiceT++;
				textBox1.Clear();
				textBox2.Clear();
				textBox3.Clear();
				textBox4.Clear();
				textBox5.Clear();
				listBox1.Items.Clear();
				for(int i=0, i2 = 0, i3 = 0, i4 = 0, i5 = 0; i < indiceN && i2 < indiceC && i3 < indiceSe && i4 < indiceS && i5 < indiceT; i++, i2++, i3++, i4++, i5++){
					listBox1.Items.Add(nomes[i] + " - " + cargo[i2] + " - " + setor[i3] + " - " + salarios[i4] + " - " + totalVendas[i5].ToString());
			}
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int[] registro = new int[20];
			int indiceR= 0;			
			registro[indiceR] = int.Parse(textBox6.Text);


	
		}
		void Button3Click(object sender, EventArgs e)
		{
			
			double[] bonus = new double[20];
			int indiceB = 0;
			
			if(totalVendas[indiceT] > 1250000){
			bonus[0] = 0.15 * salarios[indiceS];
		
			 
			for(int i=0, i2 = 0, i3 = 0, i4 = 0, i5 = 0, i6 = 0; i < indiceN && i2 < indiceC && i3 < indiceSe && i4 < indiceS && i5 < indiceB && i6 < indiceT; i++, i2++, i3++, i4++, i5++, i6++){
					listBox3.Items.Add(nomes[i] + " - " + cargo[i2] + " - " + setor[i3] + " - " + salarios[i4] + " - " + bonus[i5].ToString() +  " - " + totalVendas[i6].ToString());
			}
    		
			}


		}
		
		
		
	
	}
}
