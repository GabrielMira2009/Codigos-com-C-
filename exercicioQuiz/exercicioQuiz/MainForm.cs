/*
 * Created by SharpDevelop.
 * User: Aluno
 * Date: 23/06/2025
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace exercicioQuiz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
					
		}
		
	//Variáves Globais
	string alternativaCorreta = "X";
	int pontos = 0;
	int contadorPerguntas = 0;
	int totalPerguntas = 10;
	string nomeImagem = "quiz.png";
	
	//Contador
	void VerificarFimDoQuiz()
{
	if (contadorPerguntas == totalPerguntas)
	{
		nomeImagem = "finalMessage.jpg";
		pictureBox1.Load(nomeImagem);
		MessageBox.Show("Quiz finalizado! Pontuação final: " + pontos + " pontos.");
		
	}
}
	
	//Alternativas
	void ButtonAClick(object sender, EventArgs e)
		{
		if (alternativaCorreta == "A")
		{
			pictureBox1.Load(nomeImagem);
			MessageBox.Show("Parabéns, você acertou!");
			pontos++;
			labelPontos.Text = "Pontos: " + pontos;
			
		}
		else{
			MessageBox.Show("Você errou!");
		}
		
		panel1.Enabled = false;
		
		contadorPerguntas++;
		VerificarFimDoQuiz();
		
		}
	
	void ButtonBClick(object sender, EventArgs e)
		{
		if (alternativaCorreta == "B")
		{
			pictureBox1.Load(nomeImagem);
			MessageBox.Show("Parabéns, você acertou!");
			pontos++;
			labelPontos.Text = "Pontos: " + pontos;
			
		}
		else{
			MessageBox.Show("Você errou!");
		}
		
		panel1.Enabled = false;
		
		contadorPerguntas++;
		VerificarFimDoQuiz();
		}
	
	
	void ButtonCClick(object sender, EventArgs e)
		{
		if (alternativaCorreta == "C"){
			pictureBox1.Load(nomeImagem);
			MessageBox.Show("Parabéns, você acertou!");
			pontos++;
			labelPontos.Text = "Pontos: " + pontos;
			
		}
		else{
			MessageBox.Show("Você errou!");
		}
		
		panel1.Enabled = false;
		
		contadorPerguntas++;
		VerificarFimDoQuiz();
		}
	
	void ButtonDClick(object sender, EventArgs e)
		{
		if (alternativaCorreta == "D")
		{
			pictureBox1.Load(nomeImagem);
			MessageBox.Show("Parabéns, você acertou!");
			pontos++;
			labelPontos.Text = "Pontos: " + pontos;
			
		}
		else{
			MessageBox.Show("Você errou!");
		}
		
		panel1.Enabled = false;
		
		contadorPerguntas++;
		VerificarFimDoQuiz();
		}
	
	
	//Perguntas
	
	//Questão 1
		void Button1Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "1 Qual linguagem é amplamente utilizada para desenvolvimento web, tanto no front-end " +
				"quanto no back-end, e possui uma vasta gama de bibliotecas e frameworks como React e Node.js?";
			labelA.Text = "Python";
			labelB.Text = "Java";
			labelC.Text = "JavaScript";
			labelD.Text = "C++";
			alternativaCorreta ="C";
			nomeImagem = "javascript.png";
			
			panel1.Enabled = true;
			button1.Enabled = false;
			button2.Enabled = true;
		}
	
	
	//Questão 2
		void Button2Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "2. Qual linguagem é conhecida por sua sintaxe simples e clara, sendo ideal para iniciantes e amplamente utilizada em ciência de dados e aprendizado de máquina?";
			labelA.Text = "C#";
			labelB.Text = "Python";
			labelC.Text = "PHP";
			labelD.Text = "Ruby";
			alternativaCorreta = "B";
			nomeImagem = "python.png";
			
			panel1.Enabled = true;
			button2.Enabled = false;
			button3.Enabled = true;
		}
	
	
	//Questão 3
		void Button3Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "3. Qual linguagem é amplamente utilizada no desenvolvimento de aplicações corporativas e " +
				"sistemas Android, destacando-se por sua robustez e portabilidade?";
			labelA.Text = "Java";
			labelB.Text = "Swift";
			labelC.Text = "Go";
			labelD.Text = "Kotlin";
			alternativaCorreta = "A";
			nomeImagem = "java.png";
			
			panel1.Enabled = true;
			button3.Enabled = false;
			button4.Enabled = true;
		}
	
	
	//Questão 4
	void Button4Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "4. Qual linguagem, desenvolvida pela Microsoft, é popular no desenvolvimento de aplicações Windows e jogos, especialmente com o uso do Unity?";
			labelA.Text = "JavaScript";
			labelB.Text = "C#";
			labelC.Text = "PHP";
			labelD.Text = "TypeScript";
			alternativaCorreta = "B";
			nomeImagem = "c#.png";
			
			panel1.Enabled = true;
			button4.Enabled = false;
			button5.Enabled = true;
		}
	
	
	
	//Questão 5
		void Button5Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "5. Em qual área de desenvolvimento a linguagem Rust tem ganhado destaque, devido à sua confiabilidade, segurança de memória e desempenho?";
			labelA.Text = "Desenvolvimento de jogos casuais em navegador ";
			labelB.Text = "Criação de sites com conteúdo dinâmico";
			labelC.Text = "Desenvolvimento de sistemas embarcados e software de baixo nível";
			labelD.Text = "Prototipação rápida de aplicativos móveis ";
			alternativaCorreta = "C";
			nomeImagem = "ds.png";
			
			panel1.Enabled = true;
			button5.Enabled = false;
			button6.Enabled = true;
		}
	
	
	//Questão 6
		void Button6Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "6. Qual linguagem, criada pelo Google, é conhecida por sua simplicidade e eficiência em sistemas distribuídos e aplicações em nuvem?";
			labelA.Text = "Go";
			labelB.Text = "Scala";
			labelC.Text = "Ruby";
			labelD.Text = "Perl";
			alternativaCorreta = "A";
			nomeImagem = "go.png";
			
			panel1.Enabled = true;
			button6.Enabled = false;
			button7.Enabled = true;
		}
	
	
	//Questão 7
		void Button7Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "7. Qual linguagem é amplamente utilizada para o desenvolvimento de sites dinâmicos e aplicativos web, sendo a base de plataformas como WordPress?";
			labelA.Text = "JavaScript";
			labelB.Text = "PHP";
			labelC.Text = "Python";
			labelD.Text = "C#";
			alternativaCorreta = "B";
			nomeImagem = "php.png";
			
			panel1.Enabled = true;
			button7.Enabled = false;
			button8.Enabled = true;
		}
	
	
	//Questão 8
		void Button8Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "8. Qual linguagem é uma extensão do JavaScript que adiciona tipagem estática, ajudando a evitar erros comuns durante o desenvolvimento de aplicações web?";
			labelA.Text = "TypeScript";
			labelB.Text = "CoffeeScript";
			labelC.Text = "Dart";
			labelD.Text = "Elm";
			alternativaCorreta = "A";
			nomeImagem = "typescript.png";
			
			panel1.Enabled = true;
			button8.Enabled = false;
			button9.Enabled = true;
		}
	
	
	//Questão 9
		void Button9Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "9. Qual linguagem é usada principalmente para estruturar o conteúdo de páginas da web, enquanto outra é usada para estilizar esse conteúdo, controlando cores, fontes e layout?";
			labelA.Text = "JavaScript e PHP";
			labelB.Text = "HTML e CSS";
			labelC.Text = "Python e Ruby";
			labelD.Text = "C# e TypeScript ";
			alternativaCorreta = "B";
			nomeImagem = "htmlcss.png";
			
			panel1.Enabled = true;
			button9.Enabled = false;
			button10.Enabled = true;
		}
	
	
	//Questão 10
		void Button10Click(object sender, EventArgs e)
		{
			pictureBox1.Load("quiz.png");
			labelPergunta.Text = "10.  Qual linguagem é frequentemente utilizada em sistemas financeiros e bancários devido à sua confiabilidade, escalabilidade e longa existência no mercado?";
			labelA.Text = "Ruby";
			labelB.Text = "COBOL";
			labelC.Text = "Swift";
			labelD.Text = "Perl";
			alternativaCorreta = "B";
			nomeImagem = "cobol.png";
			
			panel1.Enabled = true;
			button10.Enabled = false;
			
				
		}
		
		
	
	//Reniciar
		void ButtonReniciarClick(object sender, EventArgs e)
		{
			Application.Restart();
		}
		
	
	}
}
