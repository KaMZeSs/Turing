﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Machines.ViewGraphic
{
    public class PermutationsWithRepetition
    {
        private Char[] source;
        private int variationLength;

        public PermutationsWithRepetition(Char[] source, int variationLength)
        {
            this.source = source;
            this.variationLength = variationLength;
        }

        public String[] getVariations()
        {
            int srcLength = source.Length;
            int permutations = (int)Math.Pow(srcLength, variationLength);

            Object[,] table = new Object[permutations, variationLength];

            for (int i = 0; i < variationLength; i++)
            {
                int t2 = (int)Math.Pow(srcLength, i);
                for (int p1 = 0; p1 < permutations;)
                {
                    for (int al = 0; al < srcLength; al++)
                    {
                        for (int p2 = 0; p2 < t2; p2++)
                        {
                            table[p1, i] = source[al];
                            p1++;
                        }
                    }
                }
            }

            String[] result = new String[permutations];

            for (int i = 0; i < permutations; i++)
            {
                Char[] array = new Char[variationLength];
                for (int j = 0; j < variationLength; j++)
                    array[j] = (Char)table[i, j];
                result[i] = new String(array);
            }

            return result;
        }
    }
}
