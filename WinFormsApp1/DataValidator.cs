using System;

namespace WinFormsApp1
{
    class DataValidator
    {
        public static bool IsNumeric(string s)
        {
            return double.TryParse(s, out double n);
        }

        public static bool IsDateTime(string s) 
        {
            return DateTime.TryParse(s, out DateTime Temp);
        }
    }
    public enum StorageTypes { BOOK, PRODUCT, NOT_INCLUDED }
}
