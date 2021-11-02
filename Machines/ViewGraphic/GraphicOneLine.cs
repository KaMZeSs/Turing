using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Turing.Machines.ViewGraphic
{
    public partial class GraphicOneLine : Form
    {
        OneLine oneLine;
        public GraphicOneLine()
        {
            InitializeComponent();
            this.Visible = true;
            oneLine = new OneLine();
        }

        private void GraphicOneLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; ; i++)
            {
                label1.Text += " " + oneLine.CreateAllTasks(i).ToString();
            }
        }
    }
}
