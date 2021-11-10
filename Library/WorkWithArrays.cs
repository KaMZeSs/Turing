using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Turing.Library
{
    public static class WorkWithArrays
    {
        public static int GetMaxFormArray(int[] array)
        {
            if (array == null)
                throw new Exception();
            if (array.Length == 0)
                throw new Exception();
            int max = array[0];

            foreach (int num in array)
                max = num > max ? num : max;

            return max;
        }

        public static T[] Cut<T>(ref T[] array, int len)
        {
            T[] result = new T[len < array.Length ? len : array.Length];
            List<T> list = array.ToList();
            for (int i = 0; 0 < list.Count & 0 < len; len--, i++)
            {
                result[i] = list.First();
                list.Remove(list.First());
            }
            array = list.ToArray();
            return result;
        }

        public static List<T[]> Split<T>(T[] array, int len)
        {
            List<T[]> res = new List<T[]>();
            List<T> list = array.ToList();
            while (list.Count != 0)
            {
                T[] result = new T[len < list.Count ? len : list.Count];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = list.First();
                    list.Remove(list.First());
                }
                res.Add(result);
            }
            return res;
        }
    }
}
