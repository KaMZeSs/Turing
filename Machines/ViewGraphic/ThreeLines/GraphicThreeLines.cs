using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turing.Library;
using Turing.Machines.ThreeLinesTuringMachine;

namespace Turing.Machines.ViewGraphic.ThreeLines
{
    public partial class GraphicThreeLines : Form
    {
        readonly int ThreadsCount = Environment.ProcessorCount;
        public bool isPause = false;
        public bool isStop = false;
        public bool isWriteListing;

        public delegate void DelegateUpdate2(int num, int level);

        readonly String Alphabet;
        DataGridView TableConditions;
        List<int> allResults;
        Task task;

        public GraphicThreeLines()
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

                if (HCells[0].Length != 3)
                    return;

                for (int i = 0; i < data.Columns.Count; i++)
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

                foreach (DataGridViewRow Row in TableConditions.Rows)
                    foreach (DataGridViewCell Cell in Row.Cells)
                        if (Cell.Value == null)
                            Cell.Value = "";
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
            {
                DialogResult result = MessageBox.Show("Записывать ли информацию обо всех шагах машин Тьюринга?",
                    "Записывать ли?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.OK || result == DialogResult.Yes)
                {
                    isWriteListing = true;
                }
                else if (result == DialogResult.No)
                {
                    isWriteListing = false;
                }
                else
                    return;
                task = Task.Factory.StartNew(new Action(() => GetData()), TaskCreationOptions.LongRunning);
            }
        }

        private void GetData()
        {
            if (isWriteListing)
            {
                if (Directory.Exists("Listing_ThreeLines"))
                {
                    Directory.Delete("Listing_ThreeLines", true);
                }
                Directory.CreateDirectory("Listing_ThreeLines");
            }

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
                    Thread[] threads = new Thread[ThreadsCount * 2];

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

            StreamWriter streamWriter = null;
            if (isWriteListing)
            {
                Directory.CreateDirectory($"Listing_ThreeLines/{line.Length}");
                streamWriter = File.AppendText($"Listing_ThreeLines/{line.Length}/{line}.txt");
            }

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

                    if (isWriteListing)
                    {
                        String[] listing = new String[3];
                        listing[0] = "λ" + turingMachine.Line_First.GetKAtLine() + "λ";
                        listing[1] = "λ" + turingMachine.Line_Second.GetKAtLine() + "λ";
                        listing[2] = "λ" + turingMachine.Line_Third.GetKAtLine() + "λ";

                        if (listing[0].Length == 2)
                            listing[0] = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ";
                        else
                        {
                            int pos = turingMachine.CurrentPos_First - turingMachine.Line_First.IndexOf(listing[0][1]) + 1;
                            if (turingMachine.CurrentCondition == -1)
                                listing[0] = listing[0].Insert(pos < 0 ? 0 : pos, "qz");
                            else
                                listing[0] = listing[0].Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                        }

                        if (listing[1].Length == 2)
                            listing[1] = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ";
                        else
                        {
                            int pos = turingMachine.CurrentPos_Second - turingMachine.Line_Second.IndexOf(listing[1][1]) + 1;
                            if (turingMachine.CurrentCondition == -1)
                                listing[1] = listing[1].Insert(pos < 0 ? 0 : pos, "qz");
                            else
                                listing[1] = listing[1].Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                        }

                        if (listing[2].Length == 2)
                            listing[2] = "λ" + "q" + turingMachine.CurrentCondition.ToString() + "λ";
                        else
                        {
                            int pos = turingMachine.CurrentPos_Third - turingMachine.Line_Third.IndexOf(listing[2][1]) + 1;
                            if (turingMachine.CurrentCondition == -1)
                                listing[2] = listing[2].Insert(pos < 0 ? 0 : pos, "qz");
                            else
                                listing[2] = listing[2].Insert(pos < 0 ? 0 : pos, "q" + turingMachine.CurrentCondition.ToString());
                        }

                        for (int i = 0; i < listing.Length; i++)
                            if (listing[i].Contains("q-1"))
                                listing[i] = listing[i].Replace("q-1", "qz");

                        streamWriter.WriteLine(String.Join("\n", listing));
                        streamWriter.WriteLine();
                    }

                    turingMachine.NextStep();

                    counter++;
                }
#pragma warning disable CS0168 // Переменная "except" объявлена, но ни разу не использована.
                catch (Exception except)
#pragma warning restore CS0168 // Переменная "except" объявлена, но ни разу не использована.
                {
                    if (turingMachine.CurrentCondition == -1)
                        break;
                    else
                    {
                        if (isWriteListing)
                            streamWriter.Close();
                        MessageBox.Show($"Ошибка команд\n{line}\nСостояние : {turingMachine.CurrentCondition}\nСчетчик: {counter}");
                        break;
                    }
                }
            }
            if (isWriteListing)
                streamWriter.Close();
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
