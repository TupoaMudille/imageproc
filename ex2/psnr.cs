/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 26.11.2022
 * Время: 12:51
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ex2
{
	/// <summary>
	/// Description of psnr.
	/// </summary>
	internal class psnr
	{
		protected static string testPicPath = "C:\\Users\\tanap\\Desktop\\test_ex2\\";

        public psnr(string orImName, string compImName)
        {
            MessageBox.Show("psnr: " + calcMetrPsnr(
                new Bitmap(testPicPath + orImName),
                new Bitmap(testPicPath + compImName)
                ));
        }

        private double calcMetrPsnr(Bitmap im, Bitmap compIm)
        {
            double result;

            if (im.Size != compIm.Size)
            {
                result = -1.0f;
                return result;
            }

            double mse = calcMse(im, compIm);
            result = (double)(20 * Math.Log10(255.0f / Math.Sqrt(mse)));
            return result;
        }

        private double calcMse(Bitmap im, Bitmap compIm)
        {
            double sumR = 0f;
            double sumG = 0f;
            double sumB = 0f;

            for (int i = 0; i < im.Width; i++)
            {
                for (int j = 0; j < im.Height; j++)
                {
                    sumR += (double)Math.Pow((int)compIm.GetPixel(i, j).R - (int)im.GetPixel(i, j).R, 2);
                    sumG += (double)Math.Pow((int)compIm.GetPixel(i, j).G - (int)im.GetPixel(i, j).G, 2);
                    sumB += (double)Math.Pow((int)compIm.GetPixel(i, j).B - (int)im.GetPixel(i, j).B, 2);
                }
            }
            return (sumR + sumG + sumB) / (im.Width * im.Height) / 3;
        }
	}
}
