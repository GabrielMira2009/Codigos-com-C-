
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioPets
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		string nomeimage = "assina.jpg";
		int filho = 7000;
		int adulto = 12000;
		int gravido = 500;
		double precoadulto =1000;
		double precofilho = 1000;
		int precogravido = 1500;
		
		
		void Button1Click(object sender, EventArgs e)
		{
			nomeimage = "obrigado.jpg";
			inicial.Load(nomeimage);
			int valorf = int.Parse(txtFilho.Text);
			int valora = int.Parse(txtAdulto.Text);
			int valorg = int.Parse(txtGravido.Text);
			double conta = precofilho*0.07;
			double desconto = precofilho - conta;
			double conta2 = precoadulto*0.07;
			double desconto2 = precoadulto - conta;
			
			if (valorf >= 14) {
				
				precofilho = desconto;
				
				label13.Text = "Você recebeu um desconto de 7%!";
		
				
			}
			if (valora >=7 ){
				precoadulto = desconto2;
				label13.Text = "Você recebeu um desconto de 7%!";
			}
			int resf = filho - valorf;
			int resa = adulto - valora;
			int resg = gravido - valorg;
			double precoF = valorf * precofilho;
			double precoA = valora * precoadulto;
			double precoG = valorg * precogravido;
			double precoT = precoF + precoA + precoG;
			textBox1.Text = precoF.ToString("C");
			textBox2.Text = precoA.ToString("C");
			textBox3.Text = precoG.ToString("C");
			
			estFilho.Text = resf.ToString();
			estAdulto.Text = resa.ToString();
			estGravido.Text = resg.ToString();
			txtPreco.Text = precoT.ToString("C");
			
		}
		
		
		
		
		
	
		
	
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
