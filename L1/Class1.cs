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
            // You might want to handle the case where parsing fails,
            // for now, I'll return 0 in case of failure.
            return 0;
        }
    }
}
