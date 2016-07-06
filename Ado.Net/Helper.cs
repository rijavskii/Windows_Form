namespace Ado.Net
{
    public static class Helper
    {
        public static double GetDouble(this string source)
        {
            double i = 0;
            if (double.TryParse(source, out i))
            {
                return i;
            }
            return 0;
        }
    }
}