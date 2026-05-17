
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioSomaV
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		Random r = new Random ();
		
		int[] vet_A = new int[50];
		int[] vet_B = new int[50];
		int[]vet_C = new int[50];
			
		void Button1Click(object sender, EventArgs e)
		{
		
				for(int i = 0; i < 50; i++){
				int numA = r.Next(0, 101);
				int numB = r.Next(0, 101);
				vet_A[i] = numA;
				vet_B[i] = numB;
				vet_C[i] = vet_A[i] + vet_B[i];
				listBox1.Items.Clear();
				listBox2.Items.Clear();
				listBox3.Items.Clear();
				
				for(int i2 = 0; i2 < 50; i2++)
				{
					listBox1.Items.Add(vet_A[i2]);
					listBox2.Items.Add(vet_B[i2]);
					listBox3.Items.Add(vet_C[i2]);
					
				}
				
			
		
			
			}
			
		}
	}
}
