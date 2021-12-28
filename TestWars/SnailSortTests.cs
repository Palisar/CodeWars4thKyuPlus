
namespace TestWars;

public class SnailSortTests
{
    [Fact]
    public void SmallTest()
    {
        int[,] data =
       {
          {1, 2, 3},
          {4, 5, 6},
          {7, 8, 9}
       };
        var result = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        var actual = SnailSort.Sort2D(data);
        actual.Should().BeEquivalentTo(result);
    }
    [Fact]
    public void LargeTest()
    {
        int[,] data =
       {
          {1, 2, 3 ,4 ,5 ,6},
          {7 ,8, 9 ,10,11,12},
          {13,14,15,16,17,18},
          {19,20,21,22,23,24},
          {25, 26,27,28,29,30}

       };
        var result = new[] { 1, 2, 3, 4, 5, 6, 12, 18, 24, 30, 29, 28, 27, 26, 25, 19, 13, 7, 8, 9, 10, 11, 17, 23, 22, 21, 20, 14, 15, 16 };
        var actual = SnailSort.Sort2D(data);
        actual.Should().BeEquivalentTo(result);
    }

    [Fact]
    public void SmallTest2()
    {
        int[][] data =
       {
         new int[] {1, 2, 3},
         new int[] {4, 5, 6},
         new int[] {7, 8, 9}
       };
        var result = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
        var actual = SnailSort.Sort2D2(data);
        actual.Should().BeEquivalentTo(result);
    }
    [Fact]
    public void LargeTest2()
    {
        int[][] data =
       {
          new int[]{1, 2, 3 ,4 ,5 ,6},
          new int[]{7 ,8, 9 ,10,11,12},
          new int[]{13,14,15,16,17,18},
          new int[]{19,20,21,22,23,24},
          new int[]{25, 26,27,28,29,30}
       };
        var result = new[] { 1, 2, 3, 4, 5, 6, 12, 18, 24, 30, 29, 28, 27, 26, 25, 19, 13, 7, 8, 9, 10, 11, 17, 23, 22, 21, 20, 14, 15, 16 };
        var actual = SnailSort.Sort2D2(data);
        actual.Should().BeEquivalentTo(result);
    }
}
