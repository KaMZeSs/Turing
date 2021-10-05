using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Turing.Machines.OneLineTuringMachine
{
    public partial class GetElemFromAlphabet : Form
    {
        public char Letter { get; set; }
        public GetElemFromAlphabet(String str)
        {
            InitializeComponent();
            SetAllButtons(str);
            this.Visible = false;;
        }

        private void SetAllButtons(String str)
        {
            Button[] buttons = new Button[str.Length];
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Size = new Size(50, 50);
                buttons[i].Dock = DockStyle.Left;
                buttons[i].Text = str[i].ToString();
                buttons[i].Font = new Font("Microsoft Sans Serif", 20.25F);
                buttons[i].Location = new Point(50 * i, 0);
                buttons[i].Click += new EventHandler(this.OnButtonClick);
                buttons[i].Visible = true;
            }
            this.Controls.AddRange(buttons);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Letter = button.Text.ToCharArray()[0];
            this.DialogResult = DialogResult.OK;
        }
    }
}
