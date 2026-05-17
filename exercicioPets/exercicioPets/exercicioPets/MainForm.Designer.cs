/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 04/08/2025
 * Time: 13:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exercicioPets
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.inicial = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFilho = new System.Windows.Forms.TextBox();
			this.txtAdulto = new System.Windows.Forms.TextBox();
			this.txtGravido = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.estFilho = new System.Windows.Forms.Label();
			this.estAdulto = new System.Windows.Forms.Label();
			this.estGravido = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.inicial)).BeginInit();
			this.SuspendLayout();
			// 
			// inicial
			// 
			this.inicial.Image = ((System.Drawing.Image)(resources.GetObject("inicial.Image")));
			this.inicial.Location = new System.Drawing.Point(722, 80);
			this.inicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.inicial.Name = "inicial";
			this.inicial.Size = new System.Drawing.Size(428, 390);
			this.inicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.inicial.TabIndex = 0;
			this.inicial.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Goldenrod;
			this.label1.Location = new System.Drawing.Point(281, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mafagafos";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Goldenrod;
			this.label2.Location = new System.Drawing.Point(24, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 31);
			this.label2.TabIndex = 2;
			this.label2.Text = "Filhote";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Goldenrod;
			this.label3.Location = new System.Drawing.Point(183, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 31);
			this.label3.TabIndex = 3;
			this.label3.Text = "Adulto";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Goldenrod;
			this.label4.Location = new System.Drawing.Point(357, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 31);
			this.label4.TabIndex = 4;
			this.label4.Text = "Grávido";
			// 
			// txtFilho
			// 
			this.txtFilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilho.Location = new System.Drawing.Point(23, 123);
			this.txtFilho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFilho.Name = "txtFilho";
			this.txtFilho.Size = new System.Drawing.Size(105, 26);
			this.txtFilho.TabIndex = 5;
			// 
			// txtAdulto
			// 
			this.txtAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdulto.Location = new System.Drawing.Point(183, 123);
			this.txtAdulto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAdulto.Name = "txtAdulto";
			this.txtAdulto.Size = new System.Drawing.Size(105, 26);
			this.txtAdulto.TabIndex = 6;
			// 
			// txtGravido
			// 
			this.txtGravido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGravido.Location = new System.Drawing.Point(356, 123);
			this.txtGravido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGravido.Name = "txtGravido";
			this.txtGravido.Size = new System.Drawing.Size(105, 26);
			this.txtGravido.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SandyBrown;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(797, 498);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(279, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "Comprar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Goldenrod;
			this.label5.Location = new System.Drawing.Point(14, 428);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 31);
			this.label5.TabIndex = 9;
			this.label5.Text = "Estoque:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Goldenrod;
			this.label7.Location = new System.Drawing.Point(284, 453);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 31);
			this.label7.TabIndex = 11;
			this.label7.Text = "Adulto";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Goldenrod;
			this.label6.Location = new System.Drawing.Point(418, 453);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 31);
			this.label6.TabIndex = 12;
			this.label6.Text = "Grávido";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Goldenrod;
			this.label8.Location = new System.Drawing.Point(144, 453);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 31);
			this.label8.TabIndex = 13;
			this.label8.Text = "Filhote";
			// 
			// estFilho
			// 
			this.estFilho.AutoSize = true;
			this.estFilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estFilho.ForeColor = System.Drawing.Color.White;
			this.estFilho.Location = new System.Drawing.Point(153, 480);
			this.estFilho.Name = "estFilho";
			this.estFilho.Size = new System.Drawing.Size(60, 25);
			this.estFilho.TabIndex = 14;
			this.estFilho.Text = "7000";
			// 
			// estAdulto
			// 
			this.estAdulto.AutoSize = true;
			this.estAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estAdulto.ForeColor = System.Drawing.Color.White;
			this.estAdulto.Location = new System.Drawing.Point(284, 480);
			this.estAdulto.Name = "estAdulto";
			this.estAdulto.Size = new System.Drawing.Size(72, 25);
			this.estAdulto.TabIndex = 15;
			this.estAdulto.Text = "12000";
			// 
			// estGravido
			// 
			this.estGravido.AutoSize = true;
			this.estGravido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estGravido.ForeColor = System.Drawing.Color.White;
			this.estGravido.Location = new System.Drawing.Point(438, 480);
			this.estGravido.Name = "estGravido";
			this.estGravido.Size = new System.Drawing.Size(48, 25);
			this.estGravido.TabIndex = 16;
			this.estGravido.Text = "500";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Goldenrod;
			this.label9.Location = new System.Drawing.Point(187, 296);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 25);
			this.label9.TabIndex = 17;
			this.label9.Text = "Preço total";
			// 
			// txtPreco
			// 
			this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreco.Location = new System.Drawing.Point(176, 334);
			this.txtPreco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(138, 26);
			this.txtPreco.TabIndex = 18;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(24, 215);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(105, 26);
			this.textBox1.TabIndex = 24;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(187, 221);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(105, 26);
			this.textBox2.TabIndex = 23;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(356, 221);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(105, 26);
			this.textBox3.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Goldenrod;
			this.label10.Location = new System.Drawing.Point(336, 188);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(145, 25);
			this.label10.TabIndex = 21;
			this.label10.Text = "Preço grávido";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Goldenrod;
			this.label11.Location = new System.Drawing.Point(176, 188);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 25);
			this.label11.TabIndex = 20;
			this.label11.Text = "Preço adulto";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Goldenrod;
			this.label12.Location = new System.Drawing.Point(12, 188);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(132, 25);
			this.label12.TabIndex = 19;
			this.label12.Text = "Preço filhote";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(569, 123);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(210, 75);
			this.label13.TabIndex = 25;
			this.label13.Text = ".";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(1162, 603);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.estGravido);
			this.Controls.Add(this.estAdulto);
			this.Controls.Add(this.estFilho);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtGravido);
			this.Controls.Add(this.txtAdulto);
			this.Controls.Add(this.txtFilho);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.inicial);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "exercicioPets";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.inicial)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label estGravido;
		private System.Windows.Forms.Label estAdulto;
		private System.Windows.Forms.Label estFilho;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtGravido;
		private System.Windows.Forms.TextBox txtAdulto;
		private System.Windows.Forms.TextBox txtFilho;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox inicial;
	}
}
