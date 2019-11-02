using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] cArray = original.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse = reverse + cArray[i];
            }
            return reverse;
        }
    }
}
