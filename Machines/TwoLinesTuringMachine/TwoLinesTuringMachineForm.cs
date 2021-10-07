using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.TwoLinesTuringMachine
{
    public partial class TwoLinesTuringMachineForm : Form
    {
        Label[] labels = new Label[30];
        TuringMachine turingMachine;
        String PreviousAlphabet;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        bool isOpenFile = false;

        public TwoLinesTuringMachineForm()
        {
            InitializeComponent();
            turingMachine = new TuringMachine(ref TableConditions);
            turingMachine.ValuesChanged += TuringMachine_ValuesChanged;
            TableConditions.AllowUserToAddRows = false;
            TableConditions.AllowUserToDeleteRows = false;
            PreviousAlphabet = "";
            AddColumnButton_Click(new object(), new EventArgs());
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.HeaderCell.Value = "λλ";
            TableConditions.Rows.Add(newRow);
            Alphabet.Text = turingMachine.Alphabet;
            PreviousAlphabet = Alphabet.Text;
            OrganizeLabels();
            ShowLine();
            //timer.Tick += Timer_Tick;
            timer.Interval = 800;
        }

        private void OrganizeLabels()
        {
            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            labels[6] = label7;
            labels[7] = label8;
            labels[8] = label9;
            labels[9] = label10;
            labels[10] = label11;
            labels[11] = label12;
            labels[12] = label13;
            labels[13] = label14;
            labels[14] = label15;
            labels[15] = label31;
            labels[16] = label30;
            labels[17] = label29;
            labels[18] = label28;
            labels[19] = label27;
            labels[20] = label26;
            labels[21] = label25;
            labels[22] = label24;
            labels[23] = label23;
            labels[24] = label22;
            labels[25] = label21;
            labels[26] = label20;
            labels[27] = label19;
            labels[28] = label18;
            labels[29] = label17;
        }

        private void TuringMachine_ValuesChanged(object sender, EventArgs e)
        {
            ShowLine();
            if (turingMachine.CurrentCondition == -1)
                CurrentCondition.Text = "qz";
            else
                CurrentCondition.Text = "q" + turingMachine.CurrentCondition.ToString();
        }

        private void ShowLine()
        {
            int pos1 = turingMachine.CurrentPos_First - 7;
            int pos2 = turingMachine.CurrentPos_Second - 7;

            for (int i = 0; i < 15; i++)
            {
                if (turingMachine.Line_First[pos1] != 'λ')
                    labels[i].ForeColor = Color.Black;
                else
                    labels[i].ForeColor = Color.Gray;
                labels[i].Text = turingMachine.Line_First[pos1].ToString();
                pos1++;
            }

            for (int i = 15; i < 30; i++)
            {
                if (turingMachine.Line_Second[pos2] != 'λ')
                    labels[i].ForeColor = Color.Black;
                else
                    labels[i].ForeColor = Color.Gray;
                labels[i].Text = turingMachine.Line_Second[pos2].ToString();
                pos2++;
            }
        }

        private void OnLabelClick(object sender, EventArgs e)
        {
            int label_num = 0;
            for (; label_num < labels.Length; label_num++)
                if (labels[label_num] == sender)
                    break;

            GetElemFromAlphabet getElemFromAlphabet = new GetElemFromAlphabet(Alphabet.Text);
            getElemFromAlphabet.StartPosition = FormStartPosition.Manual;
            getElemFromAlphabet.Location = MousePosition;
            getElemFromAlphabet.Size = new Size(50 * Alphabet.Text.Length, 50);
            getElemFromAlphabet.ShowDialog(this);
            if (getElemFromAlphabet.DialogResult == DialogResult.OK)
            {
                if (label_num <= 14)
                {
                    int pos = turingMachine.CurrentPos_First - 7 + label_num;
                    char[] charArray = turingMachine.Line_First.ToCharArray();
                    charArray.SetValue(getElemFromAlphabet.Letter, pos);
                    turingMachine.Line_First = new string(charArray);
                }
                else
                {
                    int pos = turingMachine.CurrentPos_Second - 7 + label_num - 15;
                    char[] charArray = turingMachine.Line_Second.ToCharArray();
                    charArray.SetValue(getElemFromAlphabet.Letter, pos);
                    turingMachine.Line_Second = new string(charArray);
                }
                ShowLine();
            }
        }
        
        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            int index = TableConditions.Columns.Count;
            TableConditions.Columns.Add(index.ToString(), "q" + index.ToString());
            TableConditions.Columns[TableConditions.Columns.Count - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
            TableConditions.Columns[TableConditions.Columns.Count - 1].Width = 50;
        }

        private void DeleteColumntButton_Click(object sender, EventArgs e)
        {
            if (TableConditions.Columns.Count == 1)
                return;
            if ((int)numericUpDown1.Value > (int)numericUpDown1.Maximum)
                return;
            TableConditions.Columns.RemoveAt(((int)numericUpDown1.Value));

            //выровнять номера
            int index = 0;
            foreach (DataGridViewColumn column in TableConditions.Columns)
            {
                column.HeaderText = "q" + index.ToString();
                column.Name = index.ToString();
                index++;
            }
        }

        private void TableConditions_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            numericUpDown1.Maximum = TableConditions.Columns.Count - 1;
        }

        private DataGridViewRow[] GetRowsToAdd()
        {
            List<String> hasToBe = new List<string>();

            foreach (Char letter1 in Alphabet.Text)
                foreach (Char letter2 in Alphabet.Text)
                    hasToBe.Add(letter1.ToString() + letter2.ToString());

            for (int i = 0; i < TableConditions.Rows.Count; i++)
                if (hasToBe.Contains(TableConditions.Rows[i].HeaderCell.Value))
                    hasToBe.Remove(TableConditions.Rows[i].HeaderCell.Value.ToString());

            DataGridViewRow[] rows = new DataGridViewRow[hasToBe.Count];

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new DataGridViewRow();
                rows[i].HeaderCell.Value = hasToBe[i];
            }

            return rows;
        }
        
        private DataGridViewRow[] GetRowsToDelete(char Letter)
        {
            List<Int32> hasToBeDeleted = new List<int>();
            
            for (int i = 0; i < TableConditions.Rows.Count; i++)
                if (TableConditions.Rows[i].HeaderCell.Value.ToString().Contains(Letter))
                    hasToBeDeleted.Add(i);

            DataGridViewRow[] rows = new DataGridViewRow[hasToBeDeleted.Count];

            for (int i = 0; i < rows.Length; i++)
                rows[i] = TableConditions.Rows[hasToBeDeleted[i]];

            return rows;
        }

        private void Alphabet_TextChanged(object sender, EventArgs e)
        {
            if (isOpenFile)
            {
                TableConditions.Rows.Add(GetRowsToAdd());
                return;
            }
            if (!Alphabet.Text.Contains("λ"))
            {
                Alphabet.Text += "λ";
                Alphabet.SelectionStart = Alphabet.Text.Length;
                return;
            }
            if (!PreviousAlphabet.Contains("λ"))
            {
                PreviousAlphabet = Alphabet.Text;
                Alphabet.SelectionStart = Alphabet.Text.Length;
                return;
            }

            String StrWithDublicates = WorkWithString.RemoveDuplicates(Alphabet.Text);
            if (StrWithDublicates.Length != Alphabet.Text.Length)
            {
                Alphabet.Text = StrWithDublicates;
                Alphabet.SelectionStart = Alphabet.Text.Length;
                return;
            }

            turingMachine.Alphabet = Alphabet.Text;

            String difference = WorkWithString.GetDifference(Alphabet.Text, PreviousAlphabet);

            foreach (char Letter in difference)
            {
                if (PreviousAlphabet.Contains(Letter))
                {
                    //Если в прошлом алфавите эта строка была, а в новом ее нет - удаляем эту строку
                    foreach (DataGridViewRow row in GetRowsToDelete(Letter))
                        TableConditions.Rows.Remove(row);
                }
                else
                {
                    //Добавляем строки
                    foreach (DataGridViewRow row in GetRowsToAdd())
                        TableConditions.Rows.Add(row);
                }
            }
            PreviousAlphabet = Alphabet.Text;
        }

        private void TableConditions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RepairCell(TableConditions[e.ColumnIndex, e.RowIndex],
                TableConditions.Rows[e.RowIndex].HeaderCell.Value.ToString(),
                e.ColumnIndex);
        }

        struct PartsOfCommand
        {
            public char Letter1;
            public int PosLetter1;
            public char Letter2;
            public int PosLetter2;
            public char Direction1;
            public int PosDirection1;
            public char Direction2;
            public int PosDirection2;
            public int Num;
            public int PosNum;
        }

        private void RepairCell(DataGridViewCell Cell, String Row, int Column)
        {
            PartsOfCommand command = GetPartsOfCommand(Cell.Value);

            if (command.PosLetter != -1)
            {
                if (!Alphabet.Text.Contains(command.Letter))
                    command.Letter = Row[0];
            }
            else
                command.Letter = Row[0];

            if (command.PosDirection == -1)
                command.Direction = '>';

            if (command.PosNum != -1)
            {
                if (!(command.Num >= -1 & command.Num <= numericUpDown1.Maximum))
                    command.Num = Column;
            }
            else
                command.Num = Column;

            Cell.Value = command.Letter.ToString() + command.Direction + command.Num;
        }

        private PartsOfCommand GetPartsOfCommand(object obj)
        {
            String str;
            PartsOfCommand parts = new PartsOfCommand();
            parts.PosDirection1 = parts.PosLetter1 = parts.PosDirection2 = parts.PosLetter2 = parts.PosNum = -1;
            if (obj == null)
                return parts;
            else
                str = obj.ToString();
            if (str == null | str.Length == 0)
                return parts;

            for (int i = 0; i < str.Length; i++)
            {
                if (parts.PosLetter == -1)
                    if (Char.IsLetter(str[i]))
                    {
                        parts.PosLetter = i;
                        parts.Letter = str[parts.PosLetter];
                        continue;
                    }

                if (WorkWithString.isDirection(str[i].ToString()))
                {
                    parts.PosDirection = i;
                    parts.Direction = str[parts.PosDirection];
                    continue;
                }

                if (parts.PosNum == -1)
                    if (str.isNumber(i))
                    {
                        try
                        {
                            parts.Num = Convert.ToInt32(str.Substring(i));
                            parts.PosNum = i;
                        }
                        catch { }
                        continue;
                    }

            }

            return parts;
        }
    }
}
