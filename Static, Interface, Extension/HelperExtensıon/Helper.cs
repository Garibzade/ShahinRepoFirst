namespace Static__Interface__Extension.HelperExtensıon
{
    internal static class Helper
    {
        public static bool IsOdd(int a)
        {
            if (a % 2 == 0)
            { return false; }
            return true;

        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            { return true; }
            return false;
        }

        public static bool HasDigit(string a)
        {
            foreach (char c in a)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }


        public static bool CheckPassword(this string a)
        {

            foreach (char c in a)
            {
                if (char.IsDigit(c) && a.Length >= 8 && char.IsUpper(c) && char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static string Capitalaize(this string a)
        {
            return a.Substring(0, 1).ToUpper() + a.Substring(1).ToLower();
        }
    }
}
