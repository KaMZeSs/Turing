using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Turing.Machines.OneLineTuringMachine;
using System.Threading.Tasks;

namespace Turing.Machines.ViewGraphic
{
    class OneLine
    {
        DataGridView TableConditions;
        String Alphabet;

        List<int> allResults;

        public OneLine()
        {
            TableConditions = new DataGridView();
            Alphabet = "abc";
            List<int> allResults = new List<int>();
            OpenTable();
        }

        public void Work()
        {
            for (int i = 0; ; i++)
            {
                MessageBox.Show(CreateAllTasks(i).ToString());
            }
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
                String st = (string)dataSet.ExtendedProperties["HeaderCells"];
                String[] HCells = st.Trim().Split(' ');
                for (int i = 0; i < data.Columns.Count - 1; i++)
                {
                    int index = TableConditions.Columns.Count;
                    TableConditions.Columns.Add(index.ToString(), "q" + index.ToString());
                }

                for (int i = 0; i < HCells.Length; i++)
                {
                    TableConditions.Rows.Add();
                }

                for (int i = 0; i < HCells.Length; i++)
                {
                    TableConditions.Rows[i].HeaderCell.Value = HCells[i];
                    for (int j = 0; j < TableConditions.Columns.Count; j++)
                    {
                        String str = data.Rows[i][j].ToString();
                        TableConditions[j, i].Value = str;
                    }
                }
            }
        }

        public int CreateAllTasks(int level)
        {
            int[] temp = new int[(int)Math.Pow(Alphabet.Length, level)];
            PermutationsWithRepetition gen = new PermutationsWithRepetition(
                    Alphabet.Trim().ToCharArray(), level);
            String[] variations = gen.getVariations();

            Parallel.For(0, variations.Length, i =>
            {
                try
                {
                    temp[i] = DoTask(variations[i]);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            });
            return GetMaxFormArray(temp);
        }

        private int DoTask(String line)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";

            TuringMachine turingMachine = new TuringMachine(ref TableConditions, line);

            int counter = 0;
            while (true)
            {
                try
                {
                    turingMachine.NextStep();
                    counter++;
                }
                catch (Exception except)
                {
                    if (turingMachine.CurrentCondition == -1)
                        break;
                    else
                        throw new Exception($"Ошибка команд\n{line}\nСостояние : {turingMachine.CurrentCondition}\nСчетчик: {counter}");
                }
            }
            return counter;
        }

        private int GetMaxFormArray(int[] array)
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
    }
}
