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
            T[] result = new T[len];
                
            for (; 0 < array.Length & 0 < len; len--)
            {
                result[0] = array[0];
                List<T> l = array.ToList();
                l.Remove(array[0]);
                array = l.ToArray();
            }

            return result;
        }
            
    }
}
