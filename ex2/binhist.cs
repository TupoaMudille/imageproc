/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 03.10.2022
 * Время: 1:00
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;

namespace ex2
{
	/// <summary>
	/// Description of binhist.
	/// </summary>
	public class binhist:filter
	{
		protected override Color calcNewPix(Bitmap sourceIm, int x, int y)
		{
			int red_max = sourceIm.GetPixel(0,0).R;
			int green_max = sourceIm.GetPixel(0,0).G;
			int blue_max = sourceIm.GetPixel(0,0).B;
			int red_min = sourceIm.GetPixel(0,0).R;
			int green_min = sourceIm.GetPixel(0,0).G;
			int blue_min = sourceIm.GetPixel(0,0).B;
			int T=0;
			Color sourceCol = sourceIm.GetPixel(x,y);
			for (int i = 0; i<sourceIm.Width; i++)
				for (int j=0; j<sourceIm.Height; j++){
					if (sourceCol.R>red_max) red_max = sourceCol.R;
					if (sourceCol.G>green_max) green_max = sourceCol.G;
					if (sourceCol.B>blue_max) blue_max = sourceCol.B;
					
					if (sourceCol.R<red_min) red_min = sourceCol.R;
					if (sourceCol.G<green_min) green_min = sourceCol.G;
					if (sourceCol.B<blue_min) blue_min = sourceCol.B;	
					T++;
					
			}
			
			int new_T=(int)255*((red_max-red_min)+(green_max-green_min)+(blue_max-blue_min))/T;
			Color resultCol = Color.FromArgb((int)(binSlice((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),new_T)),
			                                 (int)(binSlice((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),new_T)),
			                                 (int)(binSlice((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),new_T)));
			return resultCol;
		}
		}
	}

