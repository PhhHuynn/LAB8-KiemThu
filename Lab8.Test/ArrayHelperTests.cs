using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Test
{
	internal class ArrayHelperTests
	{
		[Test]
		public void FindMax_ShouldReturnMaximumValue()
		{
			int[] numbers = { 3, 7, 1, 9, 2 };
			int result = ArrayHelper.FindMax(numbers);
			Assert.AreEqual(9, result);
		}

		[Test]
		public void FindMin_ShouldReturnMinimumValue()
		{
			int[] numbers = { 3, 7, 1, 9, 2 };
			int result = ArrayHelper.FindMin(numbers);
			Assert.AreEqual(1, result);
		}

		[Test]
		public void FindMax_ShouldThrowException_WhenArrayEmpty()
		{
			int[] numbers = { };
			Assert.Throws<ArgumentException>(() => ArrayHelper.FindMax(numbers));
		}

		[Test]
		public void FindMin_ShouldThrowException_WhenArrayIsNull()
		{
			int[] numbers = null;
			Assert.Throws<ArgumentException>(() => ArrayHelper.FindMin(numbers));
		}
	}
}
