
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioBrinquedo
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
	
	
		
	
		
		
		
		
		void Button2Click(object sender, EventArgs e)
		{
			
			
			//Declaração de variáveis
			int qdtInicial1 = int.Parse(textBox13.Text);
			int qdtInicial2 = int.Parse(textBox14.Text);
			int qdtInicial3 = int.Parse(textBox15.Text);
			int qdtInicial4 = int.Parse(textBox16.Text);
			int qdtInicial5 = int.Parse(textBox17.Text);
			int qdtInicial6 = int.Parse(textBox18.Text);
			
			int qdtFinal1 = int.Parse(textBox19.Text);
			int qdtFinal2 = int.Parse(textBox20.Text);
			int qdtFinal3 = int.Parse(textBox21.Text);
			int qdtFinal4 = int.Parse(textBox22.Text);
			int qdtFinal5 = int.Parse(textBox23.Text);
			int qdtFinal6 = int.Parse(textBox24.Text);
			
			//Cálculo
			int qdtVendida1 = qdtInicial1 - qdtFinal1;
			int qdtVendida2 = qdtInicial2 - qdtFinal2;
			int qdtVendida3 = qdtInicial3 - qdtFinal3;
			int qdtVendida4 = qdtInicial4 - qdtFinal4;
			int qdtVendida5 = qdtInicial5 - qdtFinal5;
			int qdtVendida6 = qdtInicial6 - qdtFinal6;
			
			textBox31.Text = qdtVendida1.ToString();
			textBox32.Text = qdtVendida2.ToString();
			textBox33.Text = qdtVendida3.ToString();
			textBox34.Text = qdtVendida4.ToString();
			textBox35.Text = qdtVendida5.ToString();
			textBox36.Text = qdtVendida6.ToString();
			
			//Preços dos briquedos (Coleta de dados)
			double preco1 = 23.10;
			double preco2 = 240.99;
			double preco3 = 300;
			double preco4 = 800;
			double preco5 = 65.49;
			double preco6 = 150;
			
			//Cáculos
			double totalV1 = preco1 * qdtVendida1;
			double totalV2 = preco2 * qdtVendida2;
			double totalV3 = preco3 * qdtVendida3;
			double totalV4 = preco4 * qdtVendida4;
			double totalV5 = preco5 * qdtVendida5;
			double totalV6 = preco6 * qdtVendida6;
			
			//Exibir dados
			textBox37.Text = totalV1.ToString("C");
			textBox38.Text = totalV2.ToString("C");
			textBox39.Text = totalV3.ToString("C");
			textBox40.Text = totalV4.ToString("C");
			textBox41.Text = totalV5.ToString("C");
			textBox42.Text = totalV6.ToString("C");
			
			double totalG = totalV1 + totalV2 + totalV3 + totalV4 + totalV5 + totalV6;
			textBox43.Text = totalG.ToString("C");
		}
	}
}
