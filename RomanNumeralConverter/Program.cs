using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class RomanNumeralConverter
    {
        Dictionary<int, string> numerals = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };
        public string IntToRomanNumeral(int value)
        {
            string result = "";
            int i = 0;
            while (value > 0)
            {
                if (value - numerals.ElementAt(i).Key >= 0)
                {
                    result += numerals.ElementAt(i).Value;
                    value -= numerals.ElementAt(i).Key;
                }
                else
                {
                    i++;
                }
            }
            return result;
        }

        public int RomanNumeralToInt(string numeral)
        {
            return 0;
        }
    }
}
