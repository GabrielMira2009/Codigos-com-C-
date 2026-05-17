/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 30/09/2025
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDaVelha
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		

		
		void Marcacao2Click(object sender, EventArgs e)
		{
			Marcacao2.Text = "x";
			this.Marcacao2.ForeColor = Color.Blue;
			Marcacao2.Visible = true;
		}
		
		void Marcacao2DoubleClick(object sender, EventArgs e)
		{
			Marcacao2.Text = "O";
			this.Marcacao2.ForeColor = Color.Red;
			Marcacao2.Visible = true;
		}
		
		void Marcacao3Click(object sender, EventArgs e)
		{
			Marcacao3.Text = "x";
			this.Marcacao3.ForeColor = Color.Blue;
			Marcacao3.Visible = true;
		}
		
		void Marcacao3DoubleClick(object sender, EventArgs e)
		{
			Marcacao3.Text = "O";
			this.Marcacao3.ForeColor = Color.Red;
			Marcacao3.Visible = true;
		}
		
		void Marcacao4Click(object sender, EventArgs e)
		{
			Marcacao4.Text = "x";
			this.Marcacao4.ForeColor = Color.Blue;
			Marcacao4.Visible = true;
		}
		
		void Marcacao4DoubleClick(object sender, EventArgs e)
		{
			Marcacao4.Text = "O";
			this.Marcacao4.ForeColor = Color.Red;
			Marcacao4.Visible = true;
		}
		
		void Marcacao5Click(object sender, EventArgs e)
		{
			Marcacao5.Text = "x";
			this.Marcacao5.ForeColor = Color.Blue;
			Marcacao5.Visible = true;
		}
		
		void Marcacao5DoubleClick(object sender, EventArgs e)
		{
			Marcacao5.Text = "O";
			this.Marcacao5.ForeColor = Color.Red;
			Marcacao5.Visible = true;
		}
		
		void Marcacao6Click(object sender, EventArgs e)
		{
			Marcacao6.Text = "x";
			this.Marcacao6.ForeColor = Color.Blue;
			Marcacao6.Visible = true;
		}
		
		void Marcacao6DoubleClick(object sender, EventArgs e)
		{
			Marcacao6.Text = "O";
			this.Marcacao6.ForeColor = Color.Red;
			Marcacao6.Visible = true;
		}
		
		void Marcacao7Click(object sender, EventArgs e)
		{
			Marcacao7.Text = "x";
			this.Marcacao7.ForeColor = Color.Blue;
			Marcacao7.Visible = true;
		}
		
		void Marcacao7DoubleClick(object sender, EventArgs e)
		{
			Marcacao7.Text = "O";
			this.Marcacao7.ForeColor = Color.Red;
			Marcacao7.Visible = true;
		}
		
		void Marcacao8Click(object sender, EventArgs e)
		{
			Marcacao8.Text = "x";
			this.Marcacao8.ForeColor = Color.Blue;
			Marcacao8.Visible = true;
		}
		
		void Marcacao8DoubleClick(object sender, EventArgs e)
		{
			Marcacao8.Text = "O";
			this.Marcacao8.ForeColor = Color.Red;
			Marcacao8.Visible = true;
		}
		
		void Marcacao9Click(object sender, EventArgs e)
		{
			Marcacao9.Text = "x";
			this.Marcacao9.ForeColor = Color.Blue;
			Marcacao9.Visible = true;
		}
		
		void Marcacao9DoubleClick(object sender, EventArgs e)
		{
			Marcacao9.Text = "O";
			this.Marcacao9.ForeColor = Color.Red;
			Marcacao9.Visible = true;
		}
		
		void Marcacao1Click(object sender, EventArgs e)
		{
			Marcacao1.Text = "x";
			this.Marcacao1.ForeColor = Color.Blue;
			Marcacao1.Visible = true;
		}
		
		void Marcacao1DoubleClick(object sender, EventArgs e)
		{
			Marcacao1.Text = "O";
			this.Marcacao1.ForeColor = Color.Red;
			Marcacao1.Visible = true;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}	
}
