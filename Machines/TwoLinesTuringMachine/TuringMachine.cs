using System;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.TwoLinesTuringMachine
{
    class TuringMachine
    {
        public int CurrentPos_First { get; set; }
        public int CurrentPos_Second { get; set; }
        public String Alphabet { get; set; }
        public String Line_First { get; set; }
        public String Line_Second { get; set; }
        public int CurrentCondition { get; set; }
        private DataGridView DataConditions;

        public TuringMachine(ref DataGridView dataGridView)
        {
            Line_First = new String('λ', 201);
            Line_Second = new String('λ', 201);
            CurrentPos_First = 101;
            CurrentPos_Second = 101;
            Alphabet = "λ";
            DataConditions = dataGridView;
        }

        public void NextStep()
        {
            char Letter1 = Line_First[CurrentPos_First], Letter2 = Line_Second[CurrentPos_Second];

            String str = null;

            foreach (DataGridViewRow row in DataConditions.Rows)
                if (row.HeaderCell.Value.ToString() == Letter1.ToString() + Letter2.ToString())
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
            
            if (Command[1] == '>')
                CurrentPos_First++;
            else if (Command[1] == '<')
                CurrentPos_First--;
            if (Command[3] == '>')
                CurrentPos_Second++;
            else if (Command[3] == '<')
                CurrentPos_Second--;

            CurrentCondition = Convert.ToInt32(Command.Substring(4));
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
