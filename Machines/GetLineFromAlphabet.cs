using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Turing.Library;

namespace Turing.Machines
{
    public partial class GetLineFromAlphabet : Form
    {
        String Alphabet;
        public String Result { get; set; }
        public GetLineFromAlphabet(String str)
        {
            InitializeComponent();
            Alphabet = str;
            this.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            String str = e.KeyCode.ToString();
            str = str.ToLower();
            if (!Alphabet.Contains(str))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
