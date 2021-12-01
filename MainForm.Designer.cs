
namespace Turing
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OneLineGraphic = new System.Windows.Forms.Button();
            this.FourLinesGraphic = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Одноленточная";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(177, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Трехленточная";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OpenThreeLines);
            // 
            // OneLineGraphic
            // 
            this.OneLineGraphic.Location = new System.Drawing.Point(12, 41);
            this.OneLineGraphic.Name = "OneLineGraphic";
            this.OneLineGraphic.Size = new System.Drawing.Size(125, 57);
            this.OneLineGraphic.TabIndex = 0;
            this.OneLineGraphic.Text = "Расчет производительности одноленточной";
            this.OneLineGraphic.UseVisualStyleBackColor = true;
            this.OneLineGraphic.Click += new System.EventHandler(this.OneLineGraphic_Click);
            // 
            // FourLinesGraphic
            // 
            this.FourLinesGraphic.Location = new System.Drawing.Point(318, 41);
            this.FourLinesGraphic.Name = "FourLinesGraphic";
            this.FourLinesGraphic.Size = new System.Drawing.Size(125, 57);
            this.FourLinesGraphic.TabIndex = 2;
            this.FourLinesGraphic.Text = "Расчет производительности четырехленточной";
            this.FourLinesGraphic.UseVisualStyleBackColor = true;
            this.FourLinesGraphic.Click += new System.EventHandler(this.FourLinesGraphic_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Четырехленточная";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 110);
            this.Controls.Add(this.FourLinesGraphic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OneLineGraphic);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OneLineGraphic;
        private System.Windows.Forms.Button FourLinesGraphic;
        private System.Windows.Forms.Button button2;
    }
}