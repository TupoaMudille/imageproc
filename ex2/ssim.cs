/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 26.11.2022
 * Время: 13:09
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;
using System.Windows.Forms;
namespace ex2
{
	/// <summary>
	/// Description of ssim.
	/// </summary>
	internal class ssim
	{
		protected static string testPicPath = "C:\\Users\\tanap\\Desktop\\test_ex2\\";

        public ssim(string orImName, string compImName)
        {
            MessageBox.Show("ssim: " + calcSsim(
                new Bitmap(testPicPath + orImName),
                new Bitmap(testPicPath + compImName)
                ));
        }

        private double calcSsim(Bitmap im, Bitmap compIm)
        {
            double result;

            if (im.Size != compIm.Size)
            {
                result = -1.0f;
                return result;
            }

            double k1 = 0.01f, k2 = 0.03f;
            double c1 = (double)Math.Pow(255f * k1, 2);
            double c2 = (double)Math.Pow(255f * k2, 2);

            double avgBrX = calcAvBr(compIm);
            double avgBrY = calcAvBr(im);

            double disX = calcDis(compIm, avgBrX);
            double disY = calcDis(im, avgBrY);

            double covXY = calcCov(compIm, avgBrX, im, avgBrY);

            result = (2 * avgBrX * avgBrY + c1) * (2 * covXY + c2) / (double)(Math.Pow(avgBrX, 2) + Math.Pow(avgBrY, 2) + c1)
                / (double)(Math.Pow(disX, 2) + Math.Pow(disY, 2) + c2); ;
            return result;
        }

        private double calcDis(Bitmap im, double AvBr)
        {
            double sum = 0f;
            for (int i = 0; i < im.Width; i++)
            {
                for (int j = 0; j < im.Height; j++)
                {
                    sum += (double)Math.Pow(GetBr(im.GetPixel(i, j)) - AvBr, 2);
                }
            }
            return (double)Math.Sqrt(sum / ((double)(im.Width * im.Height) - 1f));
        }

        private double calcAvBr(Bitmap im)
        {
            double sum = 0.0f;
            for (int i = 0; i < im.Width; i++)
            {
                for (int j = 0; j < im.Height; j++)
                {
                    sum += GetBr(im.GetPixel(i, j));
                }
            }
            return sum / (double)(im.Width * im.Height);
        }

        private double calcCov(Bitmap im1, double m1, Bitmap im2, double m2)
        {
            double sum = 0f;
            for (int i = 0; i < im1.Width; i++)
            {
                for (int j = 0; j < im1.Height; j++)
                {
                    sum += (GetBr(im1.GetPixel(i, j)) - m1) *
                        (GetBr(im2.GetPixel(i, j)) - m2);
                }
            }
            return sum / ((double)(im1.Width * im1.Height) - 1f);
        }


        private byte GetBr(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
	}
}
