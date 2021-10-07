using System;
using System.Windows.Forms;


namespace Turing
{
    public partial class MainForm : Form
    {
        int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Turing.Machines.OneLineTuringMachine.OneLineTuringMachineForm();
            form.FormClosed += Form_Closed;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Turing.Machines.TwoLinesTuringMachine.TwoLinesTuringMachine();
            form.Show();
        }

        private void Form_Closed(object sender, EventArgs e)
        {
            if(counter < 10)
            {
                counter++;
                return;
            }
            counter = 0;
            GC.Collect();
        }
    }
}
