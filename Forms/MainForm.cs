using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaitingLineSystem;

namespace WaitingLineSystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var smartLine = SmartLine.Instance;
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            AF.Show();
        }

        private void VisitorBtn_Click(object sender, EventArgs e)
        {
            VisitorForm VF = new VisitorForm();
            VF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
