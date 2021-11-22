using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Turing.Machines.OneLineTuringMachine;

namespace Turing.Library
{
    static class WorkWithString
    {
        public static string Multiply(this string source, int multiplier)
        {
            StringBuilder sb = new StringBuilder(multiplier * source.Length);
            for (int i = 0; i < multiplier; i++)
                sb.Append(source);
            return sb.ToString();
        }

        public static String RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        public static String GetDifference(String str1, String str2)
        {
            String result = "";

            foreach (char Letter in str1)
                if (!str2.Contains(Letter))
                    if (!result.Contains(Letter))
                        result += Letter;
            foreach (char Letter in str2)
                if (!str1.Contains(Letter))
                    if (!result.Contains(Letter))
                        result += Letter;

            return result;
        }

        public static bool isDirection(String str)
        {
            if (str.Length != 1)
                return false;

            if (str == ">")
                return true;
            if (str == "<")
                return true;
            if (str == ".")
                return true;

            return false;
        }

        public static String ChangeValue(this string source, int index, String newValue)
        {
            String str = source.Substring(length: index, startIndex: 0);
            str += newValue;
            str += source.Substring(startIndex: index + 1);
            return str;
        }

        public static String ChangeValue(this string source, int StartIndex, int LastIndex, String newValue)
        {
            String str = source.Substring(length: StartIndex, startIndex: 0);
            str += newValue;
            str += source.Substring(startIndex: LastIndex);
            return str;
        }

        public static bool isNumber(this string source)
        {
            foreach (var element in source)
                if (!Char.IsDigit(element))
                    return false;
            return true;
        }

        public static bool isNumber(this string source, int StartPos)
        {
            bool isMinus = false;
            foreach (var element in source.Substring(StartPos))
            {
                if (element == '-')
                    if (isMinus)
                        return false;
                    else
                        isMinus = true;
                else if (!Char.IsDigit(element))
                    return false;
            }
                
            return true;
        }

        public static String GetKAtLine(this string source)
        {
            int start, len; start = -1; len = 0;
            bool hasStart = false;

            for (int i = 0; i < source.Length; i++)
            {
                if (!hasStart && source[i] != 'λ')
                {
                    start = i;
                    hasStart = true;
                }
                if (hasStart && source[i] != 'λ')
                    len++;
            }
            if (len == 0)
                return "";
            return source.Substring(start, len);
        }
    }
}
