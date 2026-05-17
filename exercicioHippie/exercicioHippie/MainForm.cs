/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 05/05/2025
 * Hora: 13:54
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioHippie
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
			
		
		}
		
	
		
	
	
		
		void Button1Click(object sender, EventArgs e)
		{
			
		//Coleta de dados(Preço)
		double c1 = 18;
		double c2 = 25;
		double c3 = 32;
		
		//Exibição de dados
		txtC1.Text = c1.ToString("C");
		txtC2.Text = c2.ToString("C");
		txtC3.Text = c3.ToString("C");
			
		//Coleta de dados(qtdes)
		int qtdeIc1 = 333;
		int qtdeIc2 = 157;
		int qtdeIc3 = 200;
			
		int qtdeFc1 = 233;
		int qtdeFc2 = 92;
		int qtdeFc3 = 20;
		
		//Exibição de dados	
		txtqtdeIc1.Text = qtdeIc1.ToString();
		txtqtdeIc2.Text = qtdeIc2.ToString();
		txtqtdeIc3.Text = qtdeIc3.ToString();
			
		txtqtdeFc1.Text = qtdeFc1.ToString();
		txtqtdeFc2.Text = qtdeFc2.ToString();
		txtqtdeFc3.Text = qtdeFc3.ToString();
		
		//Coleta de dados(vendas)
		int qtdeVc1 = qtdeIc1 - qtdeFc1;
		int qtdeVc2 = qtdeIc2 - qtdeFc2;
		int qtdeVc3 = qtdeIc3 - qtdeFc3;
		
		//Exibição de dados
		txtqtdeVc1.Text = qtdeVc1.ToString(); 
		txtqtdeVc2.Text = qtdeVc2.ToString();
		txtqtdeVc3.Text = qtdeVc3.ToString();
		
		//Coleta de dados(Valor bruto)
		double vbc1 = c1 * qtdeVc1; 
		double vbc2 = c2 * qtdeVc2; 
		double vbc3 = c3 * qtdeVc3;
		
		
		//Exibição de dados
		txtVbC1.Text = vbc1.ToString();
		txtVbC2.Text = vbc2.ToString();
		txtVbC3.Text = vbc3.ToString();
		
		//Cálculo(Custo)
		int micangaC1 = 15;
		int micangaC2 = 20;
		int micangaC3 = 35;
		
		double custoC1 = (micangaC1 * 0.15 + 2.40) * qtdeVc1;
		double custoC2 = (micangaC2 * 0.15 + 2.40) * qtdeVc2;
		double custoC3 = (micangaC3 * 0.15 + 2.40) * qtdeVc3;
		
		//Exibição de dados
		txtCustoC1.Text = custoC1.ToString("C");
		txtCustoC2.Text = custoC2.ToString("C");
		txtCustoC3.Text = custoC3.ToString("C");
		
		//Cálculo(Lucro)
		double vlc1 = vbc1 - custoC1;
		double vlc2 = vbc2 - custoC2;
		double vlc3 = vbc3 - custoC3;
		
		//Exibição de dados
		txtVlC1.Text = vlc1.ToString("C");
		txtVlC2.Text = vlc2.ToString("C");
		txtVlC3.Text = vlc3.ToString("C");
		
		//Cálculo(Totais)
		double totalB = vbc1 + vbc2 + vbc3;
		double totalC = custoC1 + custoC2 + custoC3;
		double finalL = vlc1 + vlc2 + vlc3;
		
		//Exibição de dados
		txtTotalB.Text = totalB.ToString("C");
		txtTotalC.Text = totalC.ToString("C");
		txtFinalL.Text = finalL.ToString("C");
		}
	}
}
