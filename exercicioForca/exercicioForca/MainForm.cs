/*
 * Created by SharpDevelop.
 * User: gabri
 * Date: 17/03/2025
 * Time: 20:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioForca
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
			float massa = float.Parse(textBox1.Text);
			float acelera = float.Parse(textBox2.Text);
			
			float forca = massa * acelera;
			
			textBox3.Text = forca.ToString();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
	}
}
