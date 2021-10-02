
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qweqweToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.одноленточнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двухленточнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qweqweToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(808, 489);
            this.MinimumSize = new System.Drawing.Size(808, 489);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qweqweToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem одноленточнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двухленточнаяToolStripMenuItem;
    }
}