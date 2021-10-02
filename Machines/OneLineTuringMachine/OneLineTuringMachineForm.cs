﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.OneLineTuringMachine
{
    public partial class OneLineTuringMachineForm : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        bool flag = true;

        String PreviousAlphabet;

        String LineOnStart;

        TuringMachine turingMachine;

        Label[] labels = new Label[15];

        public OneLineTuringMachineForm()
        {
            InitializeComponent();
            turingMachine = new TuringMachine(ref TableConditions);
            turingMachine.ValuesChanged += TuringMachine_ValuesChanged;
            TableConditions.AllowUserToAddRows = false;
            TableConditions.AllowUserToDeleteRows = false;
            PreviousAlphabet = "";
            AddColumnButton_Click(new object(), new EventArgs());
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.HeaderCell.Value = "λ";
            TableConditions.Rows.Add(newRow);
            Alphabet.Text = turingMachine.Alphabet;
            PreviousAlphabet = Alphabet.Text;
            OrganizeLabels();
            ShowLine();
            timer.Tick += Timer_Tick;
            timer.Interval = 800;
        }

        private void TuringMachine_ValuesChanged(object sender, MachineValuesChangedEventArgs e)
        {
            ShowLine();
            if (e.CurrentCondition == -1)
                CurrentCondition.Text = "qz";
            else
                CurrentCondition.Text = "q" + e.CurrentCondition.ToString();
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
        }

        private void одноленточнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.MinimumSize = new Size(765, 489);
            Form form = new Turing.Machines.OneLineTuringMachine.OneLineTuringMachineForm();
            Control[] controls = new Control[form.Controls.Count];
            form.Controls.CopyTo(controls, 0);
            this.Controls.AddRange(controls);
            OrganizeLabels();
            ShowLine();
        }

        private void ShowLine()
        {
            String str = turingMachine.Line;
            int pos = turingMachine.CurrentPos - 7;
            foreach (Label label in labels)
            {
                if (turingMachine.Line[pos] != 'λ')
                {
                    label.ForeColor = Color.Black;
                }
                else
                {
                    label.ForeColor = Color.Gray;
                }
                label.Text = turingMachine.Line[pos].ToString();
                pos++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (turingMachine.CurrentPos + 7 != turingMachine.Line.Length)
            {
                turingMachine.CurrentPos++;
                ShowLine();
            }
        }

        private void OnLabelClick(object sender, EventArgs e)
        {
            int label_num = 0;
            for (; label_num < labels.Length; label_num++)
                if (labels[label_num] == sender)
                    break;
            int pos = turingMachine.CurrentPos - 7 + label_num;
            GetElemFromAlphabet getElemFromAlphabet = new GetElemFromAlphabet(Alphabet.Text);
            getElemFromAlphabet.StartPosition = FormStartPosition.Manual;
            getElemFromAlphabet.Location = MousePosition;
            getElemFromAlphabet.Size = new Size(50 * Alphabet.Text.Length, 50);
            getElemFromAlphabet.ShowDialog(this);
            if (getElemFromAlphabet.DialogResult == DialogResult.OK)
            {
                char[] charArray = turingMachine.Line.ToCharArray();
                charArray.SetValue(getElemFromAlphabet.Letter, pos);
                turingMachine.Line = new string(charArray);
                ShowLine();
            }
        }

        private void Alphabet_TextChanged(object sender, EventArgs e)
        {
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
                    //Если в прошлом алфавите эта строка была, а в ном ее нет - удаляем эту строку
                    TableConditions.Rows.Remove(GetRowToDelete(Letter));
                }
                else
                {
                    //Добавляем строку
                    TableConditions.Rows.Add(GetRowToAdd(Letter));
                }
            }
            PreviousAlphabet = Alphabet.Text;
        }

        private DataGridViewRow GetRowToAdd(char Letter)
        {
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < TableConditions.Rows.Count; i++)
                if (TableConditions.Rows[i].HeaderCell.Value.ToString() == Letter.ToString())
                    return row;
            row.HeaderCell.Value = Letter.ToString();
            foreach (DataGridViewCell Cell in row.Cells)
                Cell.Value = null;
            return row;
        }

        private DataGridViewRow GetRowToDelete(char Letter)
        {
            DataGridViewRow row = new DataGridViewRow();

            for (int i = 0; i < TableConditions.Rows.Count; i++)
                if (TableConditions.Rows[i].HeaderCell.Value.ToString() == Letter.ToString())
                {
                    row = TableConditions.Rows[i];
                    return row;
                }
            return row;
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

        private void TableConditions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RepairCell(TableConditions[e.ColumnIndex, e.RowIndex], 
                TableConditions.Rows[e.RowIndex].HeaderCell.Value.ToString(), 
                e.ColumnIndex);
        }

        private void RepairCell(DataGridViewCell Cell, String Row, int Column)
        {
            String str = null;
            if (Cell.Value == null)
                str = new String(' ', 3);
            else
                str = Cell.Value.ToString();

            if (str.Length < 3)
                str = new String(' ', 3);
            if (!Alphabet.Text.Contains(str[0]))
                str = str.ChangeValue(0, Row);
            if (!WorkWithString.isDirection(str[1].ToString()))
                str = str.ChangeValue(1, ">");
            String substr = str.Substring(2);
            try
            {
                int num = Convert.ToInt32(str.Substring(2));
                if (!(num >= -1 && num <= numericUpDown1.Maximum))
                    str = str.ChangeValue(2, str.Length, Column.ToString());
            }
            catch
            {
                str = str.ChangeValue(2, str.Length, Column.ToString());
            }
            Cell.Value = str;
        }

        private void MakeStepButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";
            LineOnStart = turingMachine.Line;
            try
            {
                turingMachine.NextStep();
                if (turingMachine.CurrentCondition == -1)
                {
                    MessageBox.Show("Машина Тьюринга завершила работу");
                    return;
                }
            }
            catch (Exception except)
            {
                //Сообщение об отсутствии команды
                MessageBox.Show(except.Message);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            if (LineOnStart != null)
                turingMachine.Line = LineOnStart;
            else
                turingMachine.Line = new String('λ', 201);
            CurrentCondition.Text = "q0";
            turingMachine.CurrentPos = 101;
            turingMachine.CurrentCondition = 0;
            ShowLine();
        }

        private void DoAllSteps_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";
            LineOnStart = turingMachine.Line;
            timer.Start();
            StopWork_Button.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                turingMachine.NextStep();
                ShowLine();
                if (turingMachine.CurrentCondition == -1)
                {
                    timer.Stop();
                    StopWork_Button.Enabled = false;
                    MessageBox.Show("Машина Тьюринга завершила работу");
                }
                
            }
            catch (Exception except)
            {
                timer.Stop();
                MessageBox.Show(except.Message);
            }
        }

        private void OnTimerSpeedClick(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (ToolStripMenuItem elment in скоростьВыполненияToolStripMenuItem.DropDownItems)
            {
                if (sender == elment)
                    break;
                counter++;
            }
            switch (counter)
            {
                case 0:
                    timer.Interval = 800;
                    break;
                case 1:
                    timer.Interval = 600;
                    break;
                case 2:
                    timer.Interval = 300;
                    break;
                case 3:
                    timer.Interval = 150;
                    break;
                case 4:
                    timer.Interval = 50;
                    break;
                case 5:
                    timer.Interval = 2;
                    break;
            }
        }

        private void ButtonToLeft_Click(object sender, EventArgs e)
        {
            if (turingMachine.CurrentPos + 7 != turingMachine.Line.Length)
            {
                turingMachine.CurrentPos++;
                ShowLine();
            }
        }

        private void ButtonToRight_Click(object sender, EventArgs e)
        {
            if (turingMachine.CurrentPos - 7 != 0)
            {
                turingMachine.CurrentPos--;
                ShowLine();
            }
        }

        private void StopWork_Button_Click(object sender, EventArgs e)
        {
            StopWork_Button.Enabled = false;
            timer.Stop();
        }
    }
}
