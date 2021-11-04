using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Turing.Machines.OneLineTuringMachine;


namespace Turing.Machines.ViewGraphic.OneLine
{
    class OneLine
    {
        DataGridView TableConditions;

        List<int> allResults;

        public OneLine()
        {
            TableConditions = new DataGridView();
            List<int> allResults = new List<int>();
            OpenTable();
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

        public int DoTask(String line)
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
    }
}
