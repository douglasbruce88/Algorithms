using System;
using System.Linq;

namespace Algorithms
{
	public class MergeSort<T> where T : IComparable
	{
		public T[] InputArray
		{
			get;
			set;
		}
		public MergeSort (T[] inputArray)
		{
			InputArray = inputArray;
		}

		// The main routine
		public T[] Sort(T[] inputArray)
		{
			if (inputArray.Length > 1) {
				// Divide and conquer step
				var leftHalfSorted = Sort (inputArray.Take (inputArray.Length / 2).ToArray ());
				var rightHalfSorted = Sort (inputArray.Skip (inputArray.Length / 2).Take (inputArray.Length - inputArray.Length / 2).ToArray ());

				// Merge step
				var outputArray = new T[inputArray.Length];
				int i=0, j=0, k=0;

				while (i < leftHalfSorted.Length && j < rightHalfSorted.Length) 
				{
					if (leftHalfSorted [i].CompareTo (rightHalfSorted [j]) < 0) 
					{
						outputArray [k] = leftHalfSorted [i];
						i++;
						k++;
					} 
					else 
					{
						outputArray [k] = rightHalfSorted [j];
						j++;
						k++;
					}
				}

				for (; i < leftHalfSorted.Length; i++)
				{
					outputArray [k] = leftHalfSorted [i];
					k++;
				}
				for (; j < rightHalfSorted.Length; j++)
				{
					outputArray [k] = rightHalfSorted [j];
					k++;
				}

				return outputArray;

			} 
			else 
			{
				return inputArray;
			}
		}
	}
}

