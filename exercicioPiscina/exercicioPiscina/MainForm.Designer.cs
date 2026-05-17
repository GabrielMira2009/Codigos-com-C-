/*
 * Criado por SharpDevelop.
 * Usuário: Aluno
 * Data: 12/05/2025
 * Hora: 14:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace exercicioPiscina
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
			this.button1 = new System.Windows.Forms.Button();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLargura = new System.Windows.Forms.TextBox();
			this.txtComprimento = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtVolume = new System.Windows.Forms.TextBox();
			this.txtPreco = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(380, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 51);
			this.button1.TabIndex = 0;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// txtAltura
			// 
			this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAltura.Location = new System.Drawing.Point(66, 100);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(100, 22);
			this.txtAltura.TabIndex = 1;
			// 
			// Label1
			// 
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.Location = new System.Drawing.Point(66, 64);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(100, 23);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Altura";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(275, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Largura";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(478, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Comprimento";
			// 
			// txtLargura
			// 
			this.txtLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLargura.Location = new System.Drawing.Point(275, 100);
			this.txtLargura.Name = "txtLargura";
			this.txtLargura.Size = new System.Drawing.Size(100, 22);
			this.txtLargura.TabIndex = 5;
			// 
			// txtComprimento
			// 
			this.txtComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtComprimento.Location = new System.Drawing.Point(478, 100);
			this.txtComprimento.Name = "txtComprimento";
			this.txtComprimento.Size = new System.Drawing.Size(121, 22);
			this.txtComprimento.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-30, 272);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(279, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// txtVolume
			// 
			this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtVolume.Location = new System.Drawing.Point(318, 309);
			this.txtVolume.Name = "txtVolume";
			this.txtVolume.Size = new System.Drawing.Size(121, 22);
			this.txtVolume.TabIndex = 8;
			// 
			// txtPreco
			// 
			this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPreco.Location = new System.Drawing.Point(478, 309);
			this.txtPreco.Name = "txtPreco";
			this.txtPreco.Size = new System.Drawing.Size(121, 22);
			this.txtPreco.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(318, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Volume";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(478, 272);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Preço(R$)";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(403, 309);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "m³";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(143, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "m";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(352, 102);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 20);
			this.label8.TabIndex = 14;
			this.label8.Text = "m";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.White;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(576, 102);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 20);
			this.label9.TabIndex = 15;
			this.label9.Text = "m";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(675, 461);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPreco);
			this.Controls.Add(this.txtVolume);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtComprimento);
			this.Controls.Add(this.txtLargura);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtAltura);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "exercicioPiscina";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPreco;
		private System.Windows.Forms.TextBox txtVolume;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtComprimento;
		private System.Windows.Forms.TextBox txtLargura;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox txtAltura;
		private System.Windows.Forms.Button button1;
	}
}
