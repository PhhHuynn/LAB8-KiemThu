using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
	public class ArrayHelper
	{
		public static int FindMax(int[] numbers)
		{
			if (numbers == null || numbers.Length == 0)
				throw new ArgumentException("Array cannot be null or empty.");

			int max = numbers[0];
			foreach (var num in numbers)
			{
				if (num > max)
					max = num;
			}
			return max;
		}

		public static int FindMin(int[] numbers)
		{
			if (numbers == null || numbers.Length == 0)
				throw new ArgumentException("Array cannot be null or empty.");

			int min = numbers[0];
			foreach (var num in numbers)
			{
				if (num < min)
					min = num;
			}
			return min;
		}
	}
}
