using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Turing.Machines.ViewGraphic
{
    public partial class GraphicOneLine : Form
    {
        bool isContinue = true;
        private static ManualResetEvent mre = new ManualResetEvent(false);

        public delegate void DelegateUpdate(int num);
        public delegate bool DelegateisContinue();

        OneLine oneLine;
        Thread thread;
        public GraphicOneLine()
        {
            InitializeComponent();
            this.Visible = true;
            oneLine = new OneLine();
            thread = new Thread(GetData);
            thread.Priority = ThreadPriority.Lowest;
        }

        private void GraphicOneLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread.Start();
        }

        private void GetData()
        {
            try
            {
                for (int i = 0; ; i++)
                {
                    // Подавать инфу порционно
                    int max = oneLine.CreateAllTasks(i);
                    BeginInvoke(new DelegateUpdate(Update), max);
                    var result = (bool)Invoke(new DelegateisContinue(GetisContinue));
                    if (!result)
                        mre.WaitOne();
                }
            }
            catch (ThreadInterruptedException e)
            {
                return;
            }
        }   

        private void Update(int num)
        {
            label1.Text += " " + num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isContinue = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isContinue = true;
            mre.Set();
        }

        public bool GetisContinue()
        {
            return isContinue;
        }
    }
}
