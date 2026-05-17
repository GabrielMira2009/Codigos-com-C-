
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioIdadeDia
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
			int anos = int.Parse(textBox1.Text) * 365;
			int meses = int.Parse(textBox2.Text) * 30;
			int dias = int.Parse(textBox3.Text);
			
			int idade = anos + meses + dias;
			
			textBox4.Text = idade.ToString();
		}
	}
}
