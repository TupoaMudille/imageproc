/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 02.10.2022
 * Время: 23:10
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;

namespace ex2
{
	/// <summary>
	/// Description of histautocontrast.
	/// </summary>
	public class histautocontrast:filter
	{
		protected override Color calcNewPix(Bitmap sourceIm, int x, int y)
		{
			int red_max = sourceIm.GetPixel(0,0).R;
			int green_max = sourceIm.GetPixel(0,0).G;
			int blue_max = sourceIm.GetPixel(0,0).B;
			int red_min = sourceIm.GetPixel(0,0).R;
			int green_min = sourceIm.GetPixel(0,0).G;
			int blue_min = sourceIm.GetPixel(0,0).B;
			
			for (int i = 0; i<sourceIm.Width; i++)
				for (int j=0; j<sourceIm.Height; j++){
					Color sourceCol = sourceIm.GetPixel(i,j);
					if (sourceCol.R>red_max) red_max = sourceCol.R;
					if (sourceCol.G>green_max) green_max = sourceCol.G;
					if (sourceCol.B>blue_max) blue_max = sourceCol.B;
					
					if (sourceCol.R<red_min) red_min = sourceCol.R;
					if (sourceCol.G<green_min) green_min = sourceCol.G;
					if (sourceCol.B<blue_min) blue_min = sourceCol.B;	
					
			}

			Color sourceCol2 = sourceIm.GetPixel(x,y);
			Color resultCol = Color.FromArgb(Convert.ToInt32(Slice((int)((sourceCol2.R-red_min)*255/(red_max-red_min)),0,255)),
			                                 Convert.ToInt32(Slice((int)((sourceCol2.G-green_min)*255/(green_max-green_min)),0,255)),
			                                 Convert.ToInt32(Slice((int)((sourceCol2.B-blue_min)*255/(blue_max-blue_min)),0,255)));
			return resultCol;
		}
	}
}
