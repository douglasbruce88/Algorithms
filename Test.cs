using NUnit.Framework;
using System;

namespace Algorithms
{
	[TestFixture ()]
	public class Test
	{
		//[Test ()]
		//public void TestInversions ()
		//{
		//	var inversion = new Inversions (Environment.CurrentDirectory + "/../../SupportingFiles/IntegerArray.txt");
		//	var numInversions = inversion.GetInversions (inversion.Integers);
		//
		//	Assert.AreEqual (1, numInversions);
		//}

		[Test ()]
		public void TestSorting ()
		{
			var input = new [] { 2, 1, 3, 7, 5 };
			var sortedInput = new [] { 1, 2, 3, 5, 7};
			var mergeSort = new MergeSort<int>(input);
			var sortedOutput = mergeSort.Sort(mergeSort.InputArray);

			Assert.AreEqual (sortedInput, sortedOutput);
		}
	}
}

