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
            int index = 0; 

            while (value > 0)
            {
                // Check that the value can be subtracted by the dictionary value
                if (value - numerals.ElementAt(index).Key >= 0)
                {
                    // Add the roman numeral value to the string result
                    result += numerals.ElementAt(index).Value;

                    // Subtract the numeric value from our current value
                    value -= numerals.ElementAt(index).Key;
                }
                else
                {
                    index++;
                }
            }
            return result;
        }

        public int RomanNumeralToInt(string numeral)
        {
            int result = 0;
            int currentIndexValue = 0;
            int nextIndexValue = 0;

            for (int i = 0; i < numeral.Length - 1; i++)
            {
                currentIndexValue = numerals.FirstOrDefault(ci => ci.Value == numeral[i].ToString()).Key;
                nextIndexValue = numerals.FirstOrDefault(ni => ni.Value == numeral[i + 1].ToString()).Key;
                                
                // If the symbol appears before a larger symbol it is subtracted
                if (nextIndexValue > currentIndexValue)
                {
                    result += nextIndexValue - currentIndexValue;
                }
                else
                {
                    result += currentIndexValue;
                }
            }
            return result;
        }
    }
}
