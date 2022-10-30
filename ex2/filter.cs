﻿/*
 * Создано в SharpDevelop.
 * Пользователь: tanap
 * Дата: 09.09.2022
 * Время: 9:59
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Drawing;

namespace ex2
{
	/// <summary>
	/// Description of filter.
	/// </summary>
	public abstract class filter
	{
		protected abstract Color calcNewPix(Bitmap sourceIm, int x, int y);
		public Bitmap procIm(Bitmap sourceIm)
		{
			Bitmap resultIm = new Bitmap(sourceIm.Width, sourceIm.Height);
			for (int i=0; i<sourceIm.Width;i++){
				for (int j=0; j<sourceIm.Height;j++) resultIm.SetPixel(i,j,calcNewPix(sourceIm,i,j));}
			return resultIm;
		}
		
		public int Slice(int val, int min, int max){
			if (val<min) return min;
			if (val>max) return max;
			return val;}
		
		public int binSlice(int val, int level){
			int resVal=0;
			int maxVal=255;
			if (val>=level) return maxVal;
			return resVal;}
		
		protected double Intensity(Color color)
        {
            return 0.29 * color.R + 0.58 * color.G + 0.11 * color.B;
        }
		
		protected int Rand(int sourceCol){
			int[] array = new int[]{0,255,sourceCol};
			Random rand = new Random();
			int res = rand.Next(array.Length);
			int result = array[res];
			
			return result;
		}
	}
		
}
