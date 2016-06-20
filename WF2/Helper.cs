﻿namespace WF2
{
    public static class Helper
    {
        /// <summary>
        /// Parse string to int
        /// </summary>
        /// <param name="source"></param>
        /// <returns>
        /// If unable parse to int returns 0
        /// </returns>
        public static int GetInt(this string source)
        {
            int i = 0;
            
            if (int.TryParse(source, out i))
            {
                return i;
            }
            return 0;
        }
    }
}