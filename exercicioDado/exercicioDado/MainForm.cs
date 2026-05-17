/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 19/05/2025
 * Hora: 13:28
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioDado
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();

			this.BackColor = Color.ForestGreen;		
		} int n1;
			Random rnd = new Random();
		
			
		
		void Button1Click(object sender, EventArgs e)
		{ 
			n1 = rnd.Next(0, 12);
			button1.BackgroundImage = Image.FromFile("pais"+n1+".jpg");
		}
			

	}
}