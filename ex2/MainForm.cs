/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 04.10.2022
 * Время: 13:38
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ex2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Bitmap image;
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
		
		
		int Slice(int val, int min, int max){
			if (val<min) return min;
			if (val>max) return max;
			return val;}
		
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
		void globalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			globalfilt globalfilt = new globalfilt();
			Bitmap resultIm = globalfilt.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void niblackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			niblatb nb = new niblatb();
			Bitmap resultIm = nb.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void globalHistToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			binhist bhist = new binhist();
			Bitmap resultIm = bhist.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			grayscale graysc = new grayscale();
			Bitmap resultIm = graysc.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void blurToolStripMenuItem_Click(object sender, EventArgs e)
		{
			blur blure = new blur();
			Bitmap resultIm = blure.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void autocontrastToolStripMenuItem_Click(object sender, EventArgs e)
		{
			autocontrast autoc = new autocontrast();
			Bitmap resultIm = autoc.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void histautocontrastToolStripMenuItem_Click(object sender, EventArgs e)
		{
			histautocontrast histautoc = new histautocontrast();
			Bitmap resultIm = histautoc.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void gaussToolStripMenuItem_Click(object sender, EventArgs e)
		{
		 
        
            Bitmap res = (Bitmap)image.Clone();
            var rnd = new Random();
            int noise = 60;

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = res.GetPixel(x, y);
                    var addnoise = (rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() + rnd.NextDouble() - 2) * noise;
                    Color newColor = Color.FromArgb(Slice(color.R + (int)addnoise, 0, 255),
                                                    Slice(color.G + (int)addnoise, 0, 255),
                                                    Slice(color.B + (int)addnoise, 0, 255));
                    res.SetPixel(x, y, newColor);
                }

            

            image = res;
            pictureBox1.Image = image;
            pictureBox1.Refresh();
            
        
			
		}
		void medianToolStripMenuItem_Click(object sender, EventArgs e)
		{
			median med = new median();
			Bitmap resultIm = med.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void saltToolStripMenuItem_Click(object sender, EventArgs e)
		{	
			Random rand = new Random();
			int countPix = rand.Next((int)image.Height/(image.Height/2),(int)image.Height*image.Width/(image.Height+image.Width));
			for (int i=0;i<countPix;i++)
			{	
				int M = rand.Next(0,image.Width);
				int N = rand.Next(0,image.Height);
				int Mean = rand.Next(0,2);
				if ((Mean==0))
					image.SetPixel(M,N,Color.FromArgb(0,0,0));
				if (Mean==1) 
					image.SetPixel(M,N,Color.FromArgb(255,255,255));
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
		void notlocalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			blur gss = new blur();
			Bitmap resultIm = gss.procIm(image);
			pictureBox1.Image = resultIm;
			pictureBox1.Refresh();
		}
		void psnrToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//new psnr("cat.jpeg", "cat_gauss_notlocal.png");
			new psnr("cat.jpeg", "cat_sp_med.png");
		}
		void ssimToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//new ssim("cat.jpeg", "cat_gauss_notlocal.png");
			new ssim("cat.jpeg", "cat_sp_med.png");
		}
		void panel1_Paint(object sender, PaintEventArgs e)
		{	/*
			//string testPicPath = "C:\\Users\\tanap\\Desktop\\test_ex2\\test_noise.png";
			string testPicPath = "C:\\Users\\tanap\\Desktop\\test_ex2\\cat_gauss.png";
			//string testPicPath = "C:\\Users\\tanap\\Desktop\\test_ex2\\cat.jpeg";
			Bitmap ar = new Bitmap(testPicPath);
			Graphics gr = e.Graphics;
            Pen pr = new Pen(Color.Red,1);
			int[] gistr = new int[256];

			for(int i = 0; i<256; i++)
			{
				gistr[i] = 0;

			}
			for(int i = 0; i<ar.Width; i++)
				{
				for(int j =0; j<ar.Height; j++)
				{
					gistr[ar.GetPixel(i, j).R]++;
				
					
				}
				Point p1 = new Point(i,0);// первая точка
					Point p2 = new Point(i,gistr[i]);// вторая точка
              		gr.DrawLine(pr, p1, p2);

			}
			*/
		}

		
	}
}
