using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Turing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            одноленточнаяToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private void одноленточнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Form form = new Turing.Machines.OneLineTuringMachine.OneLineTuringMachineForm();
            Control[] controls = new Control[form.Controls.Count];
            form.Controls.CopyTo(controls, 0);
            this.Controls.AddRange(controls);
        }
    }
}
