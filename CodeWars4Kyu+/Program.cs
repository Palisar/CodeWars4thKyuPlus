using CodeWars4Kyu_;

int[] input = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };

var output = MoveZerosToEnd.MoveZeroes(input);
foreach (var item in output)
{
    Console.WriteLine(item);
}
