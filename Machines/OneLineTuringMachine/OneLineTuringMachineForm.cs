using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.OneLineTuringMachine
{
    public partial class OneLineTuringMachineForm : Form
    {
        bool isOpenFile = false;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        String PreviousAlphabet;

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

        private void TuringMachine_ValuesChanged(object sender, EventArgs e)
        {
            ShowLine();
            if (turingMachine.CurrentCondition == -1)
                CurrentCondition.Text = "qz";
            else
                CurrentCondition.Text = "q" + turingMachine.CurrentCondition.ToString();
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

        private void ShowLine()
        {
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
            if (turingMachine.CurrentCondition == -1)
                CurrentCondition.Text = "qz";
            else
                CurrentCondition.Text = "q" + turingMachine.CurrentCondition.ToString();
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
            if (isOpenFile)
            {
                foreach (char Letter in Alphabet.Text)
                    TableConditions.Rows.Add(GetRowToAdd(Letter));
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
            public char Letter;
            public int PosLetter;
            public char Direction;
            public int PosDirection;
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
            parts.PosDirection = parts.PosLetter = parts.PosNum = -1;
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
                    if (parts.PosLetter == -1)
                    {
                        parts.PosLetter = i;
                        parts.Letter = str[parts.PosLetter];
                        continue;
                    }
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
                            break;
                        }
                        catch { }
                        continue;
                    }

            }

            return parts;
        }

        List<String> strings = new List<string>();

        private void MakeStepButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";
            try
            {
                turingMachine.NextStep();
                ShowLine();
                
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
                String listing = "λ" + turingMachine.Line.GetKAtLine() + "λ";
                if (listing.Length == 2)
                    listing = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ";
                else
                {
                    int pos = turingMachine.CurrentPos - turingMachine.Line.IndexOf(listing[1]) + 1;
                    listing = listing.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                    strings.Add(listing);
                }
                
                turingMachine.NextStep();
                
                ShowLine();
                if (turingMachine.CurrentCondition == -1)
                {
                    timer.Stop();
                    StopWork_Button.Enabled = false;
                    listing = turingMachine.Line.GetKAtLine();
                    if (listing.Length == 2)
                        listing = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ";
                    else
                    {
                        int pos = turingMachine.CurrentPos - turingMachine.Line.IndexOf(listing[0]) + 1;
                        listing = listing.Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                        strings.Add(listing);
                    }
                    MessageBox.Show("Машина Тьюринга завершила работу");
                    Form form = new Form();
                    TextBox textBox = new TextBox();
                    form.Controls.Add(textBox);
                    textBox.Dock = DockStyle.Fill;
                    textBox.Font = new Font(FontFamily.GenericSansSerif, 14f);
                    textBox.ScrollBars = ScrollBars.Both;
                    textBox.Multiline = true;
                    textBox.Text = String.Join(Environment.NewLine, strings);
                    form.Show();
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
                List<String> HeaderCells = new List<String>();

                foreach (DataGridViewColumn x in TableConditions.Columns)
                {
                    DataColumn column = new DataColumn();
                    column.ColumnName = x.Index.ToString();
                    data.Columns.Add(column);
                }

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

        private void Clear_button_Click(object sender, EventArgs e)
        {
            turingMachine.Line = new String('λ', 201);
            turingMachine.CurrentPos = 101;
            turingMachine.CurrentCondition = 0;
            strings.Clear();
            ShowLine();
        }

        private void OneLineTuringMachineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
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
    }
}