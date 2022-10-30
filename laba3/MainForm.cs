/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 30.10.2022
 * Время: 16:27
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba3
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
		
		void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK){
				image = new Bitmap(dialog.FileName);
				pictureBox1.Image = image;
				pictureBox1.Refresh();}
		}
		void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK){
				pictureBox1.Image.Save(dialog.FileName += ".png");
				}
		}
		
		
		Bitmap image;
		int Slice(int val, int min, int max){
			if (val<min) return min;
			if (val>max) return max;
			return val;}
		
		void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			int countPix = rand.Next((int)image.Height/(image.Height/2),(int)image.Height*image.Width/(image.Height+image.Width));
			for (int i=0;i<countPix;i++)
				{	
					int M = rand.Next(0,image.Width);
					int N = rand.Next(0,image.Height);
					int Mean = rand.Next(0,1);
					if ((Mean==0))
						image.SetPixel(M,N,Color.FromArgb(0,0,0));
				}
			for (int i = 0; i<image.Width; i++) 
				for (int j=0; j<image.Height; j++)
					{
						Color sourceCol = image.GetPixel(i,j);
						image.SetPixel(i,j,Color.FromArgb(sourceCol.R,sourceCol.G,sourceCol.B));
					}
			pictureBox1.Image = image;
			pictureBox1.Refresh();
		}
		void expToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//ЕСЛИ ДЛЯ ВСЕЙ КАРТИНКИ МЫ МЕНЯЕМ ПИКСЕЛИ
			/*Random rand = new Random();
			for (int i = 0; i<image.Width; i++) 
				for (int j=0; j<image.Height; j++)
				{
					Color sourceCol = image.GetPixel(i,j);
					image.SetPixel(i,j,Color.FromArgb(Slice((int)(sourceCol.R+Math.Log10(1-rand.NextDouble())*255),0,255),Slice((int)(sourceCol.G+Math.Log(1-rand.NextDouble())*255),0,255),Slice((int)(sourceCol.B+Math.Log(1-rand.NextDouble())*255),0,255)));
				}
			pictureBox1.Image = image;
			pictureBox1.Refresh();
			*/
			
			//ЕСЛИ ТОЛЬКО ДЛЯ РАНДОМНЫХ ПИКСЕЛЕЙ
			Random rand = new Random();
			int countPix = rand.Next((int)image.Height/(image.Height/2),(int)image.Height*image.Width/(image.Height+image.Width));
			for (int i=0;i<countPix;i++)
				{	
					int M = rand.Next(0,image.Width);
					int N = rand.Next(0,image.Height);
					int Mean = rand.Next(0,1);
					if ((Mean==0)){
						Color sourceCol = image.GetPixel(M,N);
						image.SetPixel(M,N,Color.FromArgb(Slice((int)(sourceCol.R+Math.Log10(1-rand.NextDouble())*255),0,255),Slice((int)(sourceCol.G+Math.Log(1-rand.NextDouble())*255),0,255),Slice((int)(sourceCol.B+Math.Log(1-rand.NextDouble())*255),0,255)));
						}
				}
			for (int i = 0; i<image.Width; i++) 
				for (int j=0; j<image.Height; j++)
					{
						Color sourceCol = image.GetPixel(i,j);
						image.SetPixel(i,j,Color.FromArgb(sourceCol.R,sourceCol.G,sourceCol.B));
						}
			pictureBox1.Image = image;
			pictureBox1.Refresh();
		}
		void gaussToolStripMenuItem_Click(object sender, EventArgs e)
		{
			gaussfil gauss = new gaussfil();
			gauss.createGaussKernel(3, 3);
			Bitmap resultIm = gauss.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		
		
		
	}
}
