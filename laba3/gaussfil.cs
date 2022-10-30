/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 30.10.2022
 * Время: 16:31
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace laba3
{
	/// <summary>
	/// Description of gaussfil.
	/// </summary>
	public class gaussfil:matrfilter
	{
		public void createGaussKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size,size];
            float norm = 0;
            for (int i = -radius; i<= radius; i++)
                for (int j = -radius; j<= radius; j++)
                {
                    kernel[i + radius, j + radius] = (float)Math.Exp(-(i * i + j * j) / (sigma * sigma));
                    norm += kernel[i + radius, j + radius];
                }
            for (int i=0;i<size;i++)
                for (int j=0;j<size;j++)
                    kernel[i,j] /= norm;
        }

	}
}
