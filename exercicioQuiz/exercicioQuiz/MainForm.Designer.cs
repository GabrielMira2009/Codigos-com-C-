/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 23/06/2025
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exercicioQuiz
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.labelD = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.labelPergunta = new System.Windows.Forms.Label();
			this.buttonD = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonB = new System.Windows.Forms.Button();
			this.buttonA = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.buttonReniciar = new System.Windows.Forms.Button();
			this.labelPontos = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.labelD);
			this.panel1.Controls.Add(this.labelC);
			this.panel1.Controls.Add(this.labelB);
			this.panel1.Controls.Add(this.labelA);
			this.panel1.Controls.Add(this.labelPergunta);
			this.panel1.Controls.Add(this.buttonD);
			this.panel1.Controls.Add(this.buttonC);
			this.panel1.Controls.Add(this.buttonB);
			this.panel1.Controls.Add(this.buttonA);
			this.panel1.Enabled = false;
			this.panel1.Location = new System.Drawing.Point(20, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(998, 349);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(666, 90);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(327, 258);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// labelD
			// 
			this.labelD.AutoSize = true;
			this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelD.Location = new System.Drawing.Point(105, 296);
			this.labelD.Name = "labelD";
			this.labelD.Size = new System.Drawing.Size(21, 22);
			this.labelD.TabIndex = 22;
			this.labelD.Text = "?";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelC.Location = new System.Drawing.Point(105, 241);
			this.labelC.MaximumSize = new System.Drawing.Size(600, 0);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(21, 22);
			this.labelC.TabIndex = 21;
			this.labelC.Text = "?";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelB.Location = new System.Drawing.Point(105, 186);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(21, 22);
			this.labelB.TabIndex = 20;
			this.labelB.Text = "?";
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelA.Location = new System.Drawing.Point(105, 131);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(21, 22);
			this.labelA.TabIndex = 19;
			this.labelA.Text = "?";
			// 
			// labelPergunta
			// 
			this.labelPergunta.AutoSize = true;
			this.labelPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPergunta.Location = new System.Drawing.Point(52, 30);
			this.labelPergunta.MaximumSize = new System.Drawing.Size(600, 0);
			this.labelPergunta.Name = "labelPergunta";
			this.labelPergunta.Size = new System.Drawing.Size(28, 22);
			this.labelPergunta.TabIndex = 18;
			this.labelPergunta.Text = "1-";
			// 
			// buttonD
			// 
			this.buttonD.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonD.Location = new System.Drawing.Point(52, 281);
			this.buttonD.Name = "buttonD";
			this.buttonD.Size = new System.Drawing.Size(47, 49);
			this.buttonD.TabIndex = 17;
			this.buttonD.Text = "D";
			this.buttonD.UseVisualStyleBackColor = false;
			this.buttonD.Click += new System.EventHandler(this.ButtonDClick);
			// 
			// buttonC
			// 
			this.buttonC.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.Location = new System.Drawing.Point(52, 226);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(47, 49);
			this.buttonC.TabIndex = 16;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = false;
			this.buttonC.Click += new System.EventHandler(this.ButtonCClick);
			// 
			// buttonB
			// 
			this.buttonB.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonB.Location = new System.Drawing.Point(52, 171);
			this.buttonB.Name = "buttonB";
			this.buttonB.Size = new System.Drawing.Size(47, 49);
			this.buttonB.TabIndex = 15;
			this.buttonB.Text = "B";
			this.buttonB.UseVisualStyleBackColor = false;
			this.buttonB.Click += new System.EventHandler(this.ButtonBClick);
			// 
			// buttonA
			// 
			this.buttonA.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonA.Location = new System.Drawing.Point(52, 116);
			this.buttonA.Name = "buttonA";
			this.buttonA.Size = new System.Drawing.Size(47, 49);
			this.buttonA.TabIndex = 14;
			this.buttonA.Text = "A";
			this.buttonA.UseVisualStyleBackColor = false;
			this.buttonA.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(20, 421);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 49);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(73, 421);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(47, 49);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button3.Enabled = false;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(126, 421);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(47, 49);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button4.Enabled = false;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(179, 421);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(47, 49);
			this.button4.TabIndex = 4;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button5.Enabled = false;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(232, 421);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(47, 49);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button6.Enabled = false;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(285, 421);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(47, 49);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button7.Enabled = false;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(338, 421);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(47, 49);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button8.Enabled = false;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(391, 421);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(47, 49);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button9.Enabled = false;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(444, 421);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(47, 49);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button10.Enabled = false;
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(497, 421);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(56, 49);
			this.button10.TabIndex = 10;
			this.button10.Text = "10";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// buttonReniciar
			// 
			this.buttonReniciar.BackColor = System.Drawing.Color.Gold;
			this.buttonReniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonReniciar.Location = new System.Drawing.Point(860, 421);
			this.buttonReniciar.Name = "buttonReniciar";
			this.buttonReniciar.Size = new System.Drawing.Size(158, 40);
			this.buttonReniciar.TabIndex = 11;
			this.buttonReniciar.Text = "Reniciar";
			this.buttonReniciar.UseVisualStyleBackColor = false;
			this.buttonReniciar.Click += new System.EventHandler(this.ButtonReniciarClick);
			// 
			// labelPontos
			// 
			this.labelPontos.AutoSize = true;
			this.labelPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPontos.Location = new System.Drawing.Point(629, 422);
			this.labelPontos.Name = "labelPontos";
			this.labelPontos.Size = new System.Drawing.Size(108, 29);
			this.labelPontos.TabIndex = 12;
			this.labelPontos.Text = "Pontos: ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1044, 499);
			this.Controls.Add(this.labelPontos);
			this.Controls.Add(this.buttonReniciar);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "exercicioQuiz";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonA;
		private System.Windows.Forms.Button buttonB;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonD;
		private System.Windows.Forms.Label labelPergunta;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelD;
		private System.Windows.Forms.Label labelPontos;
		private System.Windows.Forms.Button buttonReniciar;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
	}
}
