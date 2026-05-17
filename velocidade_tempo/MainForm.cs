/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 31/03/2025
 * Hora: 13:30
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace velocidade_tempo
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
		
	
		
		// Cálculo de velocidade
		
		void Button1Click(object sender, EventArgs e)
		{
			float tempo = float.Parse(textBox1.Text);
			float distancia = float.Parse(textBox2.Text);
			float velocidade = distancia/tempo;
			
			// Resultado
			textBox3.Text = velocidade.ToString();
		}
	}
}
