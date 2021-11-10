using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turing.Library;
using Turing.Machines.OneLineTuringMachine;

namespace Turing.Machines.ViewGraphic.OneLine
{
    public delegate int DelegateThreading(String str);
    public partial class GraphicOneLine : Form
    {
        readonly int ThreadsCount = Environment.ProcessorCount;
        public bool isPause = false;
        public bool isStop = false;

        public delegate void DelegateUpdate2(int num, int level);

        readonly String Alphabet;
        DataGridView TableConditions;
        List<int> allResults;
        Task task;

        public GraphicOneLine()
        {
            InitializeComponent();
            Alphabet = "abc";
            TableConditions = new DataGridView();
            allResults = new List<int>();
            this.chart1.Series[0].Points.Clear();
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
            isStop = true;
            isPause = false;

            while (!task.IsCompleted)
                Thread.Sleep(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (task == null)
                task = Task.Factory.StartNew(new Action(() => GetData()), TaskCreationOptions.LongRunning);
        }

        private void GetData()
        {
            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
            for (int level = 0; ; level++)
            {
                //Нужно тут же описать функцию, чтобы проверять, нужно ли паузить/закрывать
                PermutationsWithRepetition gen = new PermutationsWithRepetition(
                        Alphabet.Trim().ToCharArray(), level);
                String[] variations = gen.getVariations();
                if (isStop)
                    break;
                List<String[]> haveToDo = WorkWithArrays.Split(variations, ThreadsCount * 2);
                if (isStop)
                    break;
                variations = null;
                GC.Collect(GC.MaxGeneration);
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
                            threads[i].Priority = ThreadPriority.Highest;
                            threads[i].Start(haveToDo.First()[i]);
                        }
                        haveToDo.RemoveAt(0);
                        foreach (Thread thread in threads)
                            thread.Join();
                        if (isStop)
                            break;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            Thread.CurrentThread.Priority = ThreadPriority.Normal;
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
                    if (isStop)
                        return;
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

        private void Update(int num, int level)
        {
            if (allResults.Count <= level)
            {
                allResults.Add(num);
                chart1.Series[0].Points.AddXY(level, num);
            }
            else
            {
                int max = allResults[level];

                if (max >= num)
                {
                    return;
                }
                else
                {
                    allResults[level] = num;
                    if (chart1.Series[0].Points.Count != 0)
                        chart1.Series[0].Points.RemoveAt(chart1.Series[0].Points.Count - 1);
                    chart1.Series[0].Points.AddXY(level, num);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isPause = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isPause = false;
        }
    }
}
