/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 09.09.2022
 * Время: 10:55
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;

namespace ex2
{
	/// <summary>
	/// Description of autocontrast.
	/// </summary>
	public class autocontrast:filter
	{
		
		protected override Color calcNewPix(Bitmap sourceIm, int x, int y)
		{
			Color sourceCol = sourceIm.GetPixel(x,y);
			int N = 20;
			
			Color resultCol = Color.FromArgb((int)((Slice((100*sourceCol.R + 128*N)/(100-N),0,255))),
			                                 (int)(Slice((100*sourceCol.G + 128*N)/(100-N),0,255)),
			                                 (int)(Slice((100*sourceCol.B + 128*N)/(100-N),0,255)));
			return resultCol;
		}
	}
}
