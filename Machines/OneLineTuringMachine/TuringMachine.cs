using System;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines.OneLineTuringMachine
{
    class TuringMachine
    {
        public int CurrentPos { get; set; }
        public String Alphabet { get; set; }
        public String Line { get; set; }
        public int CurrentCondition { get; set; }
        private DataGridView DataConditions;

        public TuringMachine(ref DataGridView dataGridView)
        {
            Line = new String('λ', 201);
            CurrentPos = 101;
            Alphabet = "λ";
            DataConditions = dataGridView;
        }

        public void NextStep()
        {
            char Letter = Line[CurrentPos];

            String str = null;

            foreach (DataGridViewRow row in DataConditions.Rows)
                if (row.HeaderCell.Value.ToString() == Letter.ToString())
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
            Line = Line.ChangeValue(CurrentPos, Command[0].ToString());
            if (Command[1] == '>')
                CurrentPos++;
            else if (Command[1] == '<')
                CurrentPos--;
            CurrentCondition = Convert.ToInt32(Command.Substring(2));

            MachineValuesChangedEventArgs args = new MachineValuesChangedEventArgs();
            args.CurrentCondition = CurrentCondition;
            args.CurrentPos = CurrentPos;
            args.Line = Line;
            OnMachineValuesChanged(args);
        }

        protected virtual void OnMachineValuesChanged(MachineValuesChangedEventArgs e)
        {
            MachineValuesChangedEventHandler handler = ValuesChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event MachineValuesChangedEventHandler ValuesChanged;
    }

    public class MachineValuesChangedEventArgs : EventArgs
    {
        public int CurrentPos { get; set; }
        public String Line { get; set; }
        public int CurrentCondition { get; set; }
    }
    public delegate void MachineValuesChangedEventHandler(Object sender, MachineValuesChangedEventArgs e);

}
