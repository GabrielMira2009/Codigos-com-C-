
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioTemperatura
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		string nomeImage = "cirty.jpg";
		string nomeImage2 = "boy.png";
		
		void Button1Click(object sender, EventArgs e)
		{
			int Temp = int.Parse(txtTemp.Text);
			if ( Temp < 0)
			{
				estado.Text = "Frio Congelante";
				this.BackColor = Color.LightBlue;
				nomeImage = "cold.jpg";
				nomeImage2 = "frio.png";
				imgTemp.Load(nomeImage2);
				imgFundo.Load(nomeImage);
			}
			 else  
			 	if(Temp <=10)
			 {estado.Text = "Muito Frio";
            this.BackColor = Color.LightBlue;
            nomeImage = "friozin.jpg";
            nomeImage2 = "friozinho.jpg";
            imgFundo.Load(nomeImage2);
            imgTemp.Load(nomeImage);
			 	}
			else
			{ if (Temp <=18){
					estado.Text = "Frio";
					this.BackColor = Color.Blue;
					nomeImage = "friozin.jpg";
					nomeImage2 = "friozinho.jpg";
					imgFundo.Load(nomeImage2);
					imgTemp.Load(nomeImage);
				}
				else{
					if( Temp <=24){
						estado.Text = "Agradavel";
						this.BackColor = Color.LightGreen;
						nomeImage = "park.jpg";
						nomeImage2 = "relax.png";
						imgFundo.Load(nomeImage);
						imgTemp.Load(nomeImage2);
					}
					else {
						if ( Temp <=32){
						estado.Text = "Calor";
						this.BackColor = Color.Yellow;
						nomeImage = "beach.jpg";
						nomeImage2 = "quente.png";
						imgFundo.Load(nomeImage);
						imgTemp.Load(nomeImage2);}
					else {
						if ( Temp <=38){
						estado.Text = "Muito Calor";
						this.BackColor = Color.Orange;
						nomeImage = "beach.jpg";
						nomeImage2 = "quente.png";
						imgFundo.Load(nomeImage);
						imgTemp.Load(nomeImage2);}
						else{
					if( Temp >38){
						estado.Text = "Calor Escaldante";
						this.BackColor = Color.Red;
						nomeImage = "beach.jpg";
						nomeImage2 = "quente.png";
						imgFundo.Load(nomeImage);
						imgTemp.Load(nomeImage2);
					}}
				}
			}
		}
		}
	}
	}
}