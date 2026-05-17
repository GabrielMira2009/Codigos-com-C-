/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 19/05/2025
 * Hora: 15:25
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exerciciodado
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
			this.BackColor = Color.GreenYellow;
		}
		int Nmr1;
			Random rnd = new Random();
			void Button1Click(object sender, EventArgs e);
			
			Nmr1 = rnd.next(0,12);
		}
	}
}

