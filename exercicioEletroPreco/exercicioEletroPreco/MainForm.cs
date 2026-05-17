/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 28/04/2025
 * Hora: 13:22
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioEletroPreco
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
	
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
			double precoFb = 13000;
			label4.Text = precoFb.ToString("C");
			double lucroLj = 0.20;
			
			double precofbl = precoFb * lucroLj;
			double result1 = precofbl + precoFb;
			
			double imposto = result1 * 0.25;
			double precoFinal = result1 + imposto;
			
			textBox1.Text = precoFinal.ToString("C");
			textBox2.Text = imposto.ToString("C");
			textBox3.Text = precofbl.ToString("C");
		}
		
		
	}
}
