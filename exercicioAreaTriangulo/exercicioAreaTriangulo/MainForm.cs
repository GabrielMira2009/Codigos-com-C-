
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioAreaTriangulo
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
			int altura = int.Parse(textBox1.Text);
			int bas = int.Parse(textBox2.Text);
			
			int vezes = altura * bas ;
			int area = vezes/2;
			
			textBox3.Text = area.ToString();
		}
	}
}
