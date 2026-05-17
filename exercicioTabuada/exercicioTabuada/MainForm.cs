
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioTabuada
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
			
			for(int i=1;i<=10;i++){
					
							
					int r = n * i;
					
					string res = string.Copy(n + " x " + i + " = " + r);
					
					listBox1.Items.Add(res);
			
					
					
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}