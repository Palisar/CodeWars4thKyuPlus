namespace CodeWars4Kyu_;
//Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.
public static class SnailSort
{
    public static int[] Sort2D(int[,] input)
    {
        List<int> result = new List<int>();
        result.Add(input[0, 0]);

        Point startPoint = new Point() { x = 0, y = 0 };
        Queue<Point> Points = new Queue<Point>();
        HashSet<Point> visitedPoints = new HashSet<Point>();
        Points.Enqueue(startPoint);

        while (Points.Count > 0)
        {
            var currentPoint = Points.Dequeue();
            visitedPoints.Add(currentPoint);

            if (currentPoint.x < input.GetLength(1) - 1 && !visitedPoints.Contains(new Point() { x = currentPoint.x + 1, y = currentPoint.y }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x + 1, y = currentPoint.y });
                result.Add(input[currentPoint.y, currentPoint.x + 1]);
            }
            else if (currentPoint.y < input.GetLength(0) - 1 && !visitedPoints.Contains(new Point() { x = currentPoint.x, y = currentPoint.y + 1 }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x, y = currentPoint.y + 1 });
                result.Add(input[currentPoint.y + 1, currentPoint.x]);
            }
            else if (currentPoint.x > 0 && !visitedPoints.Contains(new Point() { x = currentPoint.x - 1, y = currentPoint.y }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x - 1, y = currentPoint.y });
                result.Add(input[currentPoint.y, currentPoint.x - 1]);
            }
            else if (currentPoint.y > 0 && !visitedPoints.Contains(new Point() { x = currentPoint.x, y = currentPoint.y - 1 }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x, y = currentPoint.y - 1 });
                result.Add(input[currentPoint.y - 1, currentPoint.x]);
            }

        }
        return result.ToArray();
    }

    public static int[] Sort2D2(int[][] input) {
        List<int> result = new List<int>();
        result.Add(input[0][0]);

        Point startPoint = new Point() { x = 0, y = 0 };
        Queue<Point> Points = new Queue<Point>();
        HashSet<Point> visitedPoints = new HashSet<Point>();
        Points.Enqueue(startPoint);

        while (Points.Count > 0)
        {
            var currentPoint = Points.Dequeue();
            visitedPoints.Add(currentPoint);

            if (currentPoint.x < input.GetLength(0) - 1 && !visitedPoints.Contains(new Point() { x = currentPoint.x + 1, y = currentPoint.y }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x + 1, y = currentPoint.y });
                result.Add(input[currentPoint.y][currentPoint.x + 1]);
            }
            else if (currentPoint.y < input.GetLength(1) - 1 && !visitedPoints.Contains(new Point() { x = currentPoint.x, y = currentPoint.y + 1 }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x, y = currentPoint.y + 1 });
                result.Add(input[currentPoint.y + 1][currentPoint.x]);
            }
            else if (currentPoint.x > 0 && !visitedPoints.Contains(new Point() { x = currentPoint.x - 1, y = currentPoint.y }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x - 1, y = currentPoint.y });
                result.Add(input[currentPoint.y][currentPoint.x - 1]);
            }
            else if (currentPoint.y > 0 && !visitedPoints.Contains(new Point() { x = currentPoint.x, y = currentPoint.y - 1 }))
            {
                Points.Enqueue(new Point() { x = currentPoint.x, y = currentPoint.y - 1 });
                result.Add(input[currentPoint.y - 1][currentPoint.x]);
            }

        }
        return result.ToArray();
    }
}

public struct Point
{
    public int x;
    public int y;
}
