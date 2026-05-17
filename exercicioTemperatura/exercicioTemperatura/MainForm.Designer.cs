/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 28/07/2025
 * Time: 13:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace exercicioTemperatura
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
			this.imgFundo = new System.Windows.Forms.PictureBox();
			this.imgTemp = new System.Windows.Forms.PictureBox();
			this.texto = new System.Windows.Forms.Label();
			this.estado = new System.Windows.Forms.Label();
			this.txtTemp = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// imgFundo
			// 
			this.imgFundo.Image = ((System.Drawing.Image)(resources.GetObject("imgFundo.Image")));
			this.imgFundo.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgFundo.InitialImage")));
			this.imgFundo.Location = new System.Drawing.Point(45, 57);
			this.imgFundo.Name = "imgFundo";
			this.imgFundo.Size = new System.Drawing.Size(714, 344);
			this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgFundo.TabIndex = 0;
			this.imgFundo.TabStop = false;
			// 
			// imgTemp
			// 
			this.imgTemp.BackColor = System.Drawing.Color.Transparent;
			this.imgTemp.Image = ((System.Drawing.Image)(resources.GetObject("imgTemp.Image")));
			this.imgTemp.Location = new System.Drawing.Point(521, 57);
			this.imgTemp.Name = "imgTemp";
			this.imgTemp.Size = new System.Drawing.Size(238, 343);
			this.imgTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgTemp.TabIndex = 1;
			this.imgTemp.TabStop = false;
			// 
			// texto
			// 
			this.texto.AutoSize = true;
			this.texto.BackColor = System.Drawing.Color.Transparent;
			this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.texto.Location = new System.Drawing.Point(64, 86);
			this.texto.Name = "texto";
			this.texto.Size = new System.Drawing.Size(392, 26);
			this.texto.TabIndex = 2;
			this.texto.Text = "Qual é a temperatura da sua cidade";
			// 
			// estado
			// 
			this.estado.AutoSize = true;
			this.estado.BackColor = System.Drawing.Color.Transparent;
			this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.estado.Location = new System.Drawing.Point(64, 135);
			this.estado.Name = "estado";
			this.estado.Size = new System.Drawing.Size(25, 26);
			this.estado.TabIndex = 3;
			this.estado.Text = "?";
			// 
			// txtTemp
			// 
			this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTemp.Location = new System.Drawing.Point(165, 216);
			this.txtTemp.Name = "txtTemp";
			this.txtTemp.Size = new System.Drawing.Size(189, 30);
			this.txtTemp.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gainsboro;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(165, 292);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 59);
			this.button1.TabIndex = 5;
			this.button1.Text = "Confirmar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(837, 493);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtTemp);
			this.Controls.Add(this.estado);
			this.Controls.Add(this.texto);
			this.Controls.Add(this.imgTemp);
			this.Controls.Add(this.imgFundo);
			this.Name = "MainForm";
			this.Text = "exercicioTemperatura";
			((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgTemp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTemp;
		private System.Windows.Forms.Label estado;
		private System.Windows.Forms.Label texto;
		private System.Windows.Forms.PictureBox imgTemp;
		private System.Windows.Forms.PictureBox imgFundo;
	}
}
