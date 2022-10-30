/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 09.09.2022
 * Время: 10:30
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace ex2
{
	/// <summary>
	/// Description of blur.
	/// </summary>
	class blur:matrFilter
	{
		public blur()
		{	int sizeX = 3;
			int sizeY = 3;
			kernel = new float[sizeX,sizeY];
			for (int i=0; i<sizeX;i++){
				for (int j=0; j<sizeY;j++)
					kernel[i,j] = 1.0f/(float)(sizeX*sizeY);
				}
		}
	}
}
