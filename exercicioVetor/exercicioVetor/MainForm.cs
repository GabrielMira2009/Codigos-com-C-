
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioVetor
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}

		
		void Button1Click(object sender, EventArgs e)
		{
			
			int[] v ={4,2,7,9,5,8,1,0,6,3};
			for(int i=0;i<10;i++)
			{
				listBox1.Items.Add(v[i]);
			}
			}
			
		
		void Button2Click(object sender, EventArgs e)
		{
			int[] v2 ={4,2,7,9,5,8,1,0,6,3};
			for(int i=0; i<10; i++)
			
				listBox2.Items.Add(v2[v2[i]]);
			}
		}
		}
	
