using System;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.FourLinesTuringMachine
{
    class TuringMachine
    {
        public int CurrentPos_First { get; set; }
        public int CurrentPos_Second { get; set; }
        public int CurrentPos_Third { get; set; }
        public int CurrentPos_Fourth { get; set; }
        public String Alphabet { get; set; }
        public String Line_First { get; set; }
        public String Line_Second { get; set; }
        public String Line_Third { get; set; }
        public String Line_Fourth { get; set; }
        public int CurrentCondition { get; set; }
        private DataGridView DataConditions;

        public TuringMachine(ref DataGridView dataGridView)
        {
            Line_First = new String('λ', 201);
            Line_Second = new String('λ', 201);
            Line_Third = new String('λ', 201);
            Line_Fourth = new String('λ', 201);
            CurrentPos_First = 101;
            CurrentPos_Second = 101;
            CurrentPos_Third = 101;
            CurrentPos_Fourth = 101;
            Alphabet = "λ";
            DataConditions = dataGridView;
        }

        public void NextStep()
        {
            char Letter1 = Line_First[CurrentPos_First], Letter2 = Line_Second[CurrentPos_Second],
                Letter3 = Line_Third[CurrentPos_Third], Letter4 = Line_Fourth[CurrentPos_Fourth];

            String str = null;

            if (CurrentCondition == -1)
                throw new Exception("Машина Тьюринга не может продолжать работу в состоянии qz");
            foreach (DataGridViewRow row in DataConditions.Rows)
                if (row.HeaderCell.Value.ToString() == Letter1.ToString() + 
                    Letter2.ToString() + Letter3.ToString() + Letter4.ToString())
                {
                    str = row.Cells[CurrentCondition].Value.ToString();
                    break;
                }

            if (str == "")
                throw new Exception("No Command");

            ExecuteCommand(str);
        }

        private void ExecuteCommand(String Command)
        {
            Line_First = Line_First.ChangeValue(CurrentPos_First, Command[0].ToString());
            Line_Second = Line_Second.ChangeValue(CurrentPos_Second, Command[2].ToString());
            Line_Third = Line_Third.ChangeValue(CurrentPos_Third, Command[4].ToString());
            Line_Fourth = Line_Fourth.ChangeValue(CurrentPos_Fourth, Command[6].ToString());
            
            if (Command[1] == '>')
                CurrentPos_First++;
            else if (Command[1] == '<')
                CurrentPos_First--;
            if (Command[3] == '>')
                CurrentPos_Second++;
            else if (Command[3] == '<')
                CurrentPos_Second--;
            if (Command[5] == '>')
                CurrentPos_Third++;
            else if (Command[5] == '<')
                CurrentPos_Third--;
            if (Command[7] == '>')
                CurrentPos_Fourth++;
            else if (Command[7] == '<')
                CurrentPos_Fourth--;

            CurrentCondition = Convert.ToInt32(Command.Substring(4));

            if (CurrentPos_First == Line_First.Length - 20)
                Line_First += new string('λ', 100);
            if (CurrentPos_Second == Line_Second.Length - 20)
                Line_Second += new string('λ', 100);
            if (CurrentPos_Third == Line_Third.Length - 20)
                Line_Third += new string('λ', 100);
            if (CurrentPos_Fourth == Line_Fourth.Length - 20)
                Line_Fourth += new string('λ', 100);
            if (CurrentPos_First == 20)
            {
                Line_First = new string('λ', 100) + Line_First;
                CurrentPos_First += 100;
            }
            if (CurrentPos_Second == 20)
            {
                Line_Second = new string('λ', 100) + Line_Second;
                CurrentPos_Second += 100;
            }
            if (CurrentPos_Third == 20)
            {
                Line_Third = new string('λ', 100) + Line_Third;
                CurrentPos_Third += 100;
            }
            if (CurrentPos_Fourth == 20)
            {
                Line_Fourth = new string('λ', 100) + Line_Fourth;
                CurrentPos_Fourth += 100;
            }

            OnMachineValuesChanged(new EventArgs());
        }

        protected virtual void OnMachineValuesChanged(EventArgs e)
        {
            MachineValuesChangedEventHandler handler = ValuesChanged;
            if (handler != null)
                handler(this, e);
        }

        public event MachineValuesChangedEventHandler ValuesChanged;
    }
    public delegate void MachineValuesChangedEventHandler(Object sender, EventArgs e);
}
