using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaitingLineSystem.Forms
{
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
            textBox1.Text = SmartLine.Instance.GetTurn().ToString();

        }

        private void Counter_Load(object sender, EventArgs e)
        {
            textBox1.Text = SmartLine.Instance.GetTurn().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = SmartLine.Instance.GetTurn().ToString();

        }
    }
}
