using System;
using System.Data;
using System.Windows.Forms;
using Turing.Machines.OneLineTuringMachine;
using Turing.Machines.ViewGraphic;

namespace Turing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Turing.Machines.OneLineTuringMachine.OneLineTuringMachineForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Turing.Machines.FourLinesTuringMachine.FourLinesTuringMachineForm();
            form.Show();
        }

        private void OpenThreeLines(object sender, EventArgs e)
        {
            Form form = new Turing.Machines.ThreeLinesTuringMachine.ThreeLinesTuringMachineForm();
            form.Show();
        }

        private void OneLineGraphic_Click(object sender, EventArgs e)
        {
            Form form = new Machines.ViewGraphic.OneLine.GraphicOneLine();
            if (!form.IsDisposed)
                form.Show(this);
        }

        private void ThreeLinesGraphic_Click(object sender, EventArgs e)
        {
            Form form = new Machines.ViewGraphic.ThreeLines.GraphicThreeLines();
            if (!form.IsDisposed)
                form.Show(this);
        }

        private void FourLinesGraphic_Click(object sender, EventArgs e)
        {
            Form form = new Machines.ViewGraphic.FourLines.GraphicFourLines();
            if (!form.IsDisposed)
                form.Show(this);
        }
    }
}
