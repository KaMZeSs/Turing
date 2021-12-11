using System;

namespace Turing.Machines.ViewGraphic
{
    public class PermutationsWithRepetition
    {
        private Char[] source;
        private int variationLength;
        private byte[] byteSource;

        public PermutationsWithRepetition(Char[] source, int variationLength)
        {
            this.source = source;
            this.variationLength = variationLength;
            byteSource = new byte[source.Length];
            for (int i = 0; i < source.Length; i++)
                byteSource[i] = (byte)source[i];
        }

        public String[] getVariations()
        {
            int srcLength = source.Length;
            int permutations = (int)Math.Pow(srcLength, variationLength);

            Byte[,] table = new Byte[permutations, variationLength];

            for (int i = 0; i < variationLength; i++)
            {
                int t2 = (int)Math.Pow(srcLength, i);
                for (int p1 = 0; p1 < permutations;)
                {
                    for (int al = 0; al < srcLength; al++)
                    {
                        for (int p2 = 0; p2 < t2; p2++)
                        {
                            table[p1, i] = byteSource[al];
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
