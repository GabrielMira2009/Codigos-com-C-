
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioFor
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
		int n = int.Parse(txtN.Text);
			
			for(int i=1;i<=n;i++)
			{
			
			int soma = i + i;
	
			listBox1.Items.Add(i);
			
			if(i == n)
			{
				
			string res = string.Copy("A soma dos números até " + n + " é " + soma);
			listBox1.Items.Add(res);
			}
			
		}
			
		
					
							
	
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
