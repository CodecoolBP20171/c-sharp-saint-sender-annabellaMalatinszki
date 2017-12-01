using System;
using System.Text;

namespace SaintSender
{
    class Encoder
    {
        // Change Base64 encoded strings to UTF8.
        public static string ConvertFromBase64(string ConvertFrom)
        {
            var input = ConvertFrom.Replace("-", "+").Replace("_", "/");
            string result = Encoding.UTF8.GetString(Convert.FromBase64String(input));
            return result;
        }

        // Change UTF8 encoded strings to UTF8.
        public static string ConvertToBase64(string toConvert)
        {
            var input = Encoding.UTF8.GetBytes(toConvert);
            string result = Convert.ToBase64String(input);
            return result;
        }


    }
}
