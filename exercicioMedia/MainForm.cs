/*
 * Created by SharpDevelop.
 * User: gabri
 * Date: 17/03/2025
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioMedia
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
		
		//Botão calcular média
		
		void Button1Click(object sender, EventArgs e)
		{
			//Variaveis
			
			float n1 = float.Parse(textBox1.Text);
			float n2 = float.Parse(textBox2.Text);
			float n3 = float.Parse(textBox3.Text);
			float n4 = float.Parse(textBox4.Text);
			float n5 = float.Parse(textBox5.Text);
			
			//Cálculo
			
			float soma = n1 + n2 + n3 + n4 + n5;
			float media = soma/5;
			
			//Aparecendo na tela
			
				textBox6.Text = media.ToString();
		}
	}
}
