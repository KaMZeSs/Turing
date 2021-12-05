using System;
using System.Linq;
using System.Windows.Forms;

namespace Turing.Machines
{
    public partial class GetInputFromAlphabet : Form
    {
        Char[] Alphabet;
        public String result { get; set; }

        public GetInputFromAlphabet(String str)
        {
            InitializeComponent();
            this.Alphabet = str.ToCharArray();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            result = String.Empty;
            foreach (Char Letter in textBox1.Text)
                if (Alphabet.Contains(Letter))
                    result += Letter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
