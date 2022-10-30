/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 09.09.2022
 * Время: 10:07
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;

namespace ex2
{
	/// <summary>
	/// Description of grayscale.
	/// </summary>
	class grayscale:filter{
		protected override Color calcNewPix(Bitmap sourceIm, int x, int y)
		{
			Color sourceCol = sourceIm.GetPixel(x,y);
			Color resultCol = Color.FromArgb((int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),
			                                 (int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B),
			                                 (int)(0.299*sourceCol.R + 0.587*sourceCol.G + 0.114*sourceCol.B));
			return resultCol;
		}
	}
}
