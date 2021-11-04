using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;
using Turing.Library;

namespace Turing.Machines.ViewGraphic.OneLine
{
    public partial class GraphicOneLine : Form
    {
        bool isContinue = true;
        private static ManualResetEvent mre = new ManualResetEvent(false);

        public delegate void DelegateUpdate(int num);
        public delegate bool DelegateisContinue();

        OneLine oneLine;
        Thread thread;
        String Alphabet;

        public GraphicOneLine()
        {
            InitializeComponent();
            this.Visible = true;
            oneLine = new OneLine();
            thread = new Thread(GetData);
            thread.Priority = ThreadPriority.Lowest;
            Alphabet = "abc";
        }

        private void GraphicOneLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread.Start();
        }

        public int CreateAllTasks(int level)
        {
            

            Parallel.For(0, variations.Length, i =>
            {
                try
                {
                    temp[i] = oneLine.DoTask(variations[i]);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            });
            
            return WorkWithArrays.GetMaxFormArray(temp);
        }

        private void GetData()
        {
            try
            {
                for (int i = 0; ; i++)
                {
                    int[] temp = new int[(int)Math.Pow(Alphabet.Length, i)];
                    PermutationsWithRepetition gen = new PermutationsWithRepetition(
                            Alphabet.Trim().ToCharArray(), i);
                    String[] variations = gen.getVariations();

                    int max = 0;

                    for (int j = 0; j < temp.Length; j += 50)
                    {
                        
                    }



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
