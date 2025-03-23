/*
 * Created by SharpDevelop.
 * User: gabri
 * Date: 17/03/2025
 * Time: 21:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioJuros
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
			double taxa = double.Parse(textBox1.Text);
			double capital = double.Parse(textBox2.Text);
			double meses = double.Parse(textBox3.Text);
			
			double divido = taxa/100;
			
			double resultado = capital * divido * meses;
			
			textBox4.Text = resultado.ToString();
			
			
			
		}
	}
}
