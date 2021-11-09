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
using Turing.Machines.OneLineTuringMachine;

namespace Turing.Machines.ViewGraphic.OneLine
{
    public delegate int DelegateThreading(String str);
    public partial class GraphicOneLine : Form
    {
        int ThreadsCount;
        public static bool isPause = false;
        public static bool isStop = false;
        public static bool isStopped = false;
        private static ManualResetEvent mre = new ManualResetEvent(false);

        public delegate void DelegateUpdate(int num);
        public delegate void DelegateClose();
        public delegate bool DelegateGetState();
        public delegate void DelegateUpdate2(int num, int level);
        

        Thread thread;
        String Alphabet;
        DataGridView TableConditions;
        List<int> allResults;
        Task task;
        public GraphicOneLine()
        {
            InitializeComponent();
            thread = new Thread(GetData);
            thread.Priority = ThreadPriority.Lowest;
            thread.Name = "OneLine";
            Alphabet = "abc";
            task = new Task(() => GetData());
            TableConditions = new DataGridView();
            allResults = new List<int>();
            ThreadsCount = Environment.ProcessorCount;
            OpenTable();
        }

        private void OpenTable()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.AddExtension = true;
            fileDialog.Filter = "XML|*.xml";
            fileDialog.CheckPathExists = true;
            fileDialog.ValidateNames = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
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
                String st = (string)dataSet.ExtendedProperties["HeaderCells"];
                String[] HCells = st.Trim().Split(' ');
                for (int i = 0; i < data.Columns.Count - 1; i++)
                {
                    int index = TableConditions.Columns.Count;
                    TableConditions.Columns.Add(index.ToString(), "q" + index.ToString());
                }

                for (int i = 0; i < HCells.Length; i++)
                {
                    TableConditions.Rows.Add();
                }

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
        }

        private void GraphicOneLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            //isStop = true;
            //Thread t = new Thread(ShowMessage);
            //thread.Join();
            //t.Abort();
        }

        private void ShowMessage()
        {
            MessageBox.Show("Окно может закрыться не сразу, так как остановить работу машины Тьюринга невозможно.\nПожалуйста, дождитесь завершения работы.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (task.Status != TaskStatus.Running)
                task.Start();
        }

        private void CloseForm()
        {
            Thread.Sleep(200);
            this.Close();
        }

        private void GetData()
        {
            try
            {
                for (int level = 0; ; level++)
                {
                    PermutationsWithRepetition gen = new PermutationsWithRepetition(
                            Alphabet.Trim().ToCharArray(), level);
                    String[] variations = gen.getVariations();
                    List<String[]> haveToDo = WorkWithArrays.Split(variations, (int)(ThreadsCount * 1.5));
                    List<int> temp = new List<int>();
                    while (haveToDo.Count != 0)
                    {
                        try
                        {
                            Thread[] threads = new Thread[haveToDo[0].Length];
                            for (int i = 0; i < haveToDo[0].Length; i++)
                            {
                                threads[i] = new Thread(new ParameterizedThreadStart(DoTask));
                                threads[i].Name = i.ToString();
                                threads[i].Start(haveToDo.First()[i]);
                            }
                            haveToDo.RemoveAt(0);
                            foreach (Thread thread in threads)
                                thread.Join();
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.Message);
                        }
                    }
                    //Update(max);

                    
                    //List<String[]> haveToDo = WorkWithArrays.Split(variations, 10);

                    //IAsyncResult asyncResult;
                    //int max = 0;
                    //while (haveToDo.Count != 0)
                    //{
                    //    if (isStop)
                    //    {
                    //        break;
                    //    }
                    //    if (isPause)
                    //    {
                    //        mre.WaitOne();
                    //        continue;
                    //    }
                        
                    //    int[] temp = new int[haveToDo.First().Count()];

                    //    Thread[] WorkingThreads = new Thread[temp.Length];
                    //    for (int i = 0; i < temp.Length; i++)
                    //    {
                    //        try
                    //        {
                    //            WorkingThreads[i] = new Thread()
                    //            WorkingThreads[i].Start((haveToDo.First()[i]));
                    //            temp[i] = DoTask(haveToDo.First()[i]);
                    //        }
                    //        catch (Exception exc)
                    //        {
                    //            MessageBox.Show(exc.Message);
                    //        }
                    //    }

                    //    Parallel.For(0, temp.Length, i =>
                    //    {
                    //        try
                    //        {
                    //            temp[i] = DoTask(haveToDo.First()[i]);
                    //        }
                    //        catch (Exception exc)
                    //        {
                    //            MessageBox.Show(exc.Message);
                    //        }
                    //    });
                    //    haveToDo.RemoveAt(0);
                    //    int max_from_iterations = WorkWithArrays.GetMaxFormArray(temp);
                    //    max = max > max_from_iterations ? max : max_from_iterations;
                    //}
                    //if (isStop)
                    //{
                    //    break;
                    //}
                    //if (isPause)
                    //{
                    //    mre.WaitOne();
                    //    continue;
                    //}
                    //BeginInvoke(new DelegateUpdate(Update), max);
                }
            }
            catch (Exception e)
            {
                //isStopped = true;
                return;
            }
        }

        public void DoTask(object str)
        {
            String line = (String)str;
            foreach (DataGridViewRow Row in TableConditions.Rows)
                foreach (DataGridViewCell Cell in Row.Cells)
                    if (Cell.Value == null)
                        Cell.Value = "";

            TuringMachine turingMachine = new TuringMachine(ref TableConditions, line);

            int counter = 0;
            while (true)
            {
                try
                {
                    while (isPause)
                        Thread.Sleep(1);
                    turingMachine.NextStep();
                    counter++;
                }
                catch (Exception except)
                {
                    if (turingMachine.CurrentCondition == -1)
                        break;
                    else
                        throw new Exception($"Ошибка команд\n{line}\nСостояние : {turingMachine.CurrentCondition}\nСчетчик: {counter}");
                }
            }
            BeginInvoke(new DelegateUpdate2(Update), counter, line.Length);
        }

        private void Update(int num)
        {
            label1.Text = String.Join(" ", allResults);
            label1.Text += " " + num.ToString();
            allResults.Add(num);
        }

        private void Update(int num, int level)
        {
            if (allResults.Count <= level)
            {
                allResults.Add(num);
            }
            else
            {
                int max = allResults[level];
                allResults[level] = max > num ? max : num;
            }
            
            label1.Text = String.Join(" ", allResults);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isPause = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isPause = false;
            mre.Set();
        }

        public bool GetIsPause()
        {
            return isPause;
        }

        public bool GetIsStop()
        {
            return isStop;
        }
    }
}
