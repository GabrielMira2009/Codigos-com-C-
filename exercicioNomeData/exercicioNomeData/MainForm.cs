/*
 * Created by SharpDevelop.
 * User: gabri
 * Date: 17/03/2025
 * Time: 20:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioNomeData
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
			string nome = string.Intern(textBox1.Text);
			string sobreNome = string.Intern(textBox2.Text);
			
			string nomeCompleto = sobreNome + ", " + nome;
			
			textBox6.Text = nomeCompleto;
			
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string dia = string.Intern(textBox3.Text);
			string mes = string.Intern(textBox4.Text);
			string ano = string.Intern(textBox5.Text);
			
			string data = dia + "/" + mes + "/" + ano;
			
			textBox7.Text = data;
			
		}
	}
}
