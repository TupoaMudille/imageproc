/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 20.09.2022
 * Время: 13:34
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;

namespace ex2
{
	/// <summary>
	/// Description of globalfilt.
	/// </summary>
	public class globalfilt:filter
	{

		protected override Color calcNewPix(Bitmap sourceIm, int x, int y)
		{
			Color sourceCol = sourceIm.GetPixel(x,y);
			int GT = 20;
			
			Color resultCol = Color.FromArgb((int)(binSlice((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),GT)),
			                                 (int)(binSlice((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),GT)),
			                                 (int)(binSlice((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),GT)));
			return resultCol;
		}
	}
}


