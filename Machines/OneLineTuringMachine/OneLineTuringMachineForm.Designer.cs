
namespace Turing.Machines.OneLineTuringMachine
{
    partial class OneLineTuringMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qweqweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одноленточнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двухленточнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьВыполненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медленноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстрееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оченьБыстроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мгновенноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonToLeft = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonToRight = new System.Windows.Forms.Button();
            this.CurrentCondition = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableConditions = new System.Windows.Forms.DataGridView();
            this.Alphabet = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.AddColumn = new System.Windows.Forms.Button();
            this.DeleteColumn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DoAllSteps_Button = new System.Windows.Forms.Button();
            this.MakeStep_Button = new System.Windows.Forms.Button();
            this.Return_Button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.StopWork_Button = new System.Windows.Forms.Button();
            this.SaveMachine_Button = new System.Windows.Forms.Button();
            this.OpenMachine_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableConditions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qweqweToolStripMenuItem,
            this.скоростьВыполненияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qweqweToolStripMenuItem
            // 
            this.qweqweToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одноленточнаяToolStripMenuItem,
            this.двухленточнаяToolStripMenuItem});
            this.qweqweToolStripMenuItem.Name = "qweqweToolStripMenuItem";
            this.qweqweToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.qweqweToolStripMenuItem.Text = "Машина Тьюринга";
            // 
            // одноленточнаяToolStripMenuItem
            // 
            this.одноленточнаяToolStripMenuItem.Name = "одноленточнаяToolStripMenuItem";
            this.одноленточнаяToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.одноленточнаяToolStripMenuItem.Text = "Одноленточная";
            this.одноленточнаяToolStripMenuItem.Click += new System.EventHandler(this.одноленточнаяToolStripMenuItem_Click);
            // 
            // двухленточнаяToolStripMenuItem
            // 
            this.двухленточнаяToolStripMenuItem.Name = "двухленточнаяToolStripMenuItem";
            this.двухленточнаяToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.двухленточнаяToolStripMenuItem.Text = "Двухленточная";
            // 
            // скоростьВыполненияToolStripMenuItem
            // 
            this.скоростьВыполненияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.медленноToolStripMenuItem,
            this.среднеToolStripMenuItem,
            this.быстрееToolStripMenuItem,
            this.быстроToolStripMenuItem,
            this.оченьБыстроToolStripMenuItem,
            this.мгновенноToolStripMenuItem});
            this.скоростьВыполненияToolStripMenuItem.Name = "скоростьВыполненияToolStripMenuItem";
            this.скоростьВыполненияToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.скоростьВыполненияToolStripMenuItem.Text = "Скорость выполнения";
            // 
            // медленноToolStripMenuItem
            // 
            this.медленноToolStripMenuItem.Name = "медленноToolStripMenuItem";
            this.медленноToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.медленноToolStripMenuItem.Text = "Медленно";
            this.медленноToolStripMenuItem.Click += new System.EventHandler(this.OnTimerSpeedClick);
            // 
            // среднеToolStripMenuItem
            // 
            this.среднеToolStripMenuItem.Name = "среднеToolStripMenuItem";
            this.среднеToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.среднеToolStripMenuItem.Text = "Средне";
            this.среднеToolStripMenuItem.Click += new System.EventHandler(this.OnTimerSpeedClick);
            // 
            // быстрееToolStripMenuItem
            // 
            this.быстрееToolStripMenuItem.Name = "быстрееToolStripMenuItem";
            this.быстрееToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.быстрееToolStripMenuItem.Text = "Быстрее";
            this.быстрееToolStripMenuItem.Click += new System.EventHandler(this.OnTimerSpeedClick);
            // 
            // быстроToolStripMenuItem
            // 
            this.быстроToolStripMenuItem.Name = "быстроToolStripMenuItem";
            this.быстроToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.быстроToolStripMenuItem.Text = "Быстро";
            this.быстроToolStripMenuItem.Click += new System.EventHandler(this.OnTimerSpeedClick);
            // 
            // оченьБыстроToolStripMenuItem
            // 
            this.оченьБыстроToolStripMenuItem.Name = "оченьБыстроToolStripMenuItem";
            this.оченьБыстроToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.оченьБыстроToolStripMenuItem.Text = "Очень Быстро";
            this.оченьБыстроToolStripMenuItem.Click += new System.EventHandler(this.OnTimerSpeedClick);
            // 
            // мгновенноToolStripMenuItem
            // 
            this.мгновенноToolStripMenuItem.Name = "мгновенноToolStripMenuItem";
            this.мгновенноToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.мгновенноToolStripMenuItem.Text = "Мгновенно";
            this.мгновенноToolStripMenuItem.Click += new System.EventHandler(this.OnTimerSpeedClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonToLeft);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonToRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 46);
            this.panel1.TabIndex = 1;
            // 
            // ButtonToLeft
            // 
            this.ButtonToLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonToLeft.Location = new System.Drawing.Point(771, 0);
            this.ButtonToLeft.Name = "ButtonToLeft";
            this.ButtonToLeft.Size = new System.Drawing.Size(21, 46);
            this.ButtonToLeft.TabIndex = 30;
            this.ButtonToLeft.Text = ">";
            this.ButtonToLeft.UseVisualStyleBackColor = true;
            this.ButtonToLeft.Click += new System.EventHandler(this.ButtonToLeft_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label15.Location = new System.Drawing.Point(721, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 46);
            this.label15.TabIndex = 29;
            this.label15.Text = "A";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label14.Location = new System.Drawing.Point(671, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 46);
            this.label14.TabIndex = 28;
            this.label14.Text = "A";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label13.Location = new System.Drawing.Point(621, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 46);
            this.label13.TabIndex = 27;
            this.label13.Text = "A";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label12.Location = new System.Drawing.Point(571, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 46);
            this.label12.TabIndex = 26;
            this.label12.Text = "A";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label11.Location = new System.Drawing.Point(521, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 46);
            this.label11.TabIndex = 25;
            this.label11.Text = "A";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label10.Location = new System.Drawing.Point(471, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 46);
            this.label10.TabIndex = 24;
            this.label10.Text = "A";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label9.Location = new System.Drawing.Point(421, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 46);
            this.label9.TabIndex = 23;
            this.label9.Text = "A";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label8.Location = new System.Drawing.Point(371, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 46);
            this.label8.TabIndex = 22;
            this.label8.Text = "A";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.Location = new System.Drawing.Point(321, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 46);
            this.label7.TabIndex = 21;
            this.label7.Text = "A";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label6.Location = new System.Drawing.Point(271, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 46);
            this.label6.TabIndex = 20;
            this.label6.Text = "A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label5.Location = new System.Drawing.Point(221, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 46);
            this.label5.TabIndex = 19;
            this.label5.Text = "A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label4.Location = new System.Drawing.Point(171, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 46);
            this.label4.TabIndex = 18;
            this.label4.Text = "A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(121, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 46);
            this.label3.TabIndex = 17;
            this.label3.Text = "A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(71, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 46);
            this.label2.TabIndex = 16;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // ButtonToRight
            // 
            this.ButtonToRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonToRight.Location = new System.Drawing.Point(0, 0);
            this.ButtonToRight.Name = "ButtonToRight";
            this.ButtonToRight.Size = new System.Drawing.Size(21, 46);
            this.ButtonToRight.TabIndex = 0;
            this.ButtonToRight.Text = "<";
            this.ButtonToRight.UseVisualStyleBackColor = true;
            this.ButtonToRight.Click += new System.EventHandler(this.ButtonToRight_Click);
            // 
            // CurrentCondition
            // 
            this.CurrentCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CurrentCondition.Location = new System.Drawing.Point(371, 73);
            this.CurrentCondition.Name = "CurrentCondition";
            this.CurrentCondition.Size = new System.Drawing.Size(50, 45);
            this.CurrentCondition.TabIndex = 2;
            this.CurrentCondition.Text = "q0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TableConditions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 272);
            this.panel2.TabIndex = 3;
            // 
            // TableConditions
            // 
            this.TableConditions.AllowUserToAddRows = false;
            this.TableConditions.AllowUserToDeleteRows = false;
            this.TableConditions.AllowUserToResizeColumns = false;
            this.TableConditions.AllowUserToResizeRows = false;
            this.TableConditions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableConditions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableConditions.GridColor = System.Drawing.SystemColors.Control;
            this.TableConditions.Location = new System.Drawing.Point(0, 0);
            this.TableConditions.MultiSelect = false;
            this.TableConditions.Name = "TableConditions";
            this.TableConditions.Size = new System.Drawing.Size(792, 272);
            this.TableConditions.TabIndex = 0;
            this.TableConditions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableConditions_CellEndEdit);
            this.TableConditions.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TableConditions_ColumnAdded);
            this.TableConditions.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TableConditions_ColumnAdded);
            // 
            // Alphabet
            // 
            this.Alphabet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Alphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alphabet.Location = new System.Drawing.Point(0, 147);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Size = new System.Drawing.Size(792, 31);
            this.Alphabet.TabIndex = 4;
            this.Alphabet.TextChanged += new System.EventHandler(this.Alphabet_TextChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label16.Location = new System.Drawing.Point(12, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 5;
            this.label16.Text = "Алфавит";
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(457, 121);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(127, 23);
            this.AddColumn.TabIndex = 6;
            this.AddColumn.Text = "Добавить столбец";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Location = new System.Drawing.Point(596, 121);
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Size = new System.Drawing.Size(111, 23);
            this.DeleteColumn.TabIndex = 7;
            this.DeleteColumn.Text = "Удалить столбец";
            this.DeleteColumn.UseVisualStyleBackColor = true;
            this.DeleteColumn.Click += new System.EventHandler(this.DeleteColumntButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(713, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // DoAllSteps_Button
            // 
            this.DoAllSteps_Button.Location = new System.Drawing.Point(12, 95);
            this.DoAllSteps_Button.Name = "DoAllSteps_Button";
            this.DoAllSteps_Button.Size = new System.Drawing.Size(109, 23);
            this.DoAllSteps_Button.TabIndex = 9;
            this.DoAllSteps_Button.Text = "Выполнить";
            this.DoAllSteps_Button.UseVisualStyleBackColor = true;
            this.DoAllSteps_Button.Click += new System.EventHandler(this.DoAllSteps_Button_Click);
            // 
            // MakeStep_Button
            // 
            this.MakeStep_Button.Location = new System.Drawing.Point(136, 121);
            this.MakeStep_Button.Name = "MakeStep_Button";
            this.MakeStep_Button.Size = new System.Drawing.Size(111, 23);
            this.MakeStep_Button.TabIndex = 10;
            this.MakeStep_Button.Text = "Шаг";
            this.MakeStep_Button.UseVisualStyleBackColor = true;
            this.MakeStep_Button.Click += new System.EventHandler(this.MakeStepButton_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.Location = new System.Drawing.Point(713, 83);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(75, 23);
            this.Return_Button.TabIndex = 11;
            this.Return_Button.Text = "Заново";
            this.Return_Button.UseVisualStyleBackColor = true;
            this.Return_Button.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(631, 83);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 12;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            // 
            // StopWork_Button
            // 
            this.StopWork_Button.Enabled = false;
            this.StopWork_Button.Location = new System.Drawing.Point(136, 95);
            this.StopWork_Button.Name = "StopWork_Button";
            this.StopWork_Button.Size = new System.Drawing.Size(111, 23);
            this.StopWork_Button.TabIndex = 13;
            this.StopWork_Button.Text = "Стоп";
            this.StopWork_Button.UseVisualStyleBackColor = true;
            this.StopWork_Button.Click += new System.EventHandler(this.StopWork_Button_Click);
            // 
            // SaveMachine_Button
            // 
            this.SaveMachine_Button.Location = new System.Drawing.Point(377, 121);
            this.SaveMachine_Button.Name = "SaveMachine_Button";
            this.SaveMachine_Button.Size = new System.Drawing.Size(75, 23);
            this.SaveMachine_Button.TabIndex = 14;
            this.SaveMachine_Button.Text = "Экспорт";
            this.SaveMachine_Button.UseVisualStyleBackColor = true;
            this.SaveMachine_Button.Click += new System.EventHandler(this.SaveMachine_Button_Click);
            // 
            // OpenMachine_Button
            // 
            this.OpenMachine_Button.Location = new System.Drawing.Point(296, 121);
            this.OpenMachine_Button.Name = "OpenMachine_Button";
            this.OpenMachine_Button.Size = new System.Drawing.Size(75, 23);
            this.OpenMachine_Button.TabIndex = 15;
            this.OpenMachine_Button.Text = "Импорт";
            this.OpenMachine_Button.UseVisualStyleBackColor = true;
            this.OpenMachine_Button.Click += new System.EventHandler(this.OpenMachine_Button_Click);
            // 
            // OneLineTuringMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.OpenMachine_Button);
            this.Controls.Add(this.SaveMachine_Button);
            this.Controls.Add(this.StopWork_Button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.MakeStep_Button);
            this.Controls.Add(this.DoAllSteps_Button);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.DeleteColumn);
            this.Controls.Add(this.AddColumn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Alphabet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CurrentCondition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(808, 489);
            this.MinimumSize = new System.Drawing.Size(808, 489);
            this.Name = "OneLineTuringMachineForm";
            this.Text = "OneLineTuringMachineForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableConditions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qweqweToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem одноленточнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двухленточнаяToolStripMenuItem;
        private System.Windows.Forms.Label CurrentCondition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Alphabet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button ButtonToRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonToLeft;
        private System.Windows.Forms.DataGridView TableConditions;
        private System.Windows.Forms.Button AddColumn;
        private System.Windows.Forms.Button DeleteColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button DoAllSteps_Button;
        private System.Windows.Forms.Button MakeStep_Button;
        private System.Windows.Forms.Button Return_Button;
        private System.Windows.Forms.ToolStripMenuItem скоростьВыполненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медленноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem быстрееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem быстроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оченьБыстроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мгновенноToolStripMenuItem;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button StopWork_Button;
        private System.Windows.Forms.Button SaveMachine_Button;
        private System.Windows.Forms.Button OpenMachine_Button;
    }
}