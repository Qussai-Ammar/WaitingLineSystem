using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitingLineSystem.Forms;

namespace WaitingLineSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void CounterInfo_Click(object sender, EventArgs e)
        {
            Counter counter = new Counter();
            counter.Show();
            
        }
    }
}
