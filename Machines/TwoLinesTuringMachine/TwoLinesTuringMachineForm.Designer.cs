
namespace Turing.Machines.TwoLinesTuringMachine
{
    partial class TwoLinesTuringMachineForm
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
            this.скоростьВыполненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медленноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстрееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.быстроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оченьБыстроToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мгновенноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonToLeftFirst = new System.Windows.Forms.Button();
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
            this.ButtonToRightFirst = new System.Windows.Forms.Button();
            this.CurrentCondition = new System.Windows.Forms.Label();
            this.ButtonToLeftSecond = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.ButtonToRightSecond = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.TableConditions = new System.Windows.Forms.DataGridView();
            this.Alphabet = new System.Windows.Forms.TextBox();
            this.OpenMachine_Button = new System.Windows.Forms.Button();
            this.SaveMachine_Button = new System.Windows.Forms.Button();
            this.StopWork_Button = new System.Windows.Forms.Button();
            this.Clear_button = new System.Windows.Forms.Button();
            this.MakeStep_Button = new System.Windows.Forms.Button();
            this.DoAllSteps_Button = new System.Windows.Forms.Button();
            this.DeleteColumn = new System.Windows.Forms.Button();
            this.AddColumn = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
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
            this.скоростьВыполненияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.panel1.Controls.Add(this.ButtonToLeftFirst);
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
            this.panel1.Controls.Add(this.ButtonToRightFirst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 50);
            this.panel1.TabIndex = 2;
            // 
            // ButtonToLeftFirst
            // 
            this.ButtonToLeftFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonToLeftFirst.Location = new System.Drawing.Point(771, 0);
            this.ButtonToLeftFirst.Name = "ButtonToLeftFirst";
            this.ButtonToLeftFirst.Size = new System.Drawing.Size(21, 50);
            this.ButtonToLeftFirst.TabIndex = 47;
            this.ButtonToLeftFirst.Text = ">";
            this.ButtonToLeftFirst.UseVisualStyleBackColor = true;
            this.ButtonToLeftFirst.Click += new System.EventHandler(this.ButtonToLeft_Click);
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label15.Location = new System.Drawing.Point(721, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 50);
            this.label15.TabIndex = 46;
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
            this.label14.Size = new System.Drawing.Size(50, 50);
            this.label14.TabIndex = 45;
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
            this.label13.Size = new System.Drawing.Size(50, 50);
            this.label13.TabIndex = 44;
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
            this.label12.Size = new System.Drawing.Size(50, 50);
            this.label12.TabIndex = 43;
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
            this.label11.Size = new System.Drawing.Size(50, 50);
            this.label11.TabIndex = 42;
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
            this.label10.Size = new System.Drawing.Size(50, 50);
            this.label10.TabIndex = 41;
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
            this.label9.Size = new System.Drawing.Size(50, 50);
            this.label9.TabIndex = 40;
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
            this.label8.Size = new System.Drawing.Size(50, 50);
            this.label8.TabIndex = 39;
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
            this.label7.Size = new System.Drawing.Size(50, 50);
            this.label7.TabIndex = 38;
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
            this.label6.Size = new System.Drawing.Size(50, 50);
            this.label6.TabIndex = 37;
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
            this.label5.Size = new System.Drawing.Size(50, 50);
            this.label5.TabIndex = 36;
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
            this.label4.Size = new System.Drawing.Size(50, 50);
            this.label4.TabIndex = 35;
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
            this.label3.Size = new System.Drawing.Size(50, 50);
            this.label3.TabIndex = 34;
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
            this.label2.Size = new System.Drawing.Size(50, 50);
            this.label2.TabIndex = 33;
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
            this.label1.Size = new System.Drawing.Size(50, 50);
            this.label1.TabIndex = 32;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // ButtonToRightFirst
            // 
            this.ButtonToRightFirst.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonToRightFirst.Location = new System.Drawing.Point(0, 0);
            this.ButtonToRightFirst.Name = "ButtonToRightFirst";
            this.ButtonToRightFirst.Size = new System.Drawing.Size(21, 50);
            this.ButtonToRightFirst.TabIndex = 31;
            this.ButtonToRightFirst.Text = "<";
            this.ButtonToRightFirst.UseVisualStyleBackColor = true;
            this.ButtonToRightFirst.Click += new System.EventHandler(this.ButtonToRight_Click);
            // 
            // CurrentCondition
            // 
            this.CurrentCondition.AutoSize = true;
            this.CurrentCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.CurrentCondition.Location = new System.Drawing.Point(371, 130);
            this.CurrentCondition.Name = "CurrentCondition";
            this.CurrentCondition.Size = new System.Drawing.Size(44, 31);
            this.CurrentCondition.TabIndex = 5;
            this.CurrentCondition.Text = "q0";
            // 
            // ButtonToLeftSecond
            // 
            this.ButtonToLeftSecond.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonToLeftSecond.Location = new System.Drawing.Point(771, 0);
            this.ButtonToLeftSecond.Name = "ButtonToLeftSecond";
            this.ButtonToLeftSecond.Size = new System.Drawing.Size(21, 50);
            this.ButtonToLeftSecond.TabIndex = 47;
            this.ButtonToLeftSecond.Text = ">";
            this.ButtonToLeftSecond.UseVisualStyleBackColor = true;
            this.ButtonToLeftSecond.Click += new System.EventHandler(this.ButtonToLeft_Click);
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label17.Location = new System.Drawing.Point(721, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 50);
            this.label17.TabIndex = 46;
            this.label17.Text = "A";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label17.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label18.Location = new System.Drawing.Point(671, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 50);
            this.label18.TabIndex = 45;
            this.label18.Text = "A";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label18.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label19.Location = new System.Drawing.Point(621, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 50);
            this.label19.TabIndex = 44;
            this.label19.Text = "A";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label19.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label20.Location = new System.Drawing.Point(571, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 50);
            this.label20.TabIndex = 43;
            this.label20.Text = "A";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label21.Location = new System.Drawing.Point(521, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 50);
            this.label21.TabIndex = 42;
            this.label21.Text = "A";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Dock = System.Windows.Forms.DockStyle.Left;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label22.Location = new System.Drawing.Point(471, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 50);
            this.label22.TabIndex = 41;
            this.label22.Text = "A";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Dock = System.Windows.Forms.DockStyle.Left;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label23.Location = new System.Drawing.Point(421, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 50);
            this.label23.TabIndex = 40;
            this.label23.Text = "A";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label23.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label24
            // 
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label24.Dock = System.Windows.Forms.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label24.Location = new System.Drawing.Point(371, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 50);
            this.label24.TabIndex = 39;
            this.label24.Text = "A";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Dock = System.Windows.Forms.DockStyle.Left;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label25.Location = new System.Drawing.Point(321, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 50);
            this.label25.TabIndex = 38;
            this.label25.Text = "A";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label25.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label26
            // 
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label26.Dock = System.Windows.Forms.DockStyle.Left;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label26.Location = new System.Drawing.Point(271, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(50, 50);
            this.label26.TabIndex = 37;
            this.label26.Text = "A";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label26.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label27
            // 
            this.label27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label27.Dock = System.Windows.Forms.DockStyle.Left;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label27.Location = new System.Drawing.Point(221, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 50);
            this.label27.TabIndex = 36;
            this.label27.Text = "A";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label27.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label28
            // 
            this.label28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label28.Dock = System.Windows.Forms.DockStyle.Left;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label28.Location = new System.Drawing.Point(171, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 50);
            this.label28.TabIndex = 35;
            this.label28.Text = "A";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label28.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label29
            // 
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label29.Dock = System.Windows.Forms.DockStyle.Left;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label29.Location = new System.Drawing.Point(121, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 50);
            this.label29.TabIndex = 34;
            this.label29.Text = "A";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label29.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label30
            // 
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label30.Dock = System.Windows.Forms.DockStyle.Left;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label30.Location = new System.Drawing.Point(71, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 50);
            this.label30.TabIndex = 33;
            this.label30.Text = "A";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label30.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // label31
            // 
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label31.Dock = System.Windows.Forms.DockStyle.Left;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label31.Location = new System.Drawing.Point(21, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(50, 50);
            this.label31.TabIndex = 32;
            this.label31.Text = "A";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label31.DoubleClick += new System.EventHandler(this.OnLabelClick);
            // 
            // ButtonToRightSecond
            // 
            this.ButtonToRightSecond.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonToRightSecond.Location = new System.Drawing.Point(0, 0);
            this.ButtonToRightSecond.Name = "ButtonToRightSecond";
            this.ButtonToRightSecond.Size = new System.Drawing.Size(21, 50);
            this.ButtonToRightSecond.TabIndex = 31;
            this.ButtonToRightSecond.Text = "<";
            this.ButtonToRightSecond.UseVisualStyleBackColor = true;
            this.ButtonToRightSecond.Click += new System.EventHandler(this.ButtonToRight_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ButtonToLeftSecond);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.ButtonToRightSecond);
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 4;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label32.Location = new System.Drawing.Point(12, 212);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 23);
            this.label32.TabIndex = 6;
            this.label32.Text = "Алфавит";
            // 
            // TableConditions
            // 
            this.TableConditions.AllowUserToAddRows = false;
            this.TableConditions.AllowUserToDeleteRows = false;
            this.TableConditions.AllowUserToResizeColumns = false;
            this.TableConditions.AllowUserToResizeRows = false;
            this.TableConditions.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableConditions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TableConditions.GridColor = System.Drawing.SystemColors.Control;
            this.TableConditions.Location = new System.Drawing.Point(0, 269);
            this.TableConditions.MultiSelect = false;
            this.TableConditions.Name = "TableConditions";
            this.TableConditions.Size = new System.Drawing.Size(791, 272);
            this.TableConditions.TabIndex = 7;
            this.TableConditions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableConditions_CellEndEdit);
            this.TableConditions.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TableConditions_ColumnAdded);
            this.TableConditions.ColumnRemoved += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TableConditions_ColumnAdded);
            // 
            // Alphabet
            // 
            this.Alphabet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Alphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alphabet.Location = new System.Drawing.Point(0, 238);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Size = new System.Drawing.Size(791, 31);
            this.Alphabet.TabIndex = 8;
            this.Alphabet.TextChanged += new System.EventHandler(this.Alphabet_TextChanged);
            // 
            // OpenMachine_Button
            // 
            this.OpenMachine_Button.Location = new System.Drawing.Point(292, 210);
            this.OpenMachine_Button.Name = "OpenMachine_Button";
            this.OpenMachine_Button.Size = new System.Drawing.Size(75, 23);
            this.OpenMachine_Button.TabIndex = 24;
            this.OpenMachine_Button.Text = "Импорт";
            this.OpenMachine_Button.UseVisualStyleBackColor = true;
            this.OpenMachine_Button.Click += new System.EventHandler(this.OpenMachine_Button_Click);
            // 
            // SaveMachine_Button
            // 
            this.SaveMachine_Button.Location = new System.Drawing.Point(373, 210);
            this.SaveMachine_Button.Name = "SaveMachine_Button";
            this.SaveMachine_Button.Size = new System.Drawing.Size(75, 23);
            this.SaveMachine_Button.TabIndex = 23;
            this.SaveMachine_Button.Text = "Экспорт";
            this.SaveMachine_Button.UseVisualStyleBackColor = true;
            this.SaveMachine_Button.Click += new System.EventHandler(this.SaveMachine_Button_Click);
            // 
            // StopWork_Button
            // 
            this.StopWork_Button.Enabled = false;
            this.StopWork_Button.Location = new System.Drawing.Point(132, 184);
            this.StopWork_Button.Name = "StopWork_Button";
            this.StopWork_Button.Size = new System.Drawing.Size(111, 23);
            this.StopWork_Button.TabIndex = 22;
            this.StopWork_Button.Text = "Стоп";
            this.StopWork_Button.UseVisualStyleBackColor = true;
            this.StopWork_Button.Click += new System.EventHandler(this.StopWork_Button_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(709, 172);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 21;
            this.Clear_button.Text = "Очистить";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // MakeStep_Button
            // 
            this.MakeStep_Button.Location = new System.Drawing.Point(132, 210);
            this.MakeStep_Button.Name = "MakeStep_Button";
            this.MakeStep_Button.Size = new System.Drawing.Size(111, 23);
            this.MakeStep_Button.TabIndex = 19;
            this.MakeStep_Button.Text = "Шаг";
            this.MakeStep_Button.UseVisualStyleBackColor = true;
            this.MakeStep_Button.Click += new System.EventHandler(this.MakeStepButton_Click);
            // 
            // DoAllSteps_Button
            // 
            this.DoAllSteps_Button.Location = new System.Drawing.Point(8, 184);
            this.DoAllSteps_Button.Name = "DoAllSteps_Button";
            this.DoAllSteps_Button.Size = new System.Drawing.Size(109, 23);
            this.DoAllSteps_Button.TabIndex = 18;
            this.DoAllSteps_Button.Text = "Выполнить";
            this.DoAllSteps_Button.UseVisualStyleBackColor = true;
            this.DoAllSteps_Button.Click += new System.EventHandler(this.DoAllSteps_Button_Click);
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.Location = new System.Drawing.Point(592, 210);
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Size = new System.Drawing.Size(111, 23);
            this.DeleteColumn.TabIndex = 17;
            this.DeleteColumn.Text = "Удалить столбец";
            this.DeleteColumn.UseVisualStyleBackColor = true;
            this.DeleteColumn.Click += new System.EventHandler(this.DeleteColumntButton_Click);
            // 
            // AddColumn
            // 
            this.AddColumn.Location = new System.Drawing.Point(453, 210);
            this.AddColumn.Name = "AddColumn";
            this.AddColumn.Size = new System.Drawing.Size(127, 23);
            this.AddColumn.TabIndex = 16;
            this.AddColumn.Text = "Добавить столбец";
            this.AddColumn.UseVisualStyleBackColor = true;
            this.AddColumn.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(709, 210);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 25;
            // 
            // TwoLinesTuringMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 541);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.OpenMachine_Button);
            this.Controls.Add(this.SaveMachine_Button);
            this.Controls.Add(this.StopWork_Button);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.MakeStep_Button);
            this.Controls.Add(this.DoAllSteps_Button);
            this.Controls.Add(this.DeleteColumn);
            this.Controls.Add(this.AddColumn);
            this.Controls.Add(this.Alphabet);
            this.Controls.Add(this.TableConditions);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.CurrentCondition);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TwoLinesTuringMachineForm";
            this.Text = "TwoLinesTuringMachine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwoLinesTuringMachineForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem скоростьВыполненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медленноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem быстрееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem быстроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оченьБыстроToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мгновенноToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonToLeftFirst;
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
        private System.Windows.Forms.Button ButtonToRightFirst;
        private System.Windows.Forms.Label CurrentCondition;
        private System.Windows.Forms.Button ButtonToLeftSecond;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button ButtonToRightSecond;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView TableConditions;
        private System.Windows.Forms.TextBox Alphabet;
        private System.Windows.Forms.Button OpenMachine_Button;
        private System.Windows.Forms.Button SaveMachine_Button;
        private System.Windows.Forms.Button StopWork_Button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button MakeStep_Button;
        private System.Windows.Forms.Button DoAllSteps_Button;
        private System.Windows.Forms.Button DeleteColumn;
        private System.Windows.Forms.Button AddColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}