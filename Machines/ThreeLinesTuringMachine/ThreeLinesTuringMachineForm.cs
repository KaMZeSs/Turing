﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.ThreeLinesTuringMachine
{
    public partial class ThreeLinesTuringMachineForm : Form
    {
        Label[] labels = new Label[45];
        TuringMachine turingMachine;
        String PreviousAlphabet;
        Timer timer = new Timer();
        bool isOpenFile = false;

        Form formListing = new Form();
        TextBox formListing_textBox = new TextBox();

        StreamWriter streamWriter = new StreamWriter($"Listing_ThreeLines_{DateTime.Now.ToString().Replace('.', '_').Replace(' ', '_').Replace(':', '_')}.txt");

        public ThreeLinesTuringMachineForm()
        {
            InitializeComponent();
            turingMachine = new TuringMachine(ref TableConditions);
            turingMachine.ValuesChanged += TuringMachine_ValuesChanged;
            TableConditions.AllowUserToAddRows = false;
            TableConditions.AllowUserToDeleteRows = false;
            PreviousAlphabet = "";
            AddColumnButton_Click(new object(), new EventArgs());
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.HeaderCell.Value = "λλλ";
            TableConditions.Rows.Add(newRow);
            Alphabet.Text = turingMachine.Alphabet;
            PreviousAlphabet = Alphabet.Text;
            OrganizeLabels();
            ShowLine();
            timer.Tick += Timer_Tick;
            timer.Interval = 800;

            formListing.FormClosing += FormListing_FormClosing;
            formListing.Controls.Add(formListing_textBox);
            formListing_textBox.Dock = DockStyle.Fill;
            formListing_textBox.Font = new Font(FontFamily.GenericSansSerif, 14f);
            formListing_textBox.ScrollBars = ScrollBars.Both;
            formListing_textBox.Multiline = true;
            formListing_textBox.ReadOnly = true;

            streamWriter.AutoFlush = true;
        }

        private void FormListing_FormClosing(object sender, FormClosingEventArgs e)
        {
            formListing.Hide();
            e.Cancel = true;
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

            labels[30] = label45;
            labels[31] = label44;
            labels[32] = label43;
            labels[33] = label42;
            labels[34] = label41;
            labels[35] = label40;
            labels[36] = label39;
            labels[37] = label38;
            labels[38] = label37;
            labels[39] = label36;
            labels[40] = label35;
            labels[41] = label34;
            labels[42] = label33;
            labels[43] = label16;
            labels[44] = label46;
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
            int pos3 = turingMachine.CurrentPos_Third - 7;

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

            for (int i = 30; i < 45; i++)
            {
                if (turingMachine.Line_Third[pos3] != 'λ')
                    labels[i].ForeColor = Color.Black;
                else
                    labels[i].ForeColor = Color.Gray;
                labels[i].Text = turingMachine.Line_Third[pos3].ToString();
                pos3++;
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
                    ShowLine();
                    return;
                }
                else if (label_num <= 29)
                {
                    int pos = turingMachine.CurrentPos_Second - 7 + label_num - 15;
                    char[] charArray = turingMachine.Line_Second.ToCharArray();
                    charArray.SetValue(getElemFromAlphabet.Letter, pos);
                    turingMachine.Line_Second = new string(charArray);
                    ShowLine();
                    return;
                }
                else if (label_num <= 44)
                {
                    int pos = turingMachine.CurrentPos_Third - 7 + label_num - 30;
                    char[] charArray = turingMachine.Line_Third.ToCharArray();
                    charArray.SetValue(getElemFromAlphabet.Letter, pos);
                    turingMachine.Line_Third = new string(charArray);
                    ShowLine();
                    return;
                }
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
                    foreach (Char letter3 in Alphabet.Text)
                        hasToBe.Add(letter1.ToString() + letter2.ToString() +
                            letter3.ToString());

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
                foreach (DataGridViewRow row in GetRowsToAdd())
                    TableConditions.Rows.Add(row);
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
            if (TableConditions[e.ColumnIndex, e.RowIndex].Value == null)
                return;
            if (TableConditions[e.ColumnIndex, e.RowIndex].Value.ToString().Length == 0)
                return;
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
            public char Letter3;
            public int PosLetter3;
            public char Direction1;
            public int PosDirection1;
            public char Direction2;
            public int PosDirection2;
            public char Direction3;
            public int PosDirection3;
            public int Num;
            public int PosNum;
        }

        private void RepairCell(DataGridViewCell Cell, String Row, int Column)
        {
            PartsOfCommand command = GetPartsOfCommand(Cell.Value);

            if (command.PosLetter1 != -1)
            {
                if (!Alphabet.Text.Contains(command.Letter1))
                    command.Letter1 = Row[0];
            }
            else
                command.Letter1 = Row[0];

            if (command.PosLetter2 != -1)
            {
                if (!Alphabet.Text.Contains(command.Letter2))
                    command.Letter2 = Row[1];
            }
            else
                command.Letter2 = Row[1];

            if (command.PosLetter3 != -1)
            {
                if (!Alphabet.Text.Contains(command.Letter3))
                    command.Letter3 = Row[2];
            }
            else
                command.Letter3 = Row[2];

            if (command.PosDirection1 == -1)
                command.Direction1 = '>';

            if (command.PosDirection2 == -1)
                command.Direction2 = '>';

            if (command.PosDirection3 == -1)
                command.Direction3 = '>';

            if (command.PosNum != -1)
            {
                if (!(command.Num >= -1 & command.Num <= numericUpDown1.Maximum))
                    command.Num = Column;
            }
            else
                command.Num = Column;

            Cell.Value = $"{command.Letter1}{command.Direction1}{command.Letter2}{command.Direction2}{command.Letter3}{command.Direction3}{command.Num}";
        }

        private PartsOfCommand GetPartsOfCommand(object obj)
        {
            String str;
            PartsOfCommand parts = new PartsOfCommand();
            parts.PosDirection1 = parts.PosLetter1 = parts.PosDirection2 = parts.PosLetter2
                = parts.PosDirection3 = parts.PosLetter3 = parts.PosNum = -1;
            if (obj == null)
                return parts;
            else
                str = obj.ToString();
            if (str == null | str.Length == 0)
                return parts;

            for (int i = 0; i < str.Length; i++)
            {
                if (Alphabet.Text.Contains(str[i]))
                {
                    if (parts.PosLetter1 == -1)
                    {
                        parts.PosLetter1 = i;
                        parts.Letter1 = str[i];
                        continue;
                    }
                    if (parts.PosLetter2 == -1)
                    {
                        parts.PosLetter2 = i;
                        parts.Letter2 = str[i];
                        if (parts.PosDirection1 == -1)
                            parts.PosDirection1 = -2;
                        continue;
                    }
                    if (parts.PosLetter3 == -1)
                    {
                        parts.PosLetter3 = i;
                        parts.Letter3 = str[i];
                        if (parts.PosDirection2 == -1)
                            parts.PosDirection2 = -2;
                        continue;
                    }
                }

                if (WorkWithString.isDirection(str[i].ToString()))
                {
                    if (parts.PosDirection1 == -1)
                    {
                        parts.PosDirection1 = i;
                        parts.Direction1 = str[i];
                        continue;
                    }
                    if (parts.PosDirection2 == -1)
                    {
                        parts.PosDirection2 = i;
                        parts.Direction2 = str[i];
                        if (parts.PosLetter1 == -1)
                            parts.PosLetter1 = -2;
                        continue;
                    }
                    if (parts.PosDirection3 == -1)
                    {
                        parts.PosDirection3 = i;
                        parts.Direction3 = str[i];
                        if (parts.PosLetter2 == -1)
                            parts.PosLetter2 = -2;
                        continue;
                    }
                }

                if (str.isNumber(i))
                {
                    try
                    {
                        parts.Num = Convert.ToInt32(str.Substring(i));
                        parts.PosNum = i;
                        break;
                    }
                    catch { }
                }
            }

            if (parts.PosLetter1 == -2)
                parts.PosLetter1 = -1;
            if (parts.PosLetter2 == -2)
                parts.PosLetter2 = -1;
            if (parts.PosLetter3 == -2)
                parts.PosLetter3 = -1;
            if (parts.PosDirection1 == -2)
                parts.PosDirection1 = -1;
            if (parts.PosDirection2 == -2)
                parts.PosDirection2 = -1;
            if (parts.PosDirection3 == -2)
                parts.PosDirection3 = -1;

            return parts;
        }

        private void MakeStepButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";
            try
            {
                String listing1 = "λ" + turingMachine.Line_First.GetKAtLine() + "λ" + Environment.NewLine;
                String listing2 = "λ" + turingMachine.Line_Second.GetKAtLine() + "λ" + Environment.NewLine;
                String listing3 = "λ" + turingMachine.Line_Third.GetKAtLine() + "λ" + Environment.NewLine;
                if (listing1.Length == 4)
                    listing1 = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ" + Environment.NewLine;
                else
                {
                    int pos = turingMachine.CurrentPos_First - turingMachine.Line_First.IndexOf(listing1[1]) + 1;
                    listing1 = listing1.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                }
                if (listing2.Length == 4)
                    listing2 = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ" + Environment.NewLine;
                else
                {
                    int pos = turingMachine.CurrentPos_Second - turingMachine.Line_Second.IndexOf(listing2[1]) + 1;
                    listing2 = listing2.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                }
                if (listing3.Length == 4)
                    listing3 = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ" + Environment.NewLine;
                else
                {
                    int pos = turingMachine.CurrentPos_Third - turingMachine.Line_Third.IndexOf(listing3[1]) + 1;
                    listing3 = listing3.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                }

                formListing_textBox.AppendText(listing1 + listing2 + listing3 + Environment.NewLine);
                streamWriter.WriteLine(listing1 + listing2 + listing3);

                turingMachine.NextStep();
                ShowLine();

                if (turingMachine.CurrentCondition == -1)
                {
                    listing1 = "λ" + turingMachine.Line_First.GetKAtLine() + "λ" + Environment.NewLine;
                    listing2 = "λ" + turingMachine.Line_Second.GetKAtLine() + "λ" + Environment.NewLine;
                    listing3 = "λ" + turingMachine.Line_Third.GetKAtLine() + "λ" + Environment.NewLine;
                    if (listing1.Length == 4)
                        listing1 = "λ" + "qz" + "λ" + Environment.NewLine;
                    else
                    {
                        int pos = turingMachine.CurrentPos_First - turingMachine.Line_First.IndexOf(listing1[1]) + 1;
                        listing1 = listing1.Insert(pos < 0 ? 0 : pos, "qz");
                    }
                    if (listing2.Length == 4)
                        listing2 = "λ" + "qz" + "λ" + Environment.NewLine;
                    else
                    {
                        int pos = turingMachine.CurrentPos_Second - turingMachine.Line_Second.IndexOf(listing2[1]) + 1;
                        listing2 = listing2.Insert(pos < 0 ? 0 : pos, "qz");
                    }
                    if (listing3.Length == 4)
                        listing3 = "λ" + "qz" + "λ" + Environment.NewLine;
                    else
                    {
                        int pos = turingMachine.CurrentPos_Third - turingMachine.Line_Third.IndexOf(listing3[1]) + 1;
                        listing3 = listing3.Insert(pos < 0 ? 0 : pos, "qz");
                    }

                    formListing_textBox.AppendText(listing1 + listing2 + listing3 + Environment.NewLine);
                    streamWriter.WriteLine(listing1 + listing2 + listing3);

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

        private void DoAllSteps_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";
            timer.Start();
            StopWork_Button.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                String listing1 = "λ" + turingMachine.Line_First.GetKAtLine() + "λ" + Environment.NewLine;
                String listing2 = "λ" + turingMachine.Line_Second.GetKAtLine() + "λ" + Environment.NewLine;
                String listing3 = "λ" + turingMachine.Line_Third.GetKAtLine() + "λ" + Environment.NewLine;
                if (listing1.Length == 4)
                    listing1 = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ" + Environment.NewLine;
                else
                {
                    int pos = turingMachine.CurrentPos_First - turingMachine.Line_First.IndexOf(listing1[1]) + 1;
                    listing1 = listing1.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                }
                if (listing2.Length == 4)
                    listing2 = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ" + Environment.NewLine;
                else
                {
                    int pos = turingMachine.CurrentPos_Second - turingMachine.Line_Second.IndexOf(listing2[1]) + 1;
                    listing2 = listing2.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                }
                if (listing3.Length == 4)
                    listing3 = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ" + Environment.NewLine;
                else
                {
                    int pos = turingMachine.CurrentPos_Third - turingMachine.Line_Third.IndexOf(listing3[1]) + 1;
                    listing3 = listing3.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                }

                formListing_textBox.AppendText(listing1 + listing2 + listing3 + Environment.NewLine);
                streamWriter.WriteLine(listing1 + listing2 + listing3);

                turingMachine.NextStep();
                ShowLine();
                if (turingMachine.CurrentCondition == -1)
                {
                    listing1 = "λ" + turingMachine.Line_First.GetKAtLine() + "λ" + Environment.NewLine;
                    listing2 = "λ" + turingMachine.Line_Second.GetKAtLine() + "λ" + Environment.NewLine;
                    listing3 = "λ" + turingMachine.Line_Third.GetKAtLine() + "λ" + Environment.NewLine;
                    if (listing1.Length == 4)
                        listing1 = "λ" + "qz" + "λ" + Environment.NewLine;
                    else
                    {
                        int pos = turingMachine.CurrentPos_First - turingMachine.Line_First.IndexOf(listing1[1]) + 1;
                        listing1 = listing1.Insert(pos < 0 ? 0 : pos, "qz");
                    }
                    if (listing2.Length == 4)
                        listing2 = "λ" + "qz" + "λ" + Environment.NewLine;
                    else
                    {
                        int pos = turingMachine.CurrentPos_Second - turingMachine.Line_Second.IndexOf(listing2[1]) + 1;
                        listing2 = listing2.Insert(pos < 0 ? 0 : pos, "qz");
                    }
                    if (listing3.Length == 4)
                        listing3 = "λ" + "qz" + "λ" + Environment.NewLine;
                    else
                    {
                        int pos = turingMachine.CurrentPos_Third - turingMachine.Line_Third.IndexOf(listing3[1]) + 1;
                        listing3 = listing3.Insert(pos < 0 ? 0 : pos, "qz");
                    }

                    formListing_textBox.AppendText(listing1 + listing2 + listing3 + Environment.NewLine);
                    streamWriter.WriteLine(listing1 + listing2 + listing3);

                    timer.Stop();
                    StopWork_Button.Enabled = false;
                    MessageBox.Show("Машина Тьюринга завершила работу");
                }

            }
            catch (Exception except)
            {
                timer.Stop();
                StopWork_Button.Enabled = false;
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
            if (sender == ButtonToLeftFirst)
                if (turingMachine.CurrentPos_First + 7 != turingMachine.Line_First.Length)
                    turingMachine.CurrentPos_First++;
            if (sender == ButtonToLeftSecond)
                if (turingMachine.CurrentPos_Second + 7 != turingMachine.Line_Second.Length)
                    turingMachine.CurrentPos_Second++;
            if (sender == ButtonToLeftThird)
                if (turingMachine.CurrentPos_Third + 7 != turingMachine.Line_Third.Length)
                    turingMachine.CurrentPos_Third++;
            ShowLine();
        }

        private void ButtonToRight_Click(object sender, EventArgs e)
        {
            if (sender == ButtonToRightFirst)
                if (turingMachine.CurrentPos_First - 7 != turingMachine.Line_First.Length)
                    turingMachine.CurrentPos_First--;
            if (sender == ButtonToRightSecond)
                if (turingMachine.CurrentPos_Second - 7 != turingMachine.Line_Second.Length)
                    turingMachine.CurrentPos_Second--;
            if (sender == ButtonToRightThird)
                if (turingMachine.CurrentPos_Third - 7 != turingMachine.Line_Third.Length)
                    turingMachine.CurrentPos_Third--;
            ShowLine();
        }

        private void StopWork_Button_Click(object sender, EventArgs e)
        {
            StopWork_Button.Enabled = false;
            timer.Stop();
        }

        private void TwoLinesTuringMachineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            turingMachine.Line_First = new String('λ', 201);
            turingMachine.Line_Second = new String('λ', 201);
            turingMachine.Line_Third = new String('λ', 201);
            turingMachine.CurrentPos_First = 101;
            turingMachine.CurrentPos_Second = 101;
            turingMachine.CurrentPos_Third = 101;
            turingMachine.CurrentCondition = 0;
            CurrentCondition.Text = "q0";
            ShowLine();
        }

        private void SaveMachine_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.AddExtension = true;
            fileDialog.Filter = "XML|*.xml";
            fileDialog.CheckPathExists = true;
            fileDialog.ValidateNames = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!fileDialog.FileName.EndsWith(".xml"))
                    fileDialog.FileName += ".xml";

                DataTable data = new DataTable();

                foreach (DataGridViewColumn x in TableConditions.Columns)
                {
                    DataColumn column = new DataColumn();
                    column.ColumnName = x.Index.ToString();
                    data.Columns.Add(column);
                }

                List<String> HeaderCells = new List<String>();
                foreach (DataGridViewRow x in TableConditions.Rows)
                {
                    DataRow Row = data.NewRow();
                    String[] values = new String[TableConditions.Columns.Count];

                    int counter = 0;
                    foreach (DataGridViewCell Cell in x.Cells)
                    {
                        if (Cell.Value == null)
                            values[counter] = "";
                        else
                            values[counter] = Cell.Value.ToString();
                        counter++;
                    }
                    Row.ItemArray = values;
                    HeaderCells.Add(x.HeaderCell.Value.ToString());
                    data.Rows.Add(Row);
                }

                String toSaveHeaders = "";

                foreach (String s in HeaderCells)
                    toSaveHeaders += s + " ";

                DataSet ds = new DataSet();
                ds.Tables.Add(data);
                ds.ExtendedProperties.Add("HeaderCells", toSaveHeaders);
                ds.ExtendedProperties.Add("Alphabet", Alphabet.Text);

                try
                {
                    ds.WriteXml(fileDialog.FileName, XmlWriteMode.WriteSchema);
                }
                catch { }
            }
        }

        private void OpenMachine_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.AddExtension = true;
            fileDialog.Filter = "XML|*.xml";
            fileDialog.CheckPathExists = true;
            fileDialog.ValidateNames = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                isOpenFile = true;
                TableConditions.Rows.Clear();

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


                PreviousAlphabet = "";

                Alphabet.Text = (string)dataSet.ExtendedProperties["Alphabet"];
                String st = (string)dataSet.ExtendedProperties["HeaderCells"];
                String[] HCells = st.Trim().Split(' ');
                for (int i = 0; i < data.Columns.Count - 1; i++)
                    AddColumnButton_Click(new object(), new EventArgs());

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
            isOpenFile = false;
        }

        private void EnterWord_Button_Click(object sender, EventArgs e)
        {
            GetInputFromAlphabet form = new GetInputFromAlphabet(Alphabet.Text);
            form.ShowDialog(this);

            if (form.DialogResult == DialogResult.OK)
            {
                Clear_button_Click(sender, e);
                turingMachine = new TuringMachine(ref TableConditions, form.result);
                ShowLine();
            }
            form.Close();
        }

        private void Listing_button_Click(object sender, EventArgs e)
        {
            formListing.Visible = !formListing.Visible;
        }
    }
}
