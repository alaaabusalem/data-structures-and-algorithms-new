namespace TestCC27
{
	public class UnitTest1
	{
		[Fact]
		public void Sort_SortsIntArrayInAscendingOrder()
		{
			// Arrange
			int[] arr = { 12, 11, 13, 5, 6, 7 };
			int[] expected = { 5, 6, 7, 11, 12, 13 };

			// Act
			MergeSort.Sort(arr);

			// Assert
			Assert.Equal(expected, arr);
		}

		[Fact]
		public void Sort_SortsEmptyArray()
		{
			// Arrange
			int[] arr = new int[0];

			// Act
			MergeSort.Sort(arr);

			// Assert
			Assert.Empty(arr);
		}

		[Fact]
		public void Sort_SortsArrayWithOneElement()
		{
			// Arrange
			int[] arr = { 42 };

			// Act
			MergeSort.Sort(arr);

			// Assert
			Assert.Single(arr);
			Assert.Equal(42, arr[0]);
		}

		[Fact]
		public void Sort_SortsAlreadySortedArray()
		{
			// Arrange
			int[] arr = { 1, 2, 3, 4, 5 };
			int[] expected = { 1, 2, 3, 4, 5 };

			// Act
			MergeSort.Sort(arr);

			// Assert
			Assert.Equal(expected, arr);
		}

		[Fact]
		public void Sort_SortsArrayWithDuplicateValues()
		{
			// Arrange
			int[] arr = { 5, 3, 7, 3, 5 };
			int[] expected = { 3, 3, 5, 5, 7 };

			// Act
			MergeSort.Sort(arr);

			// Assert
			Assert.Equal(expected, arr);
		}
	}
}