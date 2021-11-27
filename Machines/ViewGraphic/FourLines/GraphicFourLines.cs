using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turing.Library;
using Turing.Machines.FourLinesTuringMachine;

namespace Turing.Machines.ViewGraphic.FourLines
{
    public partial class GraphicFourLines : Form
    {
        readonly int ThreadsCount = Environment.ProcessorCount;
        public bool isPause = false;
        public bool isStop = false;

        public delegate void DelegateUpdate2(int num, int level);

        readonly String Alphabet;
        DataGridView TableConditions;
        List<int> allResults;
        Task task;

        public GraphicFourLines()
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
            else
            {
                this.Close();
            }
        }

        private void GraphicOneLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (task != null)
            {
                isStop = true;
                isPause = false;

                while (!task.IsCompleted)
                    Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (task == null)
                task = Task.Factory.StartNew(new Action(() => GetData()), TaskCreationOptions.LongRunning);
        }

        private void GetData()
        {
            Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
            Repetition repetition = new Repetition(Alphabet.ToCharArray());

            DoTask("");
            DoTask("a");

            while (true)
            {
                if (isStop)
                    break;
                while (isPause)
                    Thread.Sleep(500);
                try
                {
                    Thread[] threads = new Thread[ThreadsCount * 3];

                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i] = new Thread(new ParameterizedThreadStart(DoTask));
                        threads[i].Name = i.ToString();
                        threads[i].Priority = ThreadPriority.AboveNormal;
                        String str = new String(repetition.nextStep());
                        if (str.Contains('\0'))
                            MessageBox.Show(str);
                        threads[i].Start(str);
                    }

                    foreach (Thread thread in threads)
                        thread.Join();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
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
                        Thread.Sleep(500);
                    if (isStop)
                        return;
                    turingMachine.NextStep();
                    
                    counter++;
                }
                catch (Exception except)
                {
                    if (except.Message.Equals("Индекс за пределами диапазона. Индекс должен быть положительным числом, а его размер не должен превышать размер коллекции.\r\nИмя параметра: index"))
                    {
                        counter++;
                        break;
                    }
                    else
                    {
                        if (turingMachine.CurrentCondition == -1)
                            break;
                        else
                        {
                            MessageBox.Show($"Ошибка команд\n{line}\nСостояние : {turingMachine.CurrentCondition}\nСчетчик: {counter}");
                            break;
                        }
                    }
                    
                }
            }
            
            BeginInvoke(new DelegateUpdate2(Update), counter, line.Length);
        }

        private void Update(int num, int level)
        {
            while (allResults.Count <= level)
                allResults.Add(0);

            int max = allResults[level];

            if (max < num)
            {
                allResults[level] = num;
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < allResults.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(i, allResults[i]);
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
