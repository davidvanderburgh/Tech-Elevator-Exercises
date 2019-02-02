using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        public string ConvertToRomanNumeral(int n)
        {
            string result = "";

            result += ConvertArabicToRoman(1000, "M", ref n);
            result += ConvertArabicToRoman(500, "D", ref n);
            result += ConvertArabicToRoman(100, "C", ref n);
            result += ConvertArabicToRoman(50, "L", ref n);
            result += ConvertArabicToRoman(10, "X", ref n);
            result += ConvertArabicToRoman(5, "V", ref n);
            result += ConvertArabicToRoman(1, "I", ref n);

            // Fix the long form to short form
            // CCCC -> CD
            // LXXXX -> XC
            result = FixLongFormToShortForm(result, "CCCC", "CD");
            result = FixLongFormToShortForm(result, "LXXXX", "XC");
            result = FixLongFormToShortForm(result, "XXXX", "XL");
            result = FixLongFormToShortForm(result, "VIIII", "IX");
            result = FixLongFormToShortForm(result, "IIII", "IV");

            return result;
        }

        public int ConvertToDigit(string romanNumeral)
        {
            int result = 0;

            for (int i = 0; i < romanNumeral.Length; i++)
            {
                int currentNumeral = GetRomanNumeralCharacterValue(romanNumeral[i]);

                if (i + 1 < romanNumeral.Length)
                {
                    int nextNumeral = GetRomanNumeralCharacterValue(romanNumeral[i + 1]);

                    if (currentNumeral >= nextNumeral)
                    {
                        result += currentNumeral;
                    }
                    else
                    {
                        result += nextNumeral - currentNumeral;
                        i++;
                    }
                }
                else
                {
                    result = result + currentNumeral;
                    i++;
                }
            }

            return result;
        }

        private int GetRomanNumeralCharacterValue(char numeral)
        {
            switch (numeral)
            {
                case 'M':
                    return 1000;
                case 'D':
                    return 500;
                case 'C':
                    return 100;
                case 'L':
                    return 50;
                case 'X':
                    return 10;
                case 'V':
                    return 5;
                case 'I':
                    return 1;
                default:
                    return 0;
            }
        }

        private string FixLongFormToShortForm(string result, string find, string replace)
        {
            return result.Replace(find, replace);
        }

        private string ConvertArabicToRoman(int places, string romanNumeral, ref int number)
        {
            string result = "";
            while (number >= places)
            {
                number -= places;
                result += romanNumeral;
            }

            return result;
        }
    }
}
