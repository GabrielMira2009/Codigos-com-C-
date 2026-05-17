
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioArquivos
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
		
			InitializeComponent();
			
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			richTextBox1.SaveFile("teste.rtf");
			MessageBox.Show("Arquivo salvo com sucesso!");
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.LoadFile("teste.rtf");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Italic ? 
                    currentFont.Style & ~FontStyle.Italic : 
                    currentFont.Style | FontStyle.Italic;

                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }


}
		
		void Button5Click(object sender, EventArgs e)
		{
				if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Bold ? 
                    currentFont.Style & ~FontStyle.Bold : 
                    currentFont.Style | FontStyle.Bold;

                richTextBox1.SelectionFont = new Font(currentFont, newStyle);
            }
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			    ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			 FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
		}
		
		
		
	
}
		}
		