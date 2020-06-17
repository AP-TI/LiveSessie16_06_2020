using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Deel3Oefening1
{
    public static class Validations
    {
        public static bool IsEAN13BarcodeValid(this string input)
        {
            input = input.PadLeft(13, '0');

            if (!Regex.IsMatch(input, "^\\d{13}$"))
                return false;

            int result = 0;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (i % 2 == 1)
                    result += int.Parse(input[i].ToString()) * 3;
                else
                    result += int.Parse(input[i].ToString());
            }
            result %= 10;
            result = 10 - result;
            return result.ToString() == input[input.Length - 1].ToString();
        }
    }
}
