using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars4Kyu_
{
    public struct NavPoint { public double x, y; }
    public enum Compass
    {
        NORTH,
        WEST,
        SOUTH,
        EAST
    };
    public static class SatNavOS
    {
        public static Point SatNav(string[] directions)
        {
            var compassDirection = (Compass)Enum.Parse(typeof(Compass), directions[0].Split(' ').Last());
            NavPoint currentNavPoint = new NavPoint() { x = 0f, y = 0f };
            bool turnedAround = false;

            foreach (var direction in directions)
            {
                if (direction.StartsWith("Ta"))
                {
                    if (turnedAround)
                    {
                        currentNavPoint = TurningPoint(currentNavPoint, compassDirection);
                        turnedAround = false;
                    }

                    var instructions = direction.Split(' ').TakeLast(2).ToArray();
                    if (instructions[0] == "NEXT")
                    {
                        currentNavPoint = new NavPoint() { x = (int)(currentNavPoint.x), y = (int)currentNavPoint.y };
                        var movement = 1;
                        currentNavPoint = Move(movement, currentNavPoint, compassDirection);
                    }
                    else
                    {
                        currentNavPoint = new NavPoint() { x = (int)currentNavPoint.x, y = (int)currentNavPoint.y };
                        var movement = int.Parse(instructions[0].First().ToString());
                        currentNavPoint = Move(movement, currentNavPoint, compassDirection);
                    }

                    compassDirection = SetCompass(instructions[1], compassDirection);

                }
                else if (direction.StartsWith('G'))
                {
                    var travel = direction.Split(' ').Last();
                    if (travel.Contains("km"))
                    {
                        var movement = double.Parse(travel.TrimEnd('m').TrimEnd('k'));
                        currentNavPoint = Move(movement, currentNavPoint, compassDirection);
                    }
                    else
                    {
                        var movement = double.Parse(travel.TrimEnd('m')) / 1000;
                        currentNavPoint = Move(movement, currentNavPoint, compassDirection);
                    }
                    turnedAround = false;
                }
                else if (direction.StartsWith("Tu"))
                {
                    compassDirection = TurnAround(compassDirection);
                    turnedAround = true;
                }
            }
            var pointConvert = new Point() { x = (int)Math.Round(currentNavPoint.x * 10), y = (int)Math.Round(currentNavPoint.y * 10) };
            return pointConvert;
        }

        private static NavPoint Move(double distance, NavPoint startingNavPoint, Compass direction)
        {

            switch (direction)
            {
                case Compass.NORTH:
                    return new NavPoint() { x = startingNavPoint.x, y = startingNavPoint.y + distance };
                case Compass.WEST:
                    return new NavPoint() { x = startingNavPoint.x - distance, y = startingNavPoint.y };
                case Compass.SOUTH:
                    return new NavPoint() { x = startingNavPoint.x, y = startingNavPoint.y - distance };
                case Compass.EAST:
                    return new NavPoint() { x = startingNavPoint.x + distance, y = startingNavPoint.y };

            }
            return new NavPoint();
        }

        public static NavPoint TurningPoint(NavPoint point, Compass compass)
        {
            switch (compass)
            {
                case Compass.NORTH:
                    return new NavPoint() { x=point.x, y= Math.Floor(point.y) };
                case Compass.WEST:
                    return new NavPoint() { x = Math.Ceiling(point.x), y = point.y };
                case Compass.SOUTH:
                    return new NavPoint() { x = point.x, y = Math.Ceiling(point.y) };
                case Compass.EAST:
                    return new NavPoint() { x = Math.Floor(point.x), y = point.y };
                default:
                    return point;
            }
        }

        public static Compass SetCompass(string turn, Compass compass)
        {
            switch (compass)
            {
                case Compass.NORTH:
                    if (turn == "LEFT")
                    {
                        return Compass.WEST;
                    }
                    else
                    {
                        return Compass.EAST;
                    }
                case Compass.WEST:
                    if (turn == "LEFT")
                    {
                        return Compass.SOUTH;
                    }
                    else
                    {
                        return Compass.NORTH;
                    }
                case Compass.SOUTH:
                    if (turn == "LEFT")
                    {
                        return Compass.EAST;
                    }
                    else
                    {
                        return Compass.WEST;
                    }
                case Compass.EAST:
                    if (turn == "LEFT")
                    {
                        return Compass.NORTH;
                    }
                    else
                    {
                        return Compass.SOUTH;
                    }
                default:
                    return compass;
            }
        }
        public static Compass TurnAround(Compass compass)
        {
            switch (compass)
            {
                case Compass.NORTH:
                    return Compass.SOUTH;
                case Compass.WEST:
                    return Compass.EAST;
                case Compass.SOUTH:
                    return Compass.NORTH;
                case Compass.EAST:
                    return Compass.WEST;
                default:
                    return compass;
            }
        }
    }
}
