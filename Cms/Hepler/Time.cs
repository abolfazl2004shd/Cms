using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Globalization;

namespace Cms.Hepler
{
    public static class Time
    {
        public static string Format(this DateTime dt)
        {
            CultureInfo englishCulture = new("en-US");
            string result = dt.ToString("MMMM d, yyyy",englishCulture);
            return result;
        }
    }
}
