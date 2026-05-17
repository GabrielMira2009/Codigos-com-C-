/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 12/05/2025
 * Hora: 14:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioPiscina
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
			//Coleta de dados
			double altura = double.Parse(txtAltura.Text);
			double largura = double.Parse(txtLargura.Text);
			double comprimento = double.Parse(txtComprimento.Text);
			
			//Cálculos
			double volume = altura * largura * comprimento;
			double preço = (volume * 49.99) + 450;
			
			//Exibição de dados
			txtPreco.Text = preço.ToString("C");
			txtVolume.Text = volume.ToString();
			
			
		}
		
	
	}
}
