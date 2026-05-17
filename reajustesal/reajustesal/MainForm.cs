
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace reajustesal
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
	// Nomes dos funcionários
			string n1 = "Pedro";
			string n2 = "Karina";
			string n3 = "Tanaka";
			string n4 = "Luiz";
			string n5 = "Silmara";
			label1.Text = n1;
			label2.Text = n2;
			label3.Text = n3;
			label4.Text = n4;
			label5.Text = n5;
			
	// salário dos funcionários
			double salt1 = 2080.41;
			double salt2 = 1821.10;
			double salt3 = 1980.84;
			double salt4 = 1600;
			double salt5 = 2500;
			textBox1.Text = salt1.ToString();
			textBox2.Text = salt2.ToString();
			textBox3.Text = salt3.ToString();
			textBox4.Text = salt4.ToString();
			textBox5.Text = salt5.ToString();
			
	// Reajuste dos salários			
			double reaxust = double.Parse(textBox11.Text) / 100;
			
			double resultado1 = reaxust * salt1;
			double taxa1 = resultado1 + salt1;
			
			double resultado2 = reaxust * salt2;
			double taxa2 = resultado2 + salt2;
			
			double resultado3 = reaxust * salt3;
			double taxa3 = resultado3 + salt3;
			
			double resultado4 = reaxust * salt4;
			double taxa4 = resultado4 + salt4;
			
			double resultado5 = reaxust * salt5;
			double taxa5 = resultado5 + salt5;
			
			textBox6.Text = taxa1.ToString();
			textBox7.Text = taxa2.ToString();
			textBox8.Text = taxa3.ToString();
			textBox9.Text = taxa4.ToString();
			textBox10.Text = taxa5.ToString();
		}
		
		
			
		
	
	
	}
}
