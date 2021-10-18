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
        private String previousResult;
        public String Result { get; set; }
        public GetLineFromAlphabet(String str)
        {
            InitializeComponent();
            previousResult = "";
            Result = "";
            this.Visible = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
