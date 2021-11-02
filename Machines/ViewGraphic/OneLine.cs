using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Turing.Machines.OneLineTuringMachine;

namespace Turing.Machines.ViewGraphic
{
    class OneLine
    {
        Form form;
        DataGridView TableConditions;
        String Alphabet;

        List<int> allResults;
        List<int> temporaryResults;

        OneLine()
        {
            form = new Form();
            TableConditions = new DataGridView();
            Alphabet = "abc";
            List<int> allResults = new List<int>();
        }

        private void OpenTable()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.AddExtension = true;
            fileDialog.Filter = "XML|*.xml";
            fileDialog.CheckPathExists = true;
            fileDialog.ValidateNames = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                DataSet dataSet = new DataSet();
                DataTable data = new DataTable();
                try
                {
                    dataSet.ReadXml(fileDialog.FileName);
                }
                catch
                {
                }

                data = dataSet.Tables[0];

                for (int i = 0; i < data.Columns.Count - 1; i++)
                {
                    int index = TableConditions.Columns.Count;
                    TableConditions.Columns.Add(index.ToString(), "q" + index.ToString());
                }

                for (int i = 0; i < TableConditions.Rows.Count; i++)
                {
                    for (int j = 0; j < TableConditions.Columns.Count; j++)
                    {
                        String str = data.Rows[i][j].ToString();
                        TableConditions[j, i].Value = str;
                    }
                }
            }
        }

        private void CreateAllTasks(int level)
        {
            
        }

        private int DoTask(String line)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";

            TuringMachine turingMachine = new TuringMachine(ref TableConditions);

            while (true)
            {
                try
                {
                    
                }
                catch (Exception except)
                {
                    break;
                }
            }

            return 0;
        }



        //public class PermutationsWithRepetition
        //{
        //    private Char[] source;
        //    private int variationLength;

        //    public PermutationsWithRepetition(Char[] source, int variationLength)
        //    {
        //        this.source = source;
        //        this.variationLength = variationLength;
        //    }

        //    public String[] getVariations()
        //    {
        //        int srcLength = source.Length;
        //        int permutations = (int)Math.Pow(srcLength, variationLength);

        //        Object[,] table = new Object[permutations, variationLength];

        //        for (int i = 0; i < variationLength; i++)
        //        {
        //            int t2 = (int)Math.Pow(srcLength, i);
        //            for (int p1 = 0; p1 < permutations;)
        //            {
        //                for (int al = 0; al < srcLength; al++)
        //                {
        //                    for (int p2 = 0; p2 < t2; p2++)
        //                    {
        //                        table[p1, i] = source[al];
        //                        p1++;
        //                    }
        //                }
        //            }
        //        }

        //        String[] result = new String[permutations];

        //        for (int i = 0; i < permutations; i++)
        //        {
        //            Char[] array = new Char[variationLength];
        //            for (int j = 0; j < variationLength; j++)
        //                array[j] = (Char)table[i, j];
        //            result[i] = new String(array);
        //        }

        //        return result;
        //    }
        //}

        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        String str = Console.ReadLine();
        //        int len = Convert.ToInt32(Console.ReadLine());

        //        PermutationsWithRepetition gen = new PermutationsWithRepetition(
        //            str.Trim().ToCharArray(), len);

        //        var variations = gen.getVariations();

        //        //foreach (String s in variations)
        //        //{
        //        //    Console.WriteLine(s);
        //        //}

        //        Console.WriteLine(variations.Length);

        //        Console.ReadKey();
        //    }
        //}
    }
}
