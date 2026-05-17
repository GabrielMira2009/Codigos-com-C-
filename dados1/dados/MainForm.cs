/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 08/09/2025
 * Time: 13:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace dados
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
		string[] v = new string[21];
		int indice =0;
		
		void Button2Click(object sender, EventArgs e)
		{
			if(indice <v.Length){
				v[indice]= textBox1.Text.ToString();
				indice++;
				textBox1.Clear();
				listBox1.Items.Clear();
			for(int i=0;i<indice;i++){
				listBox1.Items.Add("Posição " + i + ": " + v[i]);
			}
			}
				else{
				button2.Enabled = false;
				MessageBox.Show("Vetor cheio,obg");
			}
		}
	}
}
