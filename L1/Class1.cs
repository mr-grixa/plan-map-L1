using System;

namespace L1
{
    public class RobotData
    {
        public string d0 { get; set; }
        public string d1 { get; set; }
        public string d2 { get; set; }
        public string d3 { get; set; }
        public string d4 { get; set; }
        public string d5 { get; set; }
        public string d6 { get; set; }
        public string d7 { get; set; }
        public string az { get; set; }
        public string le { get; set; }
        public string re { get; set; }
        public string c { get; set; }
        public string b { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string t { get; set; }
        public string l0 { get; set; }
        public string l1 { get; set; }
        public string l2 { get; set; }
        public string l3 { get; set; }
        public string l4 { get; set; }

    }
    public class RobotMessage
    {
        public int N { get; set; }
        public int M { get; set; }
        public int F { get; set; }
        public int B { get; set; }
        public int T { get; set; }
    }

    public static class RobotDataExtensions
    {
        public static int ToInt(this string value)
        {
            int result;
            if (int.TryParse(value, out result))
            {
                return result;
            }
            return 0;
        }
    }

    public struct PointD
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public static class Geometry
    {
        public static double GetAngle(PointD p1, PointD p2)
        {
            var dx = p2.X - p1.X;
            var dy = p2.Y - p1.Y;

            var angle = Math.Atan2(dy, dx) * 180 / Math.PI;
            return angle;
        }

        public static double GetDistance(PointD p1, PointD p2)
        {
            var dx = p2.X - p1.X;
            var dy = p2.Y - p1.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
